namespace Steam_Multi_Account
{
    partial class AccountControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_RemoveAccount = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.lb_Index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(18, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(79, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "button login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveAccount
            // 
            this.btn_RemoveAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveAccount.Location = new System.Drawing.Point(140, 3);
            this.btn_RemoveAccount.Name = "btn_RemoveAccount";
            this.btn_RemoveAccount.Size = new System.Drawing.Size(18, 23);
            this.btn_RemoveAccount.TabIndex = 1;
            this.btn_RemoveAccount.Text = "X";
            this.btn_RemoveAccount.UseVisualStyleBackColor = true;
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Up.Location = new System.Drawing.Point(103, 3);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(31, 23);
            this.btn_Up.TabIndex = 2;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // lb_Index
            // 
            this.lb_Index.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Index.Location = new System.Drawing.Point(0, 0);
            this.lb_Index.Name = "lb_Index";
            this.lb_Index.Size = new System.Drawing.Size(18, 31);
            this.lb_Index.TabIndex = 3;
            this.lb_Index.Text = "x)";
            this.lb_Index.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Index);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_RemoveAccount);
            this.Controls.Add(this.btn_Login);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(165, 31);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_RemoveAccount;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Label lb_Index;
    }
}
