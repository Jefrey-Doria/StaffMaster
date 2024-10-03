namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Exit = new System.Windows.Forms.Label();
            this.labelEMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.loginShowPassword = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelUserIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.labelRegisterUsername = new System.Windows.Forms.Label();
            this.labelRegisterAccount = new System.Windows.Forms.Label();
            this.flowLayoutPanelEmsImg = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Poppins Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(907, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 37);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelEMS
            // 
            this.labelEMS.AutoSize = true;
            this.labelEMS.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEMS.Location = new System.Drawing.Point(502, 564);
            this.labelEMS.Name = "labelEMS";
            this.labelEMS.Size = new System.Drawing.Size(407, 29);
            this.labelEMS.TabIndex = 14;
            this.labelEMS.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.registerEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.linkLabelLogin);
            this.panel1.Controls.Add(this.labelRegister);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.loginShowPassword);
            this.panel1.Controls.Add(this.flowLayoutPanelUserIcon);
            this.panel1.Controls.Add(this.registerPassword);
            this.panel1.Controls.Add(this.registerUsername);
            this.panel1.Controls.Add(this.labelRegisterPassword);
            this.panel1.Controls.Add(this.labelRegisterUsername);
            this.panel1.Controls.Add(this.labelRegisterAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 780);
            this.panel1.TabIndex = 11;
            // 
            // registerEmail
            // 
            this.registerEmail.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEmail.Location = new System.Drawing.Point(28, 371);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(387, 33);
            this.registerEmail.TabIndex = 4;
            this.registerEmail.TextChanged += new System.EventHandler(this.registerEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(29, 349);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 19);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogin.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabelLogin.Location = new System.Drawing.Point(179, 655);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(35, 18);
            this.linkLabelLogin.TabIndex = 9;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegister.Location = new System.Drawing.Point(28, 657);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(155, 15);
            this.labelRegister.TabIndex = 8;
            this.labelRegister.Text = "Already Have An Account?";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(26, 585);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(387, 56);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // loginShowPassword
            // 
            this.loginShowPassword.AutoSize = true;
            this.loginShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginShowPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginShowPassword.Location = new System.Drawing.Point(297, 508);
            this.loginShowPassword.Name = "loginShowPassword";
            this.loginShowPassword.Size = new System.Drawing.Size(116, 19);
            this.loginShowPassword.TabIndex = 6;
            this.loginShowPassword.Text = "Show Password";
            this.loginShowPassword.UseVisualStyleBackColor = true;
            this.loginShowPassword.CheckedChanged += new System.EventHandler(this.loginShowPassword_CheckedChanged);
            // 
            // flowLayoutPanelUserIcon
            // 
            this.flowLayoutPanelUserIcon.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources._552848;
            this.flowLayoutPanelUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelUserIcon.Location = new System.Drawing.Point(26, 94);
            this.flowLayoutPanelUserIcon.Name = "flowLayoutPanelUserIcon";
            this.flowLayoutPanelUserIcon.Size = new System.Drawing.Size(387, 150);
            this.flowLayoutPanelUserIcon.TabIndex = 5;
            // 
            // registerPassword
            // 
            this.registerPassword.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassword.Location = new System.Drawing.Point(26, 466);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '•';
            this.registerPassword.Size = new System.Drawing.Size(387, 33);
            this.registerPassword.TabIndex = 5;
            this.registerPassword.TextChanged += new System.EventHandler(this.registerPassword_TextChanged);
            // 
            // registerUsername
            // 
            this.registerUsername.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsername.Location = new System.Drawing.Point(26, 281);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(387, 33);
            this.registerUsername.TabIndex = 3;
            this.registerUsername.TextChanged += new System.EventHandler(this.registerUsername_TextChanged);
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPassword.Location = new System.Drawing.Point(27, 444);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(83, 19);
            this.labelRegisterPassword.TabIndex = 2;
            this.labelRegisterPassword.Text = "Password:";
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterUsername.Location = new System.Drawing.Point(23, 259);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(84, 19);
            this.labelRegisterUsername.TabIndex = 1;
            this.labelRegisterUsername.Text = "Username:";
            // 
            // labelRegisterAccount
            // 
            this.labelRegisterAccount.AutoSize = true;
            this.labelRegisterAccount.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterAccount.Location = new System.Drawing.Point(62, 41);
            this.labelRegisterAccount.Name = "labelRegisterAccount";
            this.labelRegisterAccount.Size = new System.Drawing.Size(322, 38);
            this.labelRegisterAccount.TabIndex = 0;
            this.labelRegisterAccount.Text = "REGISTER ACCOUNT";
            // 
            // flowLayoutPanelEmsImg
            // 
            this.flowLayoutPanelEmsImg.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.kindpng_2394224;
            this.flowLayoutPanelEmsImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelEmsImg.Location = new System.Drawing.Point(471, 94);
            this.flowLayoutPanelEmsImg.Name = "flowLayoutPanelEmsImg";
            this.flowLayoutPanelEmsImg.Size = new System.Drawing.Size(458, 450);
            this.flowLayoutPanelEmsImg.TabIndex = 15;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(952, 780);
            this.Controls.Add(this.flowLayoutPanelEmsImg);
            this.Controls.Add(this.labelEMS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label labelEMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.CheckBox loginShowPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserIcon;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterUsername;
        private System.Windows.Forms.Label labelRegisterAccount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmsImg;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}