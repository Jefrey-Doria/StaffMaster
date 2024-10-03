namespace EmployeeManagementSystem
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPendingEmployees = new System.Windows.Forms.Panel();
            this.PendingEmployees = new System.Windows.Forms.Label();
            this.labelPending = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelInactiveEmployees = new System.Windows.Forms.Panel();
            this.InactiveEmployees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelTotalEmployees = new System.Windows.Forms.Panel();
            this.TotalEmployees = new System.Windows.Forms.Label();
            this.labelTotalEmployees = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelActiveEmployees = new System.Windows.Forms.Panel();
            this.ActiveEmployees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridLabel = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelOnHoldClients = new System.Windows.Forms.Panel();
            this.onHoldClients = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panelInactiveClients = new System.Windows.Forms.Panel();
            this.inactiveClients = new System.Windows.Forms.Label();
            this.labelOnHold = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panelTotalClients = new System.Windows.Forms.Panel();
            this.totalClients = new System.Windows.Forms.Label();
            this.labelTotalClients = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panelActiveClients = new System.Windows.Forms.Panel();
            this.activeClients = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPendingEmployees.SuspendLayout();
            this.panelInactiveEmployees.SuspendLayout();
            this.panelTotalEmployees.SuspendLayout();
            this.panelActiveEmployees.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panel11.SuspendLayout();
            this.panelOnHoldClients.SuspendLayout();
            this.panelInactiveClients.SuspendLayout();
            this.panelTotalClients.SuspendLayout();
            this.panelActiveClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panelPendingEmployees);
            this.panel1.Controls.Add(this.panelInactiveEmployees);
            this.panel1.Controls.Add(this.panelTotalEmployees);
            this.panel1.Controls.Add(this.panelActiveEmployees);
            this.panel1.Location = new System.Drawing.Point(20, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 656);
            this.panel1.TabIndex = 0;
            // 
            // panelPendingEmployees
            // 
            this.panelPendingEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelPendingEmployees.Controls.Add(this.PendingEmployees);
            this.panelPendingEmployees.Controls.Add(this.labelPending);
            this.panelPendingEmployees.Controls.Add(this.panel10);
            this.panelPendingEmployees.Location = new System.Drawing.Point(13, 488);
            this.panelPendingEmployees.Name = "panelPendingEmployees";
            this.panelPendingEmployees.Size = new System.Drawing.Size(255, 152);
            this.panelPendingEmployees.TabIndex = 5;
            this.panelPendingEmployees.Click += new System.EventHandler(this.panelPendingEmployees_Click);
            // 
            // PendingEmployees
            // 
            this.PendingEmployees.AutoSize = true;
            this.PendingEmployees.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PendingEmployees.Location = new System.Drawing.Point(95, 38);
            this.PendingEmployees.Name = "PendingEmployees";
            this.PendingEmployees.Size = new System.Drawing.Size(37, 48);
            this.PendingEmployees.TabIndex = 4;
            this.PendingEmployees.Text = "0";
            // 
            // labelPending
            // 
            this.labelPending.AutoSize = true;
            this.labelPending.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPending.Location = new System.Drawing.Point(93, 120);
            this.labelPending.Name = "labelPending";
            this.labelPending.Size = new System.Drawing.Size(159, 18);
            this.labelPending.TabIndex = 3;
            this.labelPending.Text = "PENDING EMPLOYEES";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_waiting_room_60;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel10.Location = new System.Drawing.Point(28, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(61, 77);
            this.panel10.TabIndex = 1;
            // 
            // panelInactiveEmployees
            // 
            this.panelInactiveEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelInactiveEmployees.Controls.Add(this.InactiveEmployees);
            this.panelInactiveEmployees.Controls.Add(this.label2);
            this.panelInactiveEmployees.Controls.Add(this.panel7);
            this.panelInactiveEmployees.Location = new System.Drawing.Point(13, 330);
            this.panelInactiveEmployees.Name = "panelInactiveEmployees";
            this.panelInactiveEmployees.Size = new System.Drawing.Size(255, 152);
            this.panelInactiveEmployees.TabIndex = 1;
            this.panelInactiveEmployees.Click += new System.EventHandler(this.panelInactiveEmployees_Click);
            // 
            // InactiveEmployees
            // 
            this.InactiveEmployees.AutoSize = true;
            this.InactiveEmployees.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InactiveEmployees.Location = new System.Drawing.Point(95, 38);
            this.InactiveEmployees.Name = "InactiveEmployees";
            this.InactiveEmployees.Size = new System.Drawing.Size(37, 48);
            this.InactiveEmployees.TabIndex = 4;
            this.InactiveEmployees.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "INACTIVE EMPLOYEES";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_layoff_60;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(28, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(61, 77);
            this.panel7.TabIndex = 1;
            // 
            // panelTotalEmployees
            // 
            this.panelTotalEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelTotalEmployees.Controls.Add(this.TotalEmployees);
            this.panelTotalEmployees.Controls.Add(this.labelTotalEmployees);
            this.panelTotalEmployees.Controls.Add(this.panel6);
            this.panelTotalEmployees.Location = new System.Drawing.Point(13, 14);
            this.panelTotalEmployees.Name = "panelTotalEmployees";
            this.panelTotalEmployees.Size = new System.Drawing.Size(255, 152);
            this.panelTotalEmployees.TabIndex = 0;
            this.panelTotalEmployees.Click += new System.EventHandler(this.panelTotalEmployees_Click);
            this.panelTotalEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TotalEmployees
            // 
            this.TotalEmployees.AutoSize = true;
            this.TotalEmployees.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalEmployees.Location = new System.Drawing.Point(93, 38);
            this.TotalEmployees.Name = "TotalEmployees";
            this.TotalEmployees.Size = new System.Drawing.Size(37, 48);
            this.TotalEmployees.TabIndex = 2;
            this.TotalEmployees.Text = "0";
            // 
            // labelTotalEmployees
            // 
            this.labelTotalEmployees.AutoSize = true;
            this.labelTotalEmployees.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalEmployees.Location = new System.Drawing.Point(98, 120);
            this.labelTotalEmployees.Name = "labelTotalEmployees";
            this.labelTotalEmployees.Size = new System.Drawing.Size(136, 18);
            this.labelTotalEmployees.TabIndex = 1;
            this.labelTotalEmployees.Text = "TOTAL EMPLOYEES";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_60;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(22, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 77);
            this.panel6.TabIndex = 0;
            // 
            // panelActiveEmployees
            // 
            this.panelActiveEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelActiveEmployees.Controls.Add(this.ActiveEmployees);
            this.panelActiveEmployees.Controls.Add(this.label1);
            this.panelActiveEmployees.Controls.Add(this.panel8);
            this.panelActiveEmployees.Location = new System.Drawing.Point(13, 172);
            this.panelActiveEmployees.Name = "panelActiveEmployees";
            this.panelActiveEmployees.Size = new System.Drawing.Size(255, 152);
            this.panelActiveEmployees.TabIndex = 1;
            this.panelActiveEmployees.Click += new System.EventHandler(this.panelActiveEmployees_Click);
            // 
            // ActiveEmployees
            // 
            this.ActiveEmployees.AutoSize = true;
            this.ActiveEmployees.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActiveEmployees.Location = new System.Drawing.Point(90, 38);
            this.ActiveEmployees.Name = "ActiveEmployees";
            this.ActiveEmployees.Size = new System.Drawing.Size(37, 48);
            this.ActiveEmployees.TabIndex = 3;
            this.ActiveEmployees.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACTIVE EMPLOYEES";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_profile_60;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Location = new System.Drawing.Point(21, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(61, 77);
            this.panel8.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.gridLabel);
            this.panel2.Controls.Add(this.dataGridViewData);
            this.panel2.Location = new System.Drawing.Point(598, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 656);
            this.panel2.TabIndex = 1;
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridLabel.Location = new System.Drawing.Point(6, 14);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(182, 33);
            this.gridLabel.TabIndex = 5;
            this.gridLabel.Text = "CLIENT DATA";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.dataGridViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.EnableHeadersVisualStyles = false;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.RowTemplate.Height = 40;
            this.dataGridViewData.Size = new System.Drawing.Size(435, 588);
            this.dataGridViewData.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel11.Controls.Add(this.panelOnHoldClients);
            this.panel11.Controls.Add(this.panelInactiveClients);
            this.panel11.Controls.Add(this.panelTotalClients);
            this.panel11.Controls.Add(this.panelActiveClients);
            this.panel11.Location = new System.Drawing.Point(309, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(283, 656);
            this.panel11.TabIndex = 2;
            // 
            // panelOnHoldClients
            // 
            this.panelOnHoldClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelOnHoldClients.Controls.Add(this.onHoldClients);
            this.panelOnHoldClients.Controls.Add(this.label4);
            this.panelOnHoldClients.Controls.Add(this.panel13);
            this.panelOnHoldClients.Location = new System.Drawing.Point(13, 488);
            this.panelOnHoldClients.Name = "panelOnHoldClients";
            this.panelOnHoldClients.Size = new System.Drawing.Size(255, 152);
            this.panelOnHoldClients.TabIndex = 5;
            this.panelOnHoldClients.Click += new System.EventHandler(this.panelOnHoldClients_Click);
            // 
            // onHoldClients
            // 
            this.onHoldClients.AutoSize = true;
            this.onHoldClients.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHoldClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onHoldClients.Location = new System.Drawing.Point(95, 38);
            this.onHoldClients.Name = "onHoldClients";
            this.onHoldClients.Size = new System.Drawing.Size(37, 48);
            this.onHoldClients.TabIndex = 4;
            this.onHoldClients.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(93, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ON HOLD CLIENTS";
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_complaint_60;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel13.Location = new System.Drawing.Point(28, 38);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(61, 77);
            this.panel13.TabIndex = 1;
            // 
            // panelInactiveClients
            // 
            this.panelInactiveClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelInactiveClients.Controls.Add(this.inactiveClients);
            this.panelInactiveClients.Controls.Add(this.labelOnHold);
            this.panelInactiveClients.Controls.Add(this.panel15);
            this.panelInactiveClients.Location = new System.Drawing.Point(13, 330);
            this.panelInactiveClients.Name = "panelInactiveClients";
            this.panelInactiveClients.Size = new System.Drawing.Size(255, 152);
            this.panelInactiveClients.TabIndex = 1;
            this.panelInactiveClients.Click += new System.EventHandler(this.panelInactiveClients_Click);
            // 
            // inactiveClients
            // 
            this.inactiveClients.AutoSize = true;
            this.inactiveClients.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inactiveClients.Location = new System.Drawing.Point(95, 38);
            this.inactiveClients.Name = "inactiveClients";
            this.inactiveClients.Size = new System.Drawing.Size(37, 48);
            this.inactiveClients.TabIndex = 4;
            this.inactiveClients.Text = "0";
            // 
            // labelOnHold
            // 
            this.labelOnHold.AutoSize = true;
            this.labelOnHold.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnHold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOnHold.Location = new System.Drawing.Point(93, 120);
            this.labelOnHold.Name = "labelOnHold";
            this.labelOnHold.Size = new System.Drawing.Size(129, 18);
            this.labelOnHold.TabIndex = 3;
            this.labelOnHold.Text = "INACTIVE CLIENTS";
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_exit_60;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel15.Location = new System.Drawing.Point(28, 38);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(61, 77);
            this.panel15.TabIndex = 1;
            // 
            // panelTotalClients
            // 
            this.panelTotalClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelTotalClients.Controls.Add(this.totalClients);
            this.panelTotalClients.Controls.Add(this.labelTotalClients);
            this.panelTotalClients.Controls.Add(this.panel17);
            this.panelTotalClients.Location = new System.Drawing.Point(13, 14);
            this.panelTotalClients.Name = "panelTotalClients";
            this.panelTotalClients.Size = new System.Drawing.Size(255, 152);
            this.panelTotalClients.TabIndex = 0;
            this.panelTotalClients.Click += new System.EventHandler(this.panelTotalClients_Click);
            this.panelTotalClients.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // totalClients
            // 
            this.totalClients.AutoSize = true;
            this.totalClients.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalClients.Location = new System.Drawing.Point(93, 38);
            this.totalClients.Name = "totalClients";
            this.totalClients.Size = new System.Drawing.Size(37, 48);
            this.totalClients.TabIndex = 2;
            this.totalClients.Text = "0";
            this.totalClients.Click += new System.EventHandler(this.totalClients_Click);
            // 
            // labelTotalClients
            // 
            this.labelTotalClients.AutoSize = true;
            this.labelTotalClients.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalClients.Location = new System.Drawing.Point(98, 120);
            this.labelTotalClients.Name = "labelTotalClients";
            this.labelTotalClients.Size = new System.Drawing.Size(109, 18);
            this.labelTotalClients.TabIndex = 1;
            this.labelTotalClients.Text = "TOTAL CLIENTS";
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_client_60;
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel17.Location = new System.Drawing.Point(22, 38);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(61, 77);
            this.panel17.TabIndex = 0;
            // 
            // panelActiveClients
            // 
            this.panelActiveClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.panelActiveClients.Controls.Add(this.activeClients);
            this.panelActiveClients.Controls.Add(this.label10);
            this.panelActiveClients.Controls.Add(this.panel19);
            this.panelActiveClients.Location = new System.Drawing.Point(13, 172);
            this.panelActiveClients.Name = "panelActiveClients";
            this.panelActiveClients.Size = new System.Drawing.Size(255, 152);
            this.panelActiveClients.TabIndex = 1;
            this.panelActiveClients.Click += new System.EventHandler(this.panelActiveClients_Click);
            // 
            // activeClients
            // 
            this.activeClients.AutoSize = true;
            this.activeClients.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeClients.Location = new System.Drawing.Point(90, 38);
            this.activeClients.Name = "activeClients";
            this.activeClients.Size = new System.Drawing.Size(37, 48);
            this.activeClients.TabIndex = 3;
            this.activeClients.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(95, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "ACTIVE CLIENTS";
            // 
            // panel19
            // 
            this.panel19.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.icons8_hard_working_60;
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel19.Location = new System.Drawing.Point(21, 38);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(61, 77);
            this.panel19.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1087, 706);
            this.panel1.ResumeLayout(false);
            this.panelPendingEmployees.ResumeLayout(false);
            this.panelPendingEmployees.PerformLayout();
            this.panelInactiveEmployees.ResumeLayout(false);
            this.panelInactiveEmployees.PerformLayout();
            this.panelTotalEmployees.ResumeLayout(false);
            this.panelTotalEmployees.PerformLayout();
            this.panelActiveEmployees.ResumeLayout(false);
            this.panelActiveEmployees.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panelOnHoldClients.ResumeLayout(false);
            this.panelOnHoldClients.PerformLayout();
            this.panelInactiveClients.ResumeLayout(false);
            this.panelInactiveClients.PerformLayout();
            this.panelTotalClients.ResumeLayout(false);
            this.panelTotalClients.PerformLayout();
            this.panelActiveClients.ResumeLayout(false);
            this.panelActiveClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInactiveEmployees;
        private System.Windows.Forms.Panel panelActiveEmployees;
        private System.Windows.Forms.Panel panelTotalEmployees;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalEmployees;
        private System.Windows.Forms.Label InactiveEmployees;
        private System.Windows.Forms.Label ActiveEmployees;
        private System.Windows.Forms.Label TotalEmployees;
        private System.Windows.Forms.Panel panelPendingEmployees;
        private System.Windows.Forms.Label PendingEmployees;
        private System.Windows.Forms.Label labelPending;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panelOnHoldClients;
        private System.Windows.Forms.Label onHoldClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panelInactiveClients;
        private System.Windows.Forms.Label inactiveClients;
        private System.Windows.Forms.Label labelOnHold;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panelTotalClients;
        private System.Windows.Forms.Label totalClients;
        private System.Windows.Forms.Label labelTotalClients;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panelActiveClients;
        private System.Windows.Forms.Label activeClients;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label gridLabel;
    }
}
