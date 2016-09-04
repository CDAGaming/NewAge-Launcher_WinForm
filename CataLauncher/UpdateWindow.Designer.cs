namespace NewAgeLauncher
{
    partial class UpdateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWindow));
            this.UpdateMSGlbl = new System.Windows.Forms.Label();
            this.menuBar1 = new NewAgeLauncher.MenuBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ContinueorRestartButton = new System.Windows.Forms.Button();
            this.PostponeButton = new System.Windows.Forms.Button();
            this.CloseMinimizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.StartupCheckbox = new System.Windows.Forms.CheckBox();
            this.CloseMinimizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateMSGlbl
            // 
            this.UpdateMSGlbl.BackColor = System.Drawing.Color.Transparent;
            this.UpdateMSGlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateMSGlbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateMSGlbl.Location = new System.Drawing.Point(12, 34);
            this.UpdateMSGlbl.Name = "UpdateMSGlbl";
            this.UpdateMSGlbl.Size = new System.Drawing.Size(316, 30);
            this.UpdateMSGlbl.TabIndex = 7;
            this.UpdateMSGlbl.Text = "No Update Available (VX.X.X.X)";
            this.UpdateMSGlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuBar1
            // 
            this.menuBar1.ButtonColor = System.Drawing.Color.White;
            this.menuBar1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuBarText = "NewAge - Updates";
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(341, 31);
            this.menuBar1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 65);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(313, 294);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("http://wownewage.com/Launcher_Changes.html", System.UriKind.Absolute);
            // 
            // ContinueorRestartButton
            // 
            this.ContinueorRestartButton.Location = new System.Drawing.Point(241, 365);
            this.ContinueorRestartButton.Name = "ContinueorRestartButton";
            this.ContinueorRestartButton.Size = new System.Drawing.Size(87, 30);
            this.ContinueorRestartButton.TabIndex = 9;
            this.ContinueorRestartButton.Text = "Continue";
            this.ContinueorRestartButton.UseVisualStyleBackColor = true;
            // 
            // PostponeButton
            // 
            this.PostponeButton.Location = new System.Drawing.Point(148, 365);
            this.PostponeButton.Name = "PostponeButton";
            this.PostponeButton.Size = new System.Drawing.Size(87, 30);
            this.PostponeButton.TabIndex = 10;
            this.PostponeButton.Text = "Postpone";
            this.PostponeButton.UseVisualStyleBackColor = true;
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
            this.CloseMinimizePanel.Location = new System.Drawing.Point(285, 4);
            this.CloseMinimizePanel.Name = "CloseMinimizePanel";
            this.CloseMinimizePanel.RowCount = 1;
            this.CloseMinimizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CloseMinimizePanel.Size = new System.Drawing.Size(55, 25);
            this.CloseMinimizePanel.TabIndex = 77;
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
            // StartupCheckbox
            // 
            this.StartupCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.StartupCheckbox.ForeColor = System.Drawing.Color.White;
            this.StartupCheckbox.Location = new System.Drawing.Point(15, 369);
            this.StartupCheckbox.Name = "StartupCheckbox";
            this.StartupCheckbox.Size = new System.Drawing.Size(112, 24);
            this.StartupCheckbox.TabIndex = 78;
            this.StartupCheckbox.Text = "Show on Startup";
            this.StartupCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartupCheckbox.UseVisualStyleBackColor = false;
            this.StartupCheckbox.CheckedChanged += new System.EventHandler(this.StartupCheckbox_CheckedChanged);
            // 
            // UpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NewAgeLauncher.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.StartupCheckbox);
            this.Controls.Add(this.CloseMinimizePanel);
            this.Controls.Add(this.PostponeButton);
            this.Controls.Add(this.ContinueorRestartButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.UpdateMSGlbl);
            this.Controls.Add(this.menuBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateWindow";
            this.Text = "NewAge - Updates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateWindow_FormClosing);
            this.Load += new System.EventHandler(this.UpdateWindow_Load);
            this.CloseMinimizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuBar menuBar1;
        private System.Windows.Forms.Label UpdateMSGlbl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button ContinueorRestartButton;
        private System.Windows.Forms.Button PostponeButton;
        private System.Windows.Forms.TableLayoutPanel CloseMinimizePanel;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.CheckBox StartupCheckbox;
    }
}