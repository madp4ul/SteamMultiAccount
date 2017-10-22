using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Multi_Account
{

    public partial class AccountControl : UserControl
    {
        public override string Text { get => btn_Login.Text; set => btn_Login.Text = value; }

        public event Action MoveMeUp;

        public event EventHandler RemoveClick
        {
            add { this.btn_RemoveAccount.Click += value; }
            remove { this.btn_RemoveAccount.Click -= value; }
        }

        public event EventHandler LoginClick
        {
            add { this.btn_Login.Click += value; }
            remove { this.btn_Login.Click -= value; }
        }

        private int _Index;
        public bool First
        {
            get => _Index == 0;
        }

        public AccountControl()
        {
            InitializeComponent();
            this.ParentChanged += AccountControl_ParentChanged;

        }

        private void ParentForm_KeyDown(object sender, KeyEventArgs e)
        {
            int number = e.KeyValue - 48;

            if (number.InRange(1, 9) && number == _Index + 1)
            {
                this.btn_Login.PerformClick();
            }
        }

        private void AccountControl_ParentChanged(object sender, EventArgs e)
        {
            _Index = this.Parent?.Controls.IndexOf(this) ?? -1;

            this.btn_Up.Visible = !First;
            this.lb_Index.Text = $"{_Index + 1})";

            if (this.ParentForm != null)
            {
                this.ParentForm.KeyDown += ParentForm_KeyDown;
            }
        }



        private void btn_Up_Click(object sender, EventArgs e)
        {
            MoveMeUp?.Invoke();
        }
    }
}
