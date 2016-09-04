/* 
    NewAge Launcher
    Copyright (C) 2016  Jestus

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


using NewAgeLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Squirrel;
using System.Threading.Tasks;

namespace NewAgeLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            // Sets Current Version (For Use in Update Window & About)

            string CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Settings.Default.CurrentVersion = CurrentVersion;
            Settings.Default.Save();

            ///* Use this Tag for Debugging
            Task.Run(async () =>
             {
                 if (Settings.Default.CheckforUpdateTag == true)
                 {
                     using (var updater = await UpdateManager.GitHubUpdateManager("https://github.com/CDAGaming/NewAge-Launcher_WinForm"))
                     {
                         if (Settings.Default.UpdatePGShow == false && Settings.Default.CheckforUpdateTag == true)
                         {
                             var UpdateCheck = await updater.CheckForUpdate();

                             if (UpdateCheck.ReleasesToApply.Any())
                             {
                                 Settings.Default.UpdateAvailable = true;
                                 Settings.Default.UpdatePGShow = true;

                                 string FutureVersion = UpdateCheck.FutureReleaseEntry.Version.ToString();
                                 Settings.Default.FutureVersion = FutureVersion;
                                 Settings.Default.Save();
                             }
                         }
                         else if (Settings.Default.UpdatePGShow == true && Settings.Default.CheckforUpdateTag == true)
                         {
                             var UpdateCheck = await updater.CheckForUpdate();

                             if (UpdateCheck.ReleasesToApply.Any())
                             {
                                 string UpdateMSG = "Update Available:" + "(" + Settings.Default.CurrentVersion + ">" + Settings.Default.FutureVersion + ")";
                                 Settings.Default.UpdateAvailable = true;
                                 Settings.Default.UpdateMessage = UpdateMSG;
                                 Settings.Default.Save();

                                 UpdateWindow UpdatePG = new UpdateWindow();
                                 UpdatePG.ShowDialog();

                                 if (Settings.Default.UpdateAccepted == true && Settings.Default.UpdatePostPoned == false)
                                 {
                                     await updater.ApplyReleases(UpdateCheck);

                                     Application.Restart();
                                 }
                                 else if (Settings.Default.UpdateAccepted == false && Settings.Default.UpdatePostPoned == true)
                                 {
                                     MessageBox.Show("You Will be Reminded On Next Reboot of Launcher");
                                 }

                             }
                         }
                         else if (Settings.Default.UpdatePGShow == false && Settings.Default.CheckforUpdateTag == false)
                         {
                             // Do Nothing in Startup Event
                         }
                         else if (Settings.Default.UpdatePGShow == true && Settings.Default.CheckforUpdateTag == false)
                         {
                             UpdateWindow UpdatePG = new UpdateWindow();
                             UpdatePG.ShowDialog();
                         }
                     }
                 }
             }).Wait();

            // Debug END */

        }
    }
}
