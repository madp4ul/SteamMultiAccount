namespace Steam_Multi_Account
{
    partial class MasterLoginControl
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
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.ll_Delete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_Pw
            // 
            this.tb_Pw.Location = new System.Drawing.Point(29, 33);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.PasswordChar = '*';
            this.tb_Pw.Size = new System.Drawing.Size(139, 20);
            this.tb_Pw.TabIndex = 0;
            this.tb_Pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Pw_KeyDown);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(29, 14);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(23, 13);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "title";
            // 
            // btn_ok
            // 
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(174, 31);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(34, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lb_error
            // 
            this.lb_error.ForeColor = System.Drawing.Color.Tomato;
            this.lb_error.Location = new System.Drawing.Point(29, 56);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(235, 28);
            this.lb_error.TabIndex = 3;
            this.lb_error.Text = "Error";
            // 
            // ll_Delete
            // 
            this.ll_Delete.AutoSize = true;
            this.ll_Delete.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ll_Delete.Location = new System.Drawing.Point(74, 14);
            this.ll_Delete.Name = "ll_Delete";
            this.ll_Delete.Size = new System.Drawing.Size(78, 13);
            this.ll_Delete.TabIndex = 5;
            this.ll_Delete.TabStop = true;
            this.ll_Delete.Text = "delete account";
            this.ll_Delete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Delete_LinkClicked);
            // 
            // MasterLoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ll_Delete);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.tb_Pw);
            this.MinimumSize = new System.Drawing.Size(264, 84);
            this.Name = "MasterLoginControl";
            this.Size = new System.Drawing.Size(264, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pw;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.LinkLabel ll_Delete;
    }
}
