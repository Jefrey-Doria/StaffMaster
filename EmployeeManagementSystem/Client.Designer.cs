namespace EmployeeManagementSystem
{
    partial class Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.fieldContact = new System.Windows.Forms.TextBox();
            this.labelContactInfo = new System.Windows.Forms.Label();
            this.fieldLastN = new System.Windows.Forms.TextBox();
            this.fieldClientID = new System.Windows.Forms.TextBox();
            this.fieldFirstN = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.fieldStatus = new System.Windows.Forms.ComboBox();
            this.dataGridClientData = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.fieldStatus);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.fieldEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.fieldContact);
            this.panel1.Controls.Add(this.labelContactInfo);
            this.panel1.Controls.Add(this.fieldLastN);
            this.panel1.Controls.Add(this.fieldClientID);
            this.panel1.Controls.Add(this.fieldFirstN);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.labelEmployeeID);
            this.panel1.Location = new System.Drawing.Point(20, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 271);
            this.panel1.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(391, 83);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(287, 72);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "UPDATE CLIENT";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(688, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(326, 113);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD CLIENT";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(391, 158);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(287, 74);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE CLIENT";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldEmail.Location = new System.Drawing.Point(103, 197);
            this.fieldEmail.MaxLength = 100;
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(257, 35);
            this.fieldEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(52, 199);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 27);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // fieldContact
            // 
            this.fieldContact.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldContact.Location = new System.Drawing.Point(102, 158);
            this.fieldContact.MaxLength = 100;
            this.fieldContact.Name = "fieldContact";
            this.fieldContact.Size = new System.Drawing.Size(258, 35);
            this.fieldContact.TabIndex = 5;
            // 
            // labelContactInfo
            // 
            this.labelContactInfo.AutoSize = true;
            this.labelContactInfo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactInfo.Location = new System.Drawing.Point(14, 158);
            this.labelContactInfo.Name = "labelContactInfo";
            this.labelContactInfo.Size = new System.Drawing.Size(89, 27);
            this.labelContactInfo.TabIndex = 8;
            this.labelContactInfo.Text = "Contact No:";
            // 
            // fieldLastN
            // 
            this.fieldLastN.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldLastN.Location = new System.Drawing.Point(102, 120);
            this.fieldLastN.MaxLength = 100;
            this.fieldLastN.Name = "fieldLastN";
            this.fieldLastN.Size = new System.Drawing.Size(258, 35);
            this.fieldLastN.TabIndex = 3;
            // 
            // fieldClientID
            // 
            this.fieldClientID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldClientID.Location = new System.Drawing.Point(103, 42);
            this.fieldClientID.MaxLength = 100;
            this.fieldClientID.Name = "fieldClientID";
            this.fieldClientID.Size = new System.Drawing.Size(258, 35);
            this.fieldClientID.TabIndex = 1;
            this.fieldClientID.TextChanged += new System.EventHandler(this.fieldClientID_TextChanged);
            // 
            // fieldFirstN
            // 
            this.fieldFirstN.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldFirstN.Location = new System.Drawing.Point(102, 81);
            this.fieldFirstN.MaxLength = 100;
            this.fieldFirstN.Name = "fieldFirstN";
            this.fieldFirstN.Size = new System.Drawing.Size(258, 35);
            this.fieldFirstN.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(20, 120);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 27);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(17, 81);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 27);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(31, 42);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(72, 27);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "Client ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridClientData);
            this.panel2.Controls.Add(this.labelClient);
            this.panel2.Location = new System.Drawing.Point(20, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 381);
            this.panel2.TabIndex = 4;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClient.Location = new System.Drawing.Point(19, 9);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(182, 33);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "CLIENT DATA";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(386, 42);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(58, 27);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Status:";
            // 
            // fieldStatus
            // 
            this.fieldStatus.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldStatus.FormattingEnabled = true;
            this.fieldStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "On Hold"});
            this.fieldStatus.Location = new System.Drawing.Point(450, 42);
            this.fieldStatus.Name = "fieldStatus";
            this.fieldStatus.Size = new System.Drawing.Size(228, 35);
            this.fieldStatus.TabIndex = 9;
            // 
            // dataGridClientData
            // 
            this.dataGridClientData.AllowUserToAddRows = false;
            this.dataGridClientData.AllowUserToDeleteRows = false;
            this.dataGridClientData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.dataGridClientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridClientData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridClientData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridClientData.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridClientData.EnableHeadersVisualStyles = false;
            this.dataGridClientData.Location = new System.Drawing.Point(22, 60);
            this.dataGridClientData.Name = "dataGridClientData";
            this.dataGridClientData.ReadOnly = true;
            this.dataGridClientData.RowHeadersVisible = false;
            this.dataGridClientData.RowTemplate.Height = 40;
            this.dataGridClientData.Size = new System.Drawing.Size(992, 301);
            this.dataGridClientData.TabIndex = 5;
            this.dataGridClientData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientData_CellClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(688, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(326, 74);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(1087, 706);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox fieldContact;
        private System.Windows.Forms.Label labelContactInfo;
        private System.Windows.Forms.TextBox fieldLastN;
        private System.Windows.Forms.TextBox fieldClientID;
        private System.Windows.Forms.TextBox fieldFirstN;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox fieldStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridView dataGridClientData;
        private System.Windows.Forms.Button buttonClear;
    }
}
