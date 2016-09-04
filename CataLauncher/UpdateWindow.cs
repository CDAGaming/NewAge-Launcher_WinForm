using NewAgeLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewAgeLauncher
{
    public partial class UpdateWindow : Form
    {

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

        private void UpdateWindow_Load(object sender, EventArgs e)
        {
            Settings.Default.UpdatePGShow = StartupCheckbox.Checked;
            Settings.Default.UpdatePostPoned = false;
            Settings.Default.Save();
        }
    }
}
