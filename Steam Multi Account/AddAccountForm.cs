using Steam_Multi_Account.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Multi_Account
{
    public partial class AddAccountForm : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AddAccountForm()
        {
            InitializeComponent();
            lb_error.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Username = tb_Username.Text;
            Password = tb_PAssword.Text;

            lb_error.Text = ValidateAccountData() ?? "";

            if (lb_error.Text.Length == 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private string ValidateAccountData()
        {
            string result = null;

            if (Username.Length == 0)
            {
                result = "Enter a username";
            }
            else if (AppModel.Instance.AccountStore.GetUsernames().Contains(Username))
            {
                result = "Account already added";
            }
            else if (Password.Length == 0)
            {
                result = "Enter a password";
            }

            return result;
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
