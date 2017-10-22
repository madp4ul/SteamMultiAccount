using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account.Model
{
    public class AccountStore : IEnumerable<Login>
    {
        private string _MasterPassword;
        public AccountStoreData SaveData { get; private set; }

        public event Action AccountsChanged;

        public AccountStore(string masterPassword, AccountStoreData data)
        {
            _MasterPassword = masterPassword;
            SaveData = data ?? throw new ArgumentNullException();

            if (!data.IsPasswordCorrect(masterPassword))
                throw new ArgumentException("Master password incorrect.");
        }

        public void AddAccount(string user, string password)
        {
            SaveData.Accounts.Add(new Login { Username = user, Password = StringCipher.Encrypt(password, _MasterPassword) });
            OnAccountsChanged();
        }

        public void RemoveAccount(string user)
        {
            SaveData.Accounts.Remove(SaveData.Accounts.First(l => l.Username == user));
            OnAccountsChanged();
        }

        public void SetAccountIndex(string username, int newIndex)
        {
            Login login = SaveData.Accounts.First(l => l.Username == username);

            //Atomic
            {
                SaveData.Accounts.Remove(login);
                SaveData.Accounts.Insert(newIndex, login);
            }

            OnAccountsChanged();
        }

        protected void OnAccountsChanged()
        {
            AccountsChanged?.Invoke();
        }

        public IEnumerable<string> GetUsernames()
        {
            return SaveData.Accounts.Select(l => l.Username);
        }

        public Login GetDecryptedLogin(string username)
        {
            var login = SaveData.Accounts.FirstOrDefault(l => l.Username == username);

            if (login == null)
                return null;

            return new Login { Username = login.Username, Password = StringCipher.Decrypt(login.Password, _MasterPassword) };
        }

        public IEnumerator<Login> GetEnumerator()
        {
            return SaveData.Accounts.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
