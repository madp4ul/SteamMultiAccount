using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steam_Multi_Account.Model;

namespace Steam_Multi_Account
{
    public partial class SteamLoginSelectionControl : UserControl
    {
        public event Action<Login> LoginSelected;


        public SteamLoginSelectionControl()
        {
            InitializeComponent();
        }

        private void SteamLoginSelectionControl_Load(object sender, EventArgs e)
        {
            AddAccountControls();
        }

        private void AddAccountControls()
        {
            pn_Accounts.Controls.Clear();

            var store = AppModel.Instance.AccountStore;

            int index = 0;
            foreach (var username in store.GetUsernames())
            {
                AddAccountControl(store, username, index);

                index++;
            }
            RefreshTitle();
            CompensateForHeightChange();
        }

        private void AddAccountControl(AccountStore store, string username, int index)
        {
            var accControl = new AccountControl();
            accControl.Text = username;

            accControl.MoveMeUp += () =>
            {
                store.SetAccountIndex(accControl.Text, --index);
                AddAccountControls();
            };
            accControl.RemoveClick += (o, e) =>
            {
                store.RemoveAccount(username);
                AddAccountControls();
            };
            accControl.LoginClick += (o, e) =>
            {
                var DecryptedLogin = store.GetDecryptedLogin(username);
                OnLoginSelected(DecryptedLogin);
            };

            AddControl(accControl);
        }

        private void RefreshTitle()
        {
            lb_title.Text = pn_Accounts.Controls.Count > 0 ? "Select your account" : "Add an account";
        }

        protected void OnLoginSelected(Login login)
        {
            LoginSelected?.Invoke(login);
        }

        private void AddControl(Control c)
        {
            c.Width = pn_Accounts.Width;

            pn_Accounts.Controls.Add(c);
        }

        private void CompensateForHeightChange()
        {
            int sumHeight = 0;
            foreach (var control in pn_Accounts.Controls)
            {
                var c = ((Control)control);

                sumHeight += c.Height + c.Margin.Top + c.Margin.Bottom;
            }

            int diff = sumHeight - pn_Accounts.Height;

            this.MinimumSize = new Size(this.MinimumSize.Width, this.Height + diff);

            this.Height = this.MinimumSize.Height;
        }

        private void btn_AddSteamAccount_Click(object sender, EventArgs e)
        {
            var messageBox = new AddAccountForm();
            if (messageBox.ShowDialog() == DialogResult.OK)
            {
                AppModel.Instance.AccountStore.AddAccount(messageBox.Username, messageBox.Password);
                AddAccountControls();
            }
        }

        private void btn_SetSteam_Click(object sender, EventArgs e)
        {
            string previousFileName = ofd_SteamPath.FileName;
            ofd_SteamPath.InitialDirectory = AppModel.Instance.SteamPath;

            if (ofd_SteamPath.ShowDialog() == DialogResult.OK)
            {
                AppModel.Instance.SteamPath = ofd_SteamPath.FileName;
                ofd_SteamPath.FileName = previousFileName;
            }
        }
    }
}
