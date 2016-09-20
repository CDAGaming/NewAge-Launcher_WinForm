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
using System.Windows.Forms;

namespace NewAgeLauncher
{
    public partial class AboutWindow : Form
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        public AboutWindow()
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

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            //Set Version ID
            VersionID.Text = Settings.Default.CurrentVersion;

            //Custom Fonts
            loadFont();

            AllocFont(font, this.Licenselbl, 8, false);
            AllocFont(font, this.Copyrightlbl, 8, false);
            AllocFont(font, this.Changeslbl, 8, false);
            AllocFont(font, this.AboutUsText, 8, false);
            AllocFont(font, this.VersionID, 8, false);
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Changeslbl_Click(object sender, EventArgs e)
        {
            UpdateWindow updatewindow = new UpdateWindow();
            updatewindow.ShowDialog();
        }
    }
}
