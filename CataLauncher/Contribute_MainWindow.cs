using NewAgeLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewAgeLauncher
{
    public partial class Contribute_MainWindow : Form
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        public Contribute_MainWindow()
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

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Resources.MinimizeButton;
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Resources.MinimizeButtonNoHover;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Resources.ExitButtonNoHover;
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox.Image = Resources.ExitButton;
        }

        private void exitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Resources.ExitButtonPress;
        }

        private void MinimizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Resources.MinimizeButtonPress;
        }

        private void Contribute_MainWindow_Load(object sender, EventArgs e)
        {
            loadFont();

            AllocFont(font, this.label1, 12, false);
            AllocFont(font, this.DonateButton, 15, false);
            AllocFont(font, this.VoteButton, 12, false);
            AllocFont(font, this.menuBar1, 8, false);
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.DonateUrl);
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.VoteUrl);
        }
    }
}
