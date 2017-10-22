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
    public partial class MasterLoginControl : UserControl
    {
        public event Action LoggedIn;
        public event Action AccountDeleted;

        private PasswordIncorrectPhraseSupplier _Phrases;

        public MasterLoginControl()
        {
            InitializeComponent();

            _Phrases = new PasswordIncorrectPhraseSupplier();

            if (AppModel.Instance.MasterAccountExists())
            {
                lb_Title.Text = "Log in or";
            }
            else
            {
                ll_Delete.Hide();
                lb_Title.Text = "Create Master Account";
            }

            lb_error.Text = "";
            tb_Pw.Focus();
        }

        protected void OnPasswordEntered()
        {
            var password = tb_Pw.Text;

            if (AppModel.Instance.TrySetAccountStore(password))
            {
                LoggedIn?.Invoke();
            }
            else
            {
                lb_error.Text = _Phrases.GetPasswordIncorrectPhrase();
            }
        }

        private void tb_Pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnPasswordEntered();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            OnPasswordEntered();
        }

        private void ll_Delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the existing account?", "Delete account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AppModel.Instance.DeleteMasterAccount();
                AccountDeleted?.Invoke();
            }
        }
    }
}
