using Steam_Multi_Account.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account
{
    class SteamStarter
    {
        public void RunSteam(Login login)
        {
            CleanlyEndSteamProcess();

            Process.Start(AppModel.Instance.SteamPath, $" -login \"{login.Username}\" \"{login.Password}\"");
        }

        private void CleanlyEndSteamProcess()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("Steam"))
                {
                    process.Kill();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
