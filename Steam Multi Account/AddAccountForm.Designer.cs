namespace Steam_Multi_Account
{
    partial class AddAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PAssword = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(30, 25);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(122, 20);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tb_PAssword
            // 
            this.tb_PAssword.Location = new System.Drawing.Point(30, 77);
            this.tb_PAssword.Name = "tb_PAssword";
            this.tb_PAssword.PasswordChar = '*';
            this.tb_PAssword.Size = new System.Drawing.Size(122, 20);
            this.tb_PAssword.TabIndex = 3;
            this.tb_PAssword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(30, 122);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(122, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add Account";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.Color.Tomato;
            this.lb_error.Location = new System.Drawing.Point(27, 103);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(28, 13);
            this.lb_error.TabIndex = 5;
            this.lb_error.Text = "error";
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(183, 157);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_PAssword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Steam account";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PAssword;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_error;
    }
}