using NewAgeLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace NewAgeLauncher
{
    public partial class UpdateWindow : Form
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void StartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (StartupCheckbox.Checked)
            {
                Settings.Default.UpdatePGShow = true;
            }
            else
            {
                Settings.Default.UpdatePGShow = false;
            }

            Settings.Default.Save();

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

        private void ContinueorRestartButton_Click1(object sender, EventArgs e)
        {
            Settings.Default.UpdateAccepted = true;
            Settings.Default.Save();
            Application.Restart();
        }

        private void ContineorRestartButton_Click2(object sender, EventArgs e)
        {
            Close();
        }

        private void Postpone_Button_Click(object sender, EventArgs e)
        {
            Settings.Default.UpdatePostPoned = true;
            Settings.Default.Save();

            Close();
        }

        private void UpdateWindow_Load(object sender, EventArgs e)
        {

            loadFont();
            
            Settings.Default.UpdatePGShow = StartupCheckbox.Checked;
            Settings.Default.UpdatePostPoned = false;
            Settings.Default.Save();

            AllocFont(font, this.ContinueorRestartButton, 8, false);
            AllocFont(font, this.PostponeButton, 8, false);
            AllocFont(font, this.StartupCheckbox, 8, false);
            AllocFont(font, this.menuBar1, 14, false);

            if (Settings.Default.UpdateAvailable == true)
            {
                UpdateMSGlbl.Text = Settings.Default.UpdateMessage;
                UpdateMSGlbl.Enabled = true;
                UpdateMSGlbl.Visible = true;
                AllocFont(font, this.UpdateMSGlbl, 12, false);

                ContinueorRestartButton.Enabled = true;
                ContinueorRestartButton.Visible = true;
                ContinueorRestartButton.Text = "Update";
                ContinueorRestartButton.Click += new EventHandler(ContinueorRestartButton_Click1);

                PostponeButton.Enabled = true;
                PostponeButton.Visible = true;
                PostponeButton.Text = "Postpone";
                PostponeButton.Click += new EventHandler(Postpone_Button_Click);
            }
            else if (Settings.Default.UpdateAvailable == false)
            {
                UpdateMSGlbl.Text = Settings.Default.UpdateMessage;
                UpdateMSGlbl.Enabled = true;
                UpdateMSGlbl.Visible = true;
                AllocFont(font, this.UpdateMSGlbl, 12, false);

                ContinueorRestartButton.Enabled = true;
                ContinueorRestartButton.Visible = true;
                ContinueorRestartButton.Text = "Continue";
                ContinueorRestartButton.Click += new EventHandler(ContineorRestartButton_Click2);

                PostponeButton.Enabled = false;
                PostponeButton.Visible = false;
                PostponeButton.Text = "";
            }
        }
    }
}
