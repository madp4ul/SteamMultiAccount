using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account.Model
{
    /// <summary>
    /// Class that provides Access to Model data of the app (backend interface)
    /// </summary>
    class AppModel
    {
        #region Singleton stuff

        private static AppModel _Instance;
        public static AppModel Instance
        {
            get
            {
                if (_Instance == null)
                    return CreateModel();
                return _Instance;
            }
            set => Instance = value;
        }
        public static AppModel CreateModel() { _Instance = new AppModel(); return Instance; }
        #endregion


        #region data access stuff

        private DataSaver<string> _SteamPath;
        private DataSaver<AccountStoreData> _Logins;
        #endregion

        #region Wrappers for easy access of model data

        public string SteamPath
        {
            get => _SteamPath.GetConfiguration() ?? @"C:\Program Files (x86)\Steam\steam.exe";
            set => _SteamPath.Save(value);
        }
        private AccountStoreData Logins
        {
            get => _Logins.GetConfiguration();
            set => _Logins.Save(value);
        }
        public AccountStore AccountStore { get; private set; }
        #endregion

        public AppModel()
        {
            _Logins = new DataSaver<AccountStoreData>("logins");
            _Logins.Load();

            _SteamPath = new DataSaver<string>("steampath");
            _SteamPath.Load();
        }

        public bool TrySetAccountStore(string masterPassword)
        {
            //Create default if non-existent.
            if (Logins == null)
            {
                Logins = AccountStoreData.Create(new Login[0], masterPassword);
                LogInMasterAccount(masterPassword);
                return true;
            }
            else if (Logins.IsPasswordCorrect(masterPassword))
            {
                LogInMasterAccount(masterPassword);
                return true;
            }
            return false;
        }

        public bool MasterAccountExists()
        {
            return Logins != null;
        }

        public void DeleteMasterAccount()
        {
            Logins = null;
        }

        private void LogInMasterAccount(string masterPassword)
        {
            AccountStore = new AccountStore(masterPassword, Logins);
            AccountStore.AccountsChanged += SaveAccounts;
        }

        private void SaveAccounts()
        {
            _Logins.Save();
        }
    }
}
