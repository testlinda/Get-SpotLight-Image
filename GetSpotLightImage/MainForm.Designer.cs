namespace GetSpotLightImage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_get = new System.Windows.Forms.Button();
            this.progressBar_doWork = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.checkBox_desktop = new System.Windows.Forms.CheckBox();
            this.checkBox_mobile = new System.Windows.Forms.CheckBox();
            this.label_result = new System.Windows.Forms.Label();
            this.pictureBox_dirDesktop = new System.Windows.Forms.PictureBox();
            this.pictureBox_dirMobile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirDesktop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(25, 27);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(70, 70);
            this.button_get.TabIndex = 0;
            this.button_get.Text = "Get";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // progressBar_doWork
            // 
            this.progressBar_doWork.Location = new System.Drawing.Point(111, 74);
            this.progressBar_doWork.Name = "progressBar_doWork";
            this.progressBar_doWork.Size = new System.Drawing.Size(118, 23);
            this.progressBar_doWork.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_doWork.TabIndex = 1;
            this.progressBar_doWork.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // checkBox_desktop
            // 
            this.checkBox_desktop.AutoSize = true;
            this.checkBox_desktop.Checked = true;
            this.checkBox_desktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_desktop.Location = new System.Drawing.Point(111, 27);
            this.checkBox_desktop.Name = "checkBox_desktop";
            this.checkBox_desktop.Size = new System.Drawing.Size(62, 16);
            this.checkBox_desktop.TabIndex = 2;
            this.checkBox_desktop.Text = "Desktop";
            this.checkBox_desktop.UseVisualStyleBackColor = true;
            // 
            // checkBox_mobile
            // 
            this.checkBox_mobile.AutoSize = true;
            this.checkBox_mobile.Location = new System.Drawing.Point(111, 50);
            this.checkBox_mobile.Name = "checkBox_mobile";
            this.checkBox_mobile.Size = new System.Drawing.Size(57, 16);
            this.checkBox_mobile.TabIndex = 3;
            this.checkBox_mobile.Text = "Mobile";
            this.checkBox_mobile.UseVisualStyleBackColor = true;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_result.Location = new System.Drawing.Point(109, 85);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(117, 12);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Hello, have a good day!";
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // pictureBox_dirDesktop
            // 
            this.pictureBox_dirDesktop.Image = global::GetSpotLightImage.Properties.Resources.folder;
            this.pictureBox_dirDesktop.Location = new System.Drawing.Point(174, 27);
            this.pictureBox_dirDesktop.Name = "pictureBox_dirDesktop";
            this.pictureBox_dirDesktop.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_dirDesktop.TabIndex = 6;
            this.pictureBox_dirDesktop.TabStop = false;
            this.pictureBox_dirDesktop.Visible = false;
            this.pictureBox_dirDesktop.Click += new System.EventHandler(this.pictureBox_dirDesktop_Click);
            // 
            // pictureBox_dirMobile
            // 
            this.pictureBox_dirMobile.Image = global::GetSpotLightImage.Properties.Resources.folder;
            this.pictureBox_dirMobile.Location = new System.Drawing.Point(174, 49);
            this.pictureBox_dirMobile.Name = "pictureBox_dirMobile";
            this.pictureBox_dirMobile.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_dirMobile.TabIndex = 6;
            this.pictureBox_dirMobile.TabStop = false;
            this.pictureBox_dirMobile.Visible = false;
            this.pictureBox_dirMobile.Click += new System.EventHandler(this.pictureBox_dirMobile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 124);
            this.Controls.Add(this.pictureBox_dirMobile);
            this.Controls.Add(this.pictureBox_dirDesktop);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.checkBox_mobile);
            this.Controls.Add(this.checkBox_desktop);
            this.Controls.Add(this.progressBar_doWork);
            this.Controls.Add(this.button_get);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Get SpotLight Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirDesktop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.ProgressBar progressBar_doWork;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox checkBox_desktop;
        private System.Windows.Forms.CheckBox checkBox_mobile;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.PictureBox pictureBox_dirDesktop;
        private System.Windows.Forms.PictureBox pictureBox_dirMobile;
    }
}

