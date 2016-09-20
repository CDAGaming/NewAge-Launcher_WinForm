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

            Version CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version;
            //Settings.Default.CurrentVersion = CurrentVersion;
            //Settings.Default.Save();

            if (Settings.Default.UpdatePostPoned == true)
            {
                Settings.Default.UpdatePostPoned = false;
                Settings.Default.Save();
            }

            ///* Use this Tag for Debugging
            Task.Run(async () =>
             {
                 if (Settings.Default.CheckforUpdateTag == true && Settings.Default.UpdatePGShow == true)
                 {

                     using (var updater = await UpdateManager.GitHubUpdateManager("https://github.com/CDAGaming/NewAge-Launcher_WinForm"))
                     {
                         var updatecheck = await updater.CheckForUpdate();

                         if (updatecheck.ReleasesToApply.Any())
                         {
                             string FutureVersion = updatecheck.FutureReleaseEntry.Version.ToString();
                             Version FutureVer = Version.Parse(FutureVersion);
                             Settings.Default.FutureVersion = FutureVersion;
                             Settings.Default.Save();

                             if (CurrentVersion < FutureVer)
                             {
                                 string UpdateMSG = "An Update is Available: " + " ( " + CurrentVersion + " > " + FutureVersion + " ) ";
                                 UpdateMSG.Replace(",", ".");
                                 Settings.Default.UpdateMessage = UpdateMSG;
                                 Settings.Default.UpdateAvailable = true;
                                 Settings.Default.Save();

                                 if (Settings.Default.UpdateAccepted == true && Settings.Default.UpdatePostPoned == false)
                                 {
                                     await updater.ApplyReleases(updatecheck);

                                     Settings.Default.UpdateAccepted = false;
                                     Settings.Default.Save();
                                 }
                                 else if (Settings.Default.UpdateAccepted == false && Settings.Default.UpdatePostPoned == true)
                                 {
                                     
                                 }
                             }
                             else if (CurrentVersion == FutureVer)
                             {
                                 string UpdateMSG = "Already Up-To-Date :D" + " ( " + CurrentVersion + " ) ";
                                 UpdateMSG.Replace(",", ".");
                                 Settings.Default.UpdateMessage = UpdateMSG;
                                 Settings.Default.UpdateAvailable = false;
                                 Settings.Default.Save();
                             }
                             else if (CurrentVersion > FutureVer)
                             {
                                 string UpdateMSG = "Already Up-To-Date :D" + " ( " + CurrentVersion + " ) ";
                                 UpdateMSG.Replace(",", ".");
                                 Settings.Default.UpdateMessage = UpdateMSG;
                                 Settings.Default.UpdateAvailable = false;
                                 Settings.Default.Save();
                             }

                         }
                         else
                         {
                             string UpdateMSG = "Already Up-To-Date :D" + " ( " + CurrentVersion + " ) ";
                             UpdateMSG.Replace(",", ".");
                             Settings.Default.UpdateMessage = UpdateMSG;
                             Settings.Default.UpdateAvailable = false;
                             Settings.Default.Save();
                         }
                     }
                     UpdateWindow updatepg = new UpdateWindow();
                     updatepg.ShowDialog();
                 }
                 else if (Settings.Default.CheckforUpdateTag == false && Settings.Default.UpdatePGShow == false)
                 {
                     // N/A
                 }
                 else if (Settings.Default.CheckforUpdateTag == true && Settings.Default.UpdatePGShow == false)
                 {

                 }
                 else if (Settings.Default.CheckforUpdateTag == false && Settings.Default.UpdatePGShow == true)
                 {
                     UpdateWindow updatepg = new UpdateWindow();
                     updatepg.ShowDialog();
                 }
             }).Wait();

            // Debug END */
        }
    }
}
