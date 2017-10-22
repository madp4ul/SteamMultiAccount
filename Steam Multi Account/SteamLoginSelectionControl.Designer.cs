namespace Steam_Multi_Account
{
    partial class SteamLoginSelectionControl
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
            this.ofd_SteamPath = new System.Windows.Forms.OpenFileDialog();
            this.pn_config = new System.Windows.Forms.Panel();
            this.btn_SetSteam = new System.Windows.Forms.Button();
            this.btn_AddSteamAccount = new System.Windows.Forms.Button();
            this.pn_Accounts = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd_SteamPath
            // 
            this.ofd_SteamPath.DefaultExt = "exe";
            this.ofd_SteamPath.FileName = "steam";
            this.ofd_SteamPath.Filter = "Executables|*.exe";
            this.ofd_SteamPath.InitialDirectory = "C:\\Program Files (x86)\\Steam";
            this.ofd_SteamPath.Title = "Select Steam path";
            // 
            // pn_config
            // 
            this.pn_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_config.Controls.Add(this.btn_SetSteam);
            this.pn_config.Controls.Add(this.btn_AddSteamAccount);
            this.pn_config.Location = new System.Drawing.Point(3, 156);
            this.pn_config.Name = "pn_config";
            this.pn_config.Size = new System.Drawing.Size(186, 42);
            this.pn_config.TabIndex = 1;
            // 
            // btn_SetSteam
            // 
            this.btn_SetSteam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SetSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetSteam.Location = new System.Drawing.Point(98, 3);
            this.btn_SetSteam.Name = "btn_SetSteam";
            this.btn_SetSteam.Size = new System.Drawing.Size(85, 36);
            this.btn_SetSteam.TabIndex = 1;
            this.btn_SetSteam.Text = "Set Steam location";
            this.btn_SetSteam.UseVisualStyleBackColor = true;
            this.btn_SetSteam.Click += new System.EventHandler(this.btn_SetSteam_Click);
            // 
            // btn_AddSteamAccount
            // 
            this.btn_AddSteamAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddSteamAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSteamAccount.Location = new System.Drawing.Point(3, 3);
            this.btn_AddSteamAccount.Name = "btn_AddSteamAccount";
            this.btn_AddSteamAccount.Size = new System.Drawing.Size(89, 36);
            this.btn_AddSteamAccount.TabIndex = 0;
            this.btn_AddSteamAccount.Text = "Add Steam account";
            this.btn_AddSteamAccount.UseVisualStyleBackColor = true;
            this.btn_AddSteamAccount.Click += new System.EventHandler(this.btn_AddSteamAccount_Click);
            // 
            // pn_Accounts
            // 
            this.pn_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Accounts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pn_Accounts.Location = new System.Drawing.Point(3, 25);
            this.pn_Accounts.Name = "pn_Accounts";
            this.pn_Accounts.Size = new System.Drawing.Size(186, 125);
            this.pn_Accounts.TabIndex = 4;
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(192, 22);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "Add an account";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SteamLoginSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pn_Accounts);
            this.Controls.Add(this.pn_config);
            this.Name = "SteamLoginSelectionControl";
            this.Size = new System.Drawing.Size(192, 201);
            this.Load += new System.EventHandler(this.SteamLoginSelectionControl_Load);
            this.pn_config.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_SteamPath;
        private System.Windows.Forms.Panel pn_config;
        private System.Windows.Forms.Button btn_SetSteam;
        private System.Windows.Forms.Button btn_AddSteamAccount;
        private System.Windows.Forms.FlowLayoutPanel pn_Accounts;
        private System.Windows.Forms.Label lb_title;
    }
}
