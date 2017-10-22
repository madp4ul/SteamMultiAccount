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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ShowMasterLogin();
        }

        private void ShowMasterLogin()
        {
            SetDisplay(CreateMasterLoginControl());
        }

        private MasterLoginControl CreateMasterLoginControl()
        {
            var login = new MasterLoginControl();
            login.LoggedIn += () => SetDisplay(CreateLoginselection());
            login.AccountDeleted += ShowMasterLogin; //Reload itself

            return login;
        }

        private SteamLoginSelectionControl CreateLoginselection()
        {
            var accountSelect = new SteamLoginSelectionControl();
            accountSelect.LoginSelected += AccountSelect_LoginSelected;
            return accountSelect;
        }

        private void AccountSelect_LoginSelected(Login login)
        {
            new SteamStarter().RunSteam(login);
            this.Close();
        }

        private void SetDisplay(Control control)
        {
            //control.Top = control.Left = 0;


            FitToControl(control);
            this.MinimumSize = this.Size;
            control.Dock = DockStyle.Fill;
            control.Resize += (o, e) => FitToControl(control);

            this.Controls.Clear();
            this.Controls.Add(control);
            RecursiveClick(control);
            control.Focus();
        }

        private void FitToControl(Control control)
        {
            this.MinimumSize = new Size(control.Width, control.Height);
            this.ClientSize = this.MinimumSize;
        }

        private void RecursiveClick(Control control)
        {
            control.Click += MainForm_Click;

            foreach (var child in control.Controls.OfType<Control>()
                .Where(c => (
                c is UserControl
                || c is Panel
                || (c is Label && !(c is LinkLabel))
                )))
            {
                RecursiveClick((Control)child);
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
