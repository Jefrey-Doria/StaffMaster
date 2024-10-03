namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewEmployeeData = new System.Windows.Forms.DataGridView();
            this.labelTotalEmployees = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.fieldStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.fieldPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.fieldAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonImportPhoto = new System.Windows.Forms.Button();
            this.fieldProfile = new System.Windows.Forms.PictureBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.fieldContact = new System.Windows.Forms.TextBox();
            this.labelContactInfo = new System.Windows.Forms.Label();
            this.fieldGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.fieldLastN = new System.Windows.Forms.TextBox();
            this.fieldEmployeeID = new System.Windows.Forms.TextBox();
            this.fieldFirstN = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridViewEmployeeData);
            this.panel2.Controls.Add(this.labelTotalEmployees);
            this.panel2.Location = new System.Drawing.Point(20, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 381);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewEmployeeData
            // 
            this.dataGridViewEmployeeData.AllowUserToAddRows = false;
            this.dataGridViewEmployeeData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewEmployeeData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewEmployeeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.dataGridViewEmployeeData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmployeeData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployeeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeData.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployeeData.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewEmployeeData.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployeeData.Location = new System.Drawing.Point(25, 56);
            this.dataGridViewEmployeeData.Name = "dataGridViewEmployeeData";
            this.dataGridViewEmployeeData.ReadOnly = true;
            this.dataGridViewEmployeeData.RowHeadersVisible = false;
            this.dataGridViewEmployeeData.RowTemplate.Height = 40;
            this.dataGridViewEmployeeData.Size = new System.Drawing.Size(989, 306);
            this.dataGridViewEmployeeData.TabIndex = 3;
            this.dataGridViewEmployeeData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeData_CellClick);
            // 
            // labelTotalEmployees
            // 
            this.labelTotalEmployees.AutoSize = true;
            this.labelTotalEmployees.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotalEmployees.Location = new System.Drawing.Point(19, 9);
            this.labelTotalEmployees.Name = "labelTotalEmployees";
            this.labelTotalEmployees.Size = new System.Drawing.Size(230, 33);
            this.labelTotalEmployees.TabIndex = 2;
            this.labelTotalEmployees.Text = "EMPLOYEE DATA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.fieldStatus);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.fieldPosition);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.fieldAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonImportPhoto);
            this.panel1.Controls.Add(this.fieldProfile);
            this.panel1.Controls.Add(this.fieldEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.fieldContact);
            this.panel1.Controls.Add(this.labelContactInfo);
            this.panel1.Controls.Add(this.fieldGender);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.fieldLastN);
            this.panel1.Controls.Add(this.fieldEmployeeID);
            this.panel1.Controls.Add(this.fieldFirstN);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.labelEmployeeID);
            this.panel1.Location = new System.Drawing.Point(20, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 271);
            this.panel1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(866, 97);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(170, 75);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "UPDATE EMPLOYEE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // fieldStatus
            // 
            this.fieldStatus.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldStatus.FormattingEnabled = true;
            this.fieldStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Pending"});
            this.fieldStatus.Location = new System.Drawing.Point(461, 97);
            this.fieldStatus.Name = "fieldStatus";
            this.fieldStatus.Size = new System.Drawing.Size(217, 35);
            this.fieldStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(397, 97);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(58, 27);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Status:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(391, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(287, 108);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD EMPLOYEE";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // fieldPosition
            // 
            this.fieldPosition.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldPosition.Location = new System.Drawing.Point(461, 56);
            this.fieldPosition.MaxLength = 100;
            this.fieldPosition.Name = "fieldPosition";
            this.fieldPosition.Size = new System.Drawing.Size(217, 35);
            this.fieldPosition.TabIndex = 8;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(386, 61);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 27);
            this.labelPosition.TabIndex = 17;
            this.labelPosition.Text = "Position:";
            // 
            // fieldAddress
            // 
            this.fieldAddress.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldAddress.Location = new System.Drawing.Point(111, 137);
            this.fieldAddress.MaxLength = 100;
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(258, 35);
            this.fieldAddress.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(44, 137);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 27);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Address:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(866, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 75);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE EMPLOYEE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonImportPhoto
            // 
            this.buttonImportPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonImportPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportPhoto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonImportPhoto.Location = new System.Drawing.Point(684, 206);
            this.buttonImportPhoto.Name = "buttonImportPhoto";
            this.buttonImportPhoto.Size = new System.Drawing.Size(178, 40);
            this.buttonImportPhoto.TabIndex = 10;
            this.buttonImportPhoto.Text = "IMPORT";
            this.buttonImportPhoto.UseVisualStyleBackColor = false;
            this.buttonImportPhoto.Click += new System.EventHandler(this.buttonImportPhoto_Click);
            // 
            // fieldProfile
            // 
            this.fieldProfile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fieldProfile.Location = new System.Drawing.Point(684, 19);
            this.fieldProfile.Name = "fieldProfile";
            this.fieldProfile.Size = new System.Drawing.Size(178, 187);
            this.fieldProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fieldProfile.TabIndex = 12;
            this.fieldProfile.TabStop = false;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldEmail.Location = new System.Drawing.Point(112, 213);
            this.fieldEmail.MaxLength = 100;
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(257, 35);
            this.fieldEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(61, 215);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 27);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // fieldContact
            // 
            this.fieldContact.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldContact.Location = new System.Drawing.Point(111, 174);
            this.fieldContact.MaxLength = 100;
            this.fieldContact.Name = "fieldContact";
            this.fieldContact.Size = new System.Drawing.Size(258, 35);
            this.fieldContact.TabIndex = 5;
            // 
            // labelContactInfo
            // 
            this.labelContactInfo.AutoSize = true;
            this.labelContactInfo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactInfo.Location = new System.Drawing.Point(23, 174);
            this.labelContactInfo.Name = "labelContactInfo";
            this.labelContactInfo.Size = new System.Drawing.Size(89, 27);
            this.labelContactInfo.TabIndex = 8;
            this.labelContactInfo.Text = "Contact No:";
            // 
            // fieldGender
            // 
            this.fieldGender.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldGender.FormattingEnabled = true;
            this.fieldGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.fieldGender.Location = new System.Drawing.Point(461, 19);
            this.fieldGender.Name = "fieldGender";
            this.fieldGender.Size = new System.Drawing.Size(217, 35);
            this.fieldGender.TabIndex = 7;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(394, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(38, 27);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Sex:";
            // 
            // fieldLastN
            // 
            this.fieldLastN.Font = new System.Drawing.Font("Dubai", 12F);
            this.fieldLastN.Location = new System.Drawing.Point(111, 98);
            this.fieldLastN.MaxLength = 100;
            this.fieldLastN.Name = "fieldLastN";
            this.fieldLastN.Size = new System.Drawing.Size(258, 35);
            this.fieldLastN.TabIndex = 3;
            // 
            // fieldEmployeeID
            // 
            this.fieldEmployeeID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldEmployeeID.Location = new System.Drawing.Point(112, 20);
            this.fieldEmployeeID.MaxLength = 100;
            this.fieldEmployeeID.Name = "fieldEmployeeID";
            this.fieldEmployeeID.Size = new System.Drawing.Size(258, 35);
            this.fieldEmployeeID.TabIndex = 1;
            // 
            // fieldFirstN
            // 
            this.fieldFirstN.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldFirstN.Location = new System.Drawing.Point(111, 59);
            this.fieldFirstN.MaxLength = 100;
            this.fieldFirstN.Name = "fieldFirstN";
            this.fieldFirstN.Size = new System.Drawing.Size(258, 35);
            this.fieldFirstN.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(29, 98);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 27);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(26, 59);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 27);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(17, 21);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(96, 27);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "Employee ID:";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(866, 174);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(170, 72);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1087, 706);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeData;
        private System.Windows.Forms.Label labelTotalEmployees;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox fieldLastN;
        private System.Windows.Forms.TextBox fieldEmployeeID;
        private System.Windows.Forms.TextBox fieldFirstN;
        private System.Windows.Forms.TextBox fieldContact;
        private System.Windows.Forms.Label labelContactInfo;
        private System.Windows.Forms.ComboBox fieldGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonImportPhoto;
        private System.Windows.Forms.PictureBox fieldProfile;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox fieldAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox fieldPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox fieldStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
    }
}
