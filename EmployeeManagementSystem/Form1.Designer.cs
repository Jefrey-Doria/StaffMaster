namespace EmployeeManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.loginShowPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelUserIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.labelEMS = new System.Windows.Forms.Label();
            this.flowLayoutPanelEmsImg = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabelRegister);
            this.panel1.Controls.Add(this.labelRegister);
            this.panel1.Controls.Add(this.buttonSignIn);
            this.panel1.Controls.Add(this.loginShowPassword);
            this.panel1.Controls.Add(this.checkBoxShowPassword);
            this.panel1.Controls.Add(this.flowLayoutPanelUserIcon);
            this.panel1.Controls.Add(this.loginPassword);
            this.panel1.Controls.Add(this.loginUsername);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 780);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegister.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelRegister.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabelRegister.Location = new System.Drawing.Point(165, 654);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(50, 18);
            this.linkLabelRegister.TabIndex = 5;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegister.Location = new System.Drawing.Point(28, 657);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(141, 15);
            this.labelRegister.TabIndex = 8;
            this.labelRegister.Text = "Don\'t Have An Account?";
            this.labelRegister.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignIn.Location = new System.Drawing.Point(26, 585);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(387, 56);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "LOGIN";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // loginShowPassword
            // 
            this.loginShowPassword.AutoSize = true;
            this.loginShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginShowPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginShowPassword.Location = new System.Drawing.Point(297, 520);
            this.loginShowPassword.Name = "loginShowPassword";
            this.loginShowPassword.Size = new System.Drawing.Size(116, 19);
            this.loginShowPassword.TabIndex = 3;
            this.loginShowPassword.Text = "Show Password";
            this.loginShowPassword.UseVisualStyleBackColor = true;
            this.loginShowPassword.CheckedChanged += new System.EventHandler(this.loginShowPassword_CheckedChanged);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(297, 520);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(116, 19);
            this.checkBoxShowPassword.TabIndex = 6;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUserIcon
            // 
            this.flowLayoutPanelUserIcon.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources._552848;
            this.flowLayoutPanelUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelUserIcon.Location = new System.Drawing.Point(26, 150);
            this.flowLayoutPanelUserIcon.Name = "flowLayoutPanelUserIcon";
            this.flowLayoutPanelUserIcon.Size = new System.Drawing.Size(387, 150);
            this.flowLayoutPanelUserIcon.TabIndex = 5;
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(26, 478);
            this.loginPassword.MaxLength = 100;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '•';
            this.loginPassword.Size = new System.Drawing.Size(387, 33);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.loginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginPassword_KeyDown);
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.Location = new System.Drawing.Point(26, 364);
            this.loginUsername.MaxLength = 100;
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(387, 33);
            this.loginUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(23, 447);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 19);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(22, 333);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 19);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(89, 94);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(267, 38);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN ACCOUNT";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
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
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelEMS
            // 
            this.labelEMS.AutoSize = true;
            this.labelEMS.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEMS.Location = new System.Drawing.Point(502, 566);
            this.labelEMS.Name = "labelEMS";
            this.labelEMS.Size = new System.Drawing.Size(407, 29);
            this.labelEMS.TabIndex = 10;
            this.labelEMS.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // flowLayoutPanelEmsImg
            // 
            this.flowLayoutPanelEmsImg.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.kindpng_2394224;
            this.flowLayoutPanelEmsImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelEmsImg.Location = new System.Drawing.Point(471, 94);
            this.flowLayoutPanelEmsImg.Name = "flowLayoutPanelEmsImg";
            this.flowLayoutPanelEmsImg.Size = new System.Drawing.Size(458, 450);
            this.flowLayoutPanelEmsImg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(952, 780);
            this.Controls.Add(this.labelEMS);
            this.Controls.Add(this.flowLayoutPanelEmsImg);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserIcon;
        private System.Windows.Forms.CheckBox loginShowPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmsImg;
        private System.Windows.Forms.Label labelEMS;
    }
}

