﻿/* 
    NewAge Launcher
    Copyright (C) 2016 Jestus

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NewAgeLauncher.Properties;
using System.Diagnostics;
using System.Drawing.Text;

namespace NewAgeLauncher
{
    public partial class SettingsForm : Form
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        public SettingsForm()
        {
            InitializeComponent();

        }

        private void loadFont()
        {
            byte[] fontArray = Resources.Montserrat_Regular;
            int dataLength = Resources.Montserrat_Regular.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Regular);

        }

        private void AllocFont(Font f, Control c, float size, Boolean bold)
        {
            if (bold)
            {
                FontStyle fontStyle = FontStyle.Bold;
                c.Font = new Font(ff, size, fontStyle);
            }
            else
            {
                FontStyle fontStyle = FontStyle.Regular;
                c.Font = new Font(ff, size, fontStyle);
            }

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Custom Fonts
            loadFont();

            AllocFont(font, this.Transparent_Checkbox, 8, false);
            AllocFont(font, this.UpdateCheckbox, 8, false);
            AllocFont(font, this.WoWCache_CheckBox, 8, false);
            AllocFont(font, this.wowLocationLabel, 8, false);
            AllocFont(font, this.wowLocationTextBox, 8, false);

            TransparencyKey = Color.Lime;

            if(Settings.Default.LanguageChangeTag == false)
            {
                Language_Checkbox.Checked = false;
            }

            wowLocationTextBox.Text = Settings.Default.WowLocation;
            Transparent_Checkbox.Checked = Settings.Default.TransparencyToggle;
            WoWCache_CheckBox.Checked = Settings.Default.WoWCacheToggle;
            Language_Checkbox.Checked = Settings.Default.LanguageChangeTag;
            UpdateCheckbox.Checked = Settings.Default.CheckforUpdateTag;
        }

        private void exitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButtonPress;
        }

        private void exitPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonPress;
        }

        private void MinimizePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButtonNoHover;
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonNoHover;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menuBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browseButton_Load(object sender, EventArgs e)
        {

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    wowLocationTextBox.Text = fbd.SelectedPath;
                }

            }
        }

        private void canc_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {


            // WoW Location Saving

            Settings.Default.WowLocation = wowLocationTextBox.Text;

            // Transparency Checkbox

            if (Transparent_Checkbox.Checked == true)
            {
                Settings.Default.TransparencyToggle = true;
            }
            if (Transparent_Checkbox.Checked == false)
            {
                Settings.Default.TransparencyToggle = false;
            }

            // WoW Cache CheckBox

            if (WoWCache_CheckBox.Checked)
            {
                Settings.Default.WoWCacheToggle = true;
            }
            else
            {
                Settings.Default.WoWCacheToggle = false;
            }

            // Language Change CheckBox

            if (Language_Checkbox.Checked)
            {
                Settings.Default.LanguageChangeTag = true;
            }
            else
            {
                Settings.Default.LanguageChangeTag = false;
            }

            //Update Checkbox

            if (UpdateCheckbox.Checked)
            {
                Settings.Default.CheckforUpdateTag = true;
            }
            else
            {
                Settings.Default.CheckforUpdateTag = false;
            }


            Settings.Default.Save();

            // Checks if The User Asks to Change Launguage
            // If so, Language Changer.exe is Launched

            if (Settings.Default.LanguageChangeTag == true)
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/bin/Launguage Changer.exe");
                WindowState = FormWindowState.Minimized;
                Application.Exit();
            }
            else
            {

            }

            Application.Restart();

        }
    }
}
