namespace EmployeeManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonManageClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelEMS = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.payment1 = new EmployeeManagementSystem.Payment();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.client1 = new EmployeeManagementSystem.Client();
            this.setEmployee1 = new EmployeeManagementSystem.SetEmployee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.labelDashboard);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 56);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDashboard.Location = new System.Drawing.Point(6, 11);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(158, 40);
            this.labelDashboard.TabIndex = 4;
            this.labelDashboard.Text = "DASHBOARD";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Poppins Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1042, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 37);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.panel2.Controls.Add(this.buttonDashboard);
            this.panel2.Controls.Add(this.buttonAddEmployee);
            this.panel2.Controls.Add(this.buttonPayment);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.buttonManageClient);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelEMS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 768);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDashboard.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_home_35;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 196);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(279, 56);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "         Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddEmployee.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_35;
            this.buttonAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEmployee.Location = new System.Drawing.Point(0, 248);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(279, 56);
            this.buttonAddEmployee.TabIndex = 3;
            this.buttonAddEmployee.Text = "         Manage Employee";
            this.buttonAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayment.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPayment.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_payment_35;
            this.buttonPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayment.Location = new System.Drawing.Point(0, 298);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(279, 56);
            this.buttonPayment.TabIndex = 3;
            this.buttonPayment.Text = "         Payment";
            this.buttonPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClient.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClient.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_people_35;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(0, 350);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(279, 56);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "         Clients";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonManageClient
            // 
            this.buttonManageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonManageClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManageClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManageClient.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonManageClient.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_account_35;
            this.buttonManageClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageClient.Location = new System.Drawing.Point(0, 403);
            this.buttonManageClient.Name = "buttonManageClient";
            this.buttonManageClient.Size = new System.Drawing.Size(279, 56);
            this.buttonManageClient.TabIndex = 3;
            this.buttonManageClient.Text = "         Manage Client";
            this.buttonManageClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageClient.UseVisualStyleBackColor = false;
            this.buttonManageClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.Employee_Management_System_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 147);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonLogout);
            this.panel3.Location = new System.Drawing.Point(0, 656);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 62);
            this.panel3.TabIndex = 2;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_35;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(276, 56);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "         Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelEMS
            // 
            this.labelEMS.AutoSize = true;
            this.labelEMS.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEMS.Location = new System.Drawing.Point(21, 741);
            this.labelEMS.Name = "labelEMS";
            this.labelEMS.Size = new System.Drawing.Size(240, 18);
            this.labelEMS.TabIndex = 0;
            this.labelEMS.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dashboard1);
            this.panel4.Controls.Add(this.payment1);
            this.panel4.Controls.Add(this.addEmployee1);
            this.panel4.Controls.Add(this.client1);
            this.panel4.Controls.Add(this.setEmployee1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(279, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 712);
            this.panel4.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1087, 706);
            this.dashboard1.TabIndex = 0;
            // 
            // payment1
            // 
            this.payment1.BackColor = System.Drawing.SystemColors.Control;
            this.payment1.Location = new System.Drawing.Point(0, 0);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1087, 706);
            this.payment1.TabIndex = 1;
            // 
            // addEmployee1
            // 
            this.addEmployee1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1087, 706);
            this.addEmployee1.TabIndex = 2;
            // 
            // client1
            // 
            this.client1.Location = new System.Drawing.Point(0, 0);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(1087, 706);
            this.client1.TabIndex = 3;
            // 
            // setEmployee1
            // 
            this.setEmployee1.Location = new System.Drawing.Point(0, 0);
            this.setEmployee1.Name = "setEmployee1";
            this.setEmployee1.Size = new System.Drawing.Size(1087, 706);
            this.setEmployee1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label labelEMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonManageClient;
        private System.Windows.Forms.Panel panel4;
        private Dashboard dashboard1;
        private Payment payment1;
        private AddEmployee addEmployee1;
        private Client client1;
        private SetEmployee setEmployee1;
    }
}