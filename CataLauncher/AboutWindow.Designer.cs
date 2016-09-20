namespace NewAgeLauncher
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.menuBar1 = new NewAgeLauncher.MenuBar();
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.NewAgeIMG = new System.Windows.Forms.PictureBox();
            this.VersionID = new System.Windows.Forms.Label();
            this.Copyrightlbl = new System.Windows.Forms.Label();
            this.AboutUsText = new System.Windows.Forms.Label();
            this.Licenselbl = new System.Windows.Forms.Label();
            this.Changeslbl = new System.Windows.Forms.Label();
            this.CloseMinimizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.fbButton = new System.Windows.Forms.PictureBox();
            this.YoutubeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAgeIMG)).BeginInit();
            this.CloseMinimizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoutubeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.ButtonColor = System.Drawing.Color.White;
            this.menuBar1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuBarText = "NewAge - About";
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(301, 32);
            this.menuBar1.TabIndex = 0;
            // 
            // LogoImg
            // 
            this.LogoImg.BackColor = System.Drawing.Color.Transparent;
            this.LogoImg.BackgroundImage = global::NewAgeLauncher.Properties.Resources.CataLogo;
            this.LogoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoImg.Location = new System.Drawing.Point(12, 38);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(70, 70);
            this.LogoImg.TabIndex = 1;
            this.LogoImg.TabStop = false;
            // 
            // NewAgeIMG
            // 
            this.NewAgeIMG.BackColor = System.Drawing.Color.Transparent;
            this.NewAgeIMG.BackgroundImage = global::NewAgeLauncher.Properties.Resources.logo2;
            this.NewAgeIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewAgeIMG.Location = new System.Drawing.Point(88, 38);
            this.NewAgeIMG.Name = "NewAgeIMG";
            this.NewAgeIMG.Size = new System.Drawing.Size(199, 70);
            this.NewAgeIMG.TabIndex = 2;
            this.NewAgeIMG.TabStop = false;
            // 
            // VersionID
            // 
            this.VersionID.BackColor = System.Drawing.Color.Transparent;
            this.VersionID.ForeColor = System.Drawing.Color.White;
            this.VersionID.Location = new System.Drawing.Point(85, 111);
            this.VersionID.Name = "VersionID";
            this.VersionID.Size = new System.Drawing.Size(65, 25);
            this.VersionID.TabIndex = 3;
            this.VersionID.Text = "VX.X.X.X";
            this.VersionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Copyrightlbl
            // 
            this.Copyrightlbl.BackColor = System.Drawing.Color.Transparent;
            this.Copyrightlbl.ForeColor = System.Drawing.Color.White;
            this.Copyrightlbl.Location = new System.Drawing.Point(156, 111);
            this.Copyrightlbl.Name = "Copyrightlbl";
            this.Copyrightlbl.Size = new System.Drawing.Size(130, 25);
            this.Copyrightlbl.TabIndex = 4;
            this.Copyrightlbl.Text = "Copyright 2016 Jestus";
            this.Copyrightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUsText
            // 
            this.AboutUsText.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsText.ForeColor = System.Drawing.Color.White;
            this.AboutUsText.Location = new System.Drawing.Point(9, 136);
            this.AboutUsText.Name = "AboutUsText";
            this.AboutUsText.Size = new System.Drawing.Size(274, 114);
            this.AboutUsText.TabIndex = 5;
            this.AboutUsText.Text = "This Launcher is Designed for Use on NewAge Servers ONLY. This Launcher is Protec" +
    "ted by the General Public License V3.0, Please Check out the License File to Vie" +
    "w it.\r\n\r\n\r\n\r\n";
            // 
            // Licenselbl
            // 
            this.Licenselbl.BackColor = System.Drawing.Color.Transparent;
            this.Licenselbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Licenselbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Licenselbl.Location = new System.Drawing.Point(142, 261);
            this.Licenselbl.Name = "Licenselbl";
            this.Licenselbl.Size = new System.Drawing.Size(70, 30);
            this.Licenselbl.TabIndex = 6;
            this.Licenselbl.Text = "License";
            this.Licenselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Changeslbl
            // 
            this.Changeslbl.BackColor = System.Drawing.Color.Transparent;
            this.Changeslbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Changeslbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Changeslbl.Location = new System.Drawing.Point(218, 261);
            this.Changeslbl.Name = "Changeslbl";
            this.Changeslbl.Size = new System.Drawing.Size(70, 30);
            this.Changeslbl.TabIndex = 7;
            this.Changeslbl.Text = "Changes";
            this.Changeslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Changeslbl.Click += new System.EventHandler(this.Changeslbl_Click);
            // 
            // CloseMinimizePanel
            // 
            this.CloseMinimizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.CloseMinimizePanel.ColumnCount = 2;
            this.CloseMinimizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseMinimizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseMinimizePanel.Controls.Add(this.MinimizePictureBox, 0, 0);
            this.CloseMinimizePanel.Controls.Add(this.exitPictureBox, 1, 0);
            this.CloseMinimizePanel.Location = new System.Drawing.Point(245, 5);
            this.CloseMinimizePanel.Name = "CloseMinimizePanel";
            this.CloseMinimizePanel.RowCount = 1;
            this.CloseMinimizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CloseMinimizePanel.Size = new System.Drawing.Size(55, 25);
            this.CloseMinimizePanel.TabIndex = 76;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizePictureBox.Image = global::NewAgeLauncher.Properties.Resources.MinimizeButtonNoHover;
            this.MinimizePictureBox.Location = new System.Drawing.Point(3, 3);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(21, 19);
            this.MinimizePictureBox.TabIndex = 2;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitPictureBox.Image = global::NewAgeLauncher.Properties.Resources.ExitButtonNoHover;
            this.exitPictureBox.Location = new System.Drawing.Point(30, 3);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(22, 19);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // fbButton
            // 
            this.fbButton.BackColor = System.Drawing.Color.Transparent;
            this.fbButton.BackgroundImage = global::NewAgeLauncher.Properties.Resources.fb;
            this.fbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbButton.Location = new System.Drawing.Point(12, 261);
            this.fbButton.Name = "fbButton";
            this.fbButton.Size = new System.Drawing.Size(30, 30);
            this.fbButton.TabIndex = 77;
            this.fbButton.TabStop = false;
            // 
            // YoutubeButton
            // 
            this.YoutubeButton.BackColor = System.Drawing.Color.Transparent;
            this.YoutubeButton.BackgroundImage = global::NewAgeLauncher.Properties.Resources.yt;
            this.YoutubeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YoutubeButton.Location = new System.Drawing.Point(48, 261);
            this.YoutubeButton.Name = "YoutubeButton";
            this.YoutubeButton.Size = new System.Drawing.Size(30, 30);
            this.YoutubeButton.TabIndex = 78;
            this.YoutubeButton.TabStop = false;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewAgeLauncher.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.YoutubeButton);
            this.Controls.Add(this.fbButton);
            this.Controls.Add(this.CloseMinimizePanel);
            this.Controls.Add(this.Changeslbl);
            this.Controls.Add(this.Licenselbl);
            this.Controls.Add(this.AboutUsText);
            this.Controls.Add(this.Copyrightlbl);
            this.Controls.Add(this.VersionID);
            this.Controls.Add(this.NewAgeIMG);
            this.Controls.Add(this.LogoImg);
            this.Controls.Add(this.menuBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutWindow";
            this.Text = "NewAge - About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAgeIMG)).EndInit();
            this.CloseMinimizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoutubeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuBar menuBar1;
        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.PictureBox NewAgeIMG;
        private System.Windows.Forms.Label VersionID;
        private System.Windows.Forms.Label Copyrightlbl;
        private System.Windows.Forms.Label AboutUsText;
        private System.Windows.Forms.Label Licenselbl;
        private System.Windows.Forms.Label Changeslbl;
        private System.Windows.Forms.TableLayoutPanel CloseMinimizePanel;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox fbButton;
        private System.Windows.Forms.PictureBox YoutubeButton;
    }
}