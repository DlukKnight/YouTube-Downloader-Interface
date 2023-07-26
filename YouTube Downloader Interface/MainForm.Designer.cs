namespace YouTube_Downloader_Interface
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            gbTypes = new GroupBox();
            rbMP3 = new RadioButton();
            rbMP4 = new RadioButton();
            gbDestinationPath = new GroupBox();
            txtDestinationPath = new TextBox();
            btnDestinationPath = new Button();
            btnDownload = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            txtURL = new TextBox();
            youTubeWebBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            navigationBar = new GroupBox();
            homeNavButton = new Button();
            refreshNavButton = new Button();
            forwardNavButton = new Button();
            backNavButton = new Button();
            gbTypes.SuspendLayout();
            gbDestinationPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)youTubeWebBrowser).BeginInit();
            navigationBar.SuspendLayout();
            SuspendLayout();
            // 
            // gbTypes
            // 
            gbTypes.Controls.Add(rbMP3);
            gbTypes.Controls.Add(rbMP4);
            gbTypes.Location = new Point(12, 12);
            gbTypes.Name = "gbTypes";
            gbTypes.Size = new Size(132, 65);
            gbTypes.TabIndex = 0;
            gbTypes.TabStop = false;
            gbTypes.Text = "Format types";
            // 
            // rbMP3
            // 
            rbMP3.AutoSize = true;
            rbMP3.Location = new Point(70, 28);
            rbMP3.Name = "rbMP3";
            rbMP3.Size = new Size(49, 19);
            rbMP3.TabIndex = 1;
            rbMP3.Text = "MP3";
            rbMP3.UseVisualStyleBackColor = true;
            // 
            // rbMP4
            // 
            rbMP4.AutoSize = true;
            rbMP4.Checked = true;
            rbMP4.Location = new Point(15, 28);
            rbMP4.Name = "rbMP4";
            rbMP4.Size = new Size(49, 19);
            rbMP4.TabIndex = 0;
            rbMP4.TabStop = true;
            rbMP4.Text = "MP4";
            rbMP4.UseVisualStyleBackColor = true;
            // 
            // gbDestinationPath
            // 
            gbDestinationPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbDestinationPath.Controls.Add(txtDestinationPath);
            gbDestinationPath.Location = new Point(150, 12);
            gbDestinationPath.Name = "gbDestinationPath";
            gbDestinationPath.Size = new Size(600, 65);
            gbDestinationPath.TabIndex = 1;
            gbDestinationPath.TabStop = false;
            gbDestinationPath.Text = "Destination path";
            // 
            // txtDestinationPath
            // 
            txtDestinationPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestinationPath.Location = new Point(6, 28);
            txtDestinationPath.Name = "txtDestinationPath";
            txtDestinationPath.Size = new Size(554, 23);
            txtDestinationPath.TabIndex = 0;
            txtDestinationPath.TextChanged += TxtDestinationPath_TxtURL_TextChanged;
            // 
            // btnDestinationPath
            // 
            btnDestinationPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDestinationPath.BackgroundImage = Properties.Resources.folder_go;
            btnDestinationPath.BackgroundImageLayout = ImageLayout.Stretch;
            btnDestinationPath.Location = new Point(711, 39);
            btnDestinationPath.Name = "btnDestinationPath";
            btnDestinationPath.Size = new Size(28, 25);
            btnDestinationPath.TabIndex = 1;
            btnDestinationPath.UseVisualStyleBackColor = true;
            btnDestinationPath.Click += BtnDestinationPath_Click;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = SystemColors.Control;
            btnDownload.BackgroundImageLayout = ImageLayout.Zoom;
            btnDownload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.Black;
            btnDownload.Image = Properties.Resources.Download;
            btnDownload.ImageAlign = ContentAlignment.MiddleLeft;
            btnDownload.Location = new Point(1105, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(150, 50);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Download";
            btnDownload.TextAlign = ContentAlignment.MiddleLeft;
            btnDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += BtnDownload_Click;
            // 
            // txtURL
            // 
            txtURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtURL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtURL.Location = new Point(230, 26);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(869, 23);
            txtURL.TabIndex = 0;
            txtURL.TextChanged += TxtDestinationPath_TxtURL_TextChanged;
            txtURL.KeyDown += TxtURL_KeyDown;
            // 
            // youTubeWebBrowser
            // 
            youTubeWebBrowser.AllowExternalDrop = true;
            youTubeWebBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            youTubeWebBrowser.CreationProperties = null;
            youTubeWebBrowser.DefaultBackgroundColor = Color.White;
            youTubeWebBrowser.Location = new Point(12, 157);
            youTubeWebBrowser.Name = "youTubeWebBrowser";
            youTubeWebBrowser.Size = new Size(1263, 622);
            youTubeWebBrowser.Source = new Uri("https://www.youtube.com", UriKind.Absolute);
            youTubeWebBrowser.TabIndex = 4;
            youTubeWebBrowser.ZoomFactor = 1D;
            // 
            // navigationBar
            // 
            navigationBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navigationBar.Controls.Add(homeNavButton);
            navigationBar.Controls.Add(txtURL);
            navigationBar.Controls.Add(refreshNavButton);
            navigationBar.Controls.Add(forwardNavButton);
            navigationBar.Controls.Add(backNavButton);
            navigationBar.Controls.Add(btnDownload);
            navigationBar.Location = new Point(12, 83);
            navigationBar.Name = "navigationBar";
            navigationBar.Size = new Size(1263, 68);
            navigationBar.TabIndex = 3;
            navigationBar.TabStop = false;
            // 
            // homeNavButton
            // 
            homeNavButton.BackgroundImage = Properties.Resources.house;
            homeNavButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeNavButton.Location = new Point(174, 12);
            homeNavButton.Name = "homeNavButton";
            homeNavButton.Size = new Size(50, 50);
            homeNavButton.TabIndex = 3;
            homeNavButton.UseVisualStyleBackColor = true;
            homeNavButton.Click += HomeNavButton_Click;
            // 
            // refreshNavButton
            // 
            refreshNavButton.BackgroundImage = Properties.Resources.arrow_refresh;
            refreshNavButton.BackgroundImageLayout = ImageLayout.Stretch;
            refreshNavButton.Location = new Point(118, 12);
            refreshNavButton.Name = "refreshNavButton";
            refreshNavButton.Size = new Size(50, 50);
            refreshNavButton.TabIndex = 2;
            refreshNavButton.UseVisualStyleBackColor = true;
            refreshNavButton.Click += RefreshNavButton_Click;
            // 
            // forwardNavButton
            // 
            forwardNavButton.BackgroundImage = Properties.Resources.arrow_right;
            forwardNavButton.BackgroundImageLayout = ImageLayout.Stretch;
            forwardNavButton.Location = new Point(62, 12);
            forwardNavButton.Name = "forwardNavButton";
            forwardNavButton.Size = new Size(50, 50);
            forwardNavButton.TabIndex = 1;
            forwardNavButton.UseVisualStyleBackColor = true;
            forwardNavButton.Click += ForwardNavButton_Click;
            // 
            // backNavButton
            // 
            backNavButton.BackgroundImage = Properties.Resources.arrow_left;
            backNavButton.BackgroundImageLayout = ImageLayout.Stretch;
            backNavButton.Location = new Point(7, 12);
            backNavButton.Name = "backNavButton";
            backNavButton.Size = new Size(50, 50);
            backNavButton.TabIndex = 0;
            backNavButton.UseVisualStyleBackColor = true;
            backNavButton.Click += BackNavButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 791);
            Controls.Add(navigationBar);
            Controls.Add(youTubeWebBrowser);
            Controls.Add(btnDestinationPath);
            Controls.Add(gbDestinationPath);
            Controls.Add(gbTypes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1303, 824);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YouTube Downloader";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            gbTypes.ResumeLayout(false);
            gbTypes.PerformLayout();
            gbDestinationPath.ResumeLayout(false);
            gbDestinationPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)youTubeWebBrowser).EndInit();
            navigationBar.ResumeLayout(false);
            navigationBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTypes;
        private RadioButton rbMP3;
        private RadioButton rbMP4;
        private GroupBox gbDestinationPath;
        private Button btnDestinationPath;
        private TextBox txtDestinationPath;
        private Button btnDownload;
        private FolderBrowserDialog folderBrowserDialog;
        private TextBox txtURL;
        private Microsoft.Web.WebView2.WinForms.WebView2 youTubeWebBrowser;
        private GroupBox navigationBar;
        private Button backNavButton;
        private Button forwardNavButton;
        private Button homeNavButton;
        private Button refreshNavButton;
    }
}