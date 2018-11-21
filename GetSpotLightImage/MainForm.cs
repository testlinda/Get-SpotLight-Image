using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSpotLightImage
{
    public partial class MainForm : Form
    {
        const string downloadPath = @"download";
        const string mode_landscape = "Landscape";
        const string mode_portrait = "Portrait";
        string desktopPath = $"{downloadPath}/{mode_landscape}";
        string mobilePath = $"{downloadPath}/{mode_portrait}";
        string spotlightPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialization();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnInitialization();
        }

        private void Initialization()
        {
            string appData = Environment.GetEnvironmentVariable("LocalAppData");
            spotlightPath = $@"{appData}\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";

            if (Directory.Exists(desktopPath))
                pictureBox_dirDesktop.Visible = true;

            if (Directory.Exists(mobilePath))
                pictureBox_dirMobile.Visible = true;
        }

        private void UnInitialization()
        {

        }

        private void InitialDirectory()
        {
            if (!Directory.Exists(downloadPath))
                Directory.CreateDirectory(downloadPath);

            if (checkBox_mobile.Checked)
            {
                if (!Directory.Exists(mobilePath))
                    Directory.CreateDirectory(mobilePath);
            }

            if (checkBox_desktop.Checked)
            {
                if (!Directory.Exists(desktopPath))
                    Directory.CreateDirectory(desktopPath);
            }
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            DisableUI(true);
            this.backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            InitialDirectory();
            GetSpotlightImage();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DisableUI(false);
        }

        private void DisableUI(bool disable)
        {
            progressBar_doWork.Visible = disable;
            button_get.Enabled = !disable;
            checkBox_desktop.Enabled = !disable;
            checkBox_mobile.Enabled = !disable;
            label_result.Visible = !disable;

            if (Directory.Exists(desktopPath))
                pictureBox_dirDesktop.Visible = true;

            if (Directory.Exists(mobilePath))
                pictureBox_dirMobile.Visible = true;
        }

        private void GetSpotlightImage()
        {
            string[] files = Directory.GetFiles(spotlightPath);

            int count = 0;
            foreach (string file in files)
            {
                string mode = "";
                try
                {
                    using (Image image = Image.FromFile(file))
                    {
                        if (image.Height == 1920 & image.Width == 1080)
                        {
                            if (checkBox_mobile.Checked)
                                mode = mode_portrait;
                            else
                                throw new Exception();
                        }
                        else if (image.Height == 1080 & image.Width == 1920)
                        {
                            if (checkBox_desktop.Checked)
                                mode = mode_landscape;
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }
                catch
                {
                    //Console.WriteLine($"It's not Image: {i}/{files.Length}");
                    continue;
                }

                FileInfo fileInfo = new FileInfo(file);
                string newPath = $"{downloadPath}/{mode}/{mode}-{fileInfo.Name.Substring(0, 5)}.jpg";

                if (!File.Exists(newPath))
                {
                    fileInfo.CopyTo(newPath);
                    count++;
                }
            }

            SetText(label_result, $"Acquire {count} new images.");
        }

        delegate void SetTextCallback(Control ctl, string text);
        private void SetText(Control ctl, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (ctl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { ctl, text });
            }
            else
            {
                ctl.Text = text;
            }
        }

        private void label_result_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(spotlightPath);
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void pictureBox_dirDesktop_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, desktopPath);
            try
            {
                Process.Start(path);
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void pictureBox_dirMobile_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, mobilePath);
            try
            {
                Process.Start(path);
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }
    }
}
