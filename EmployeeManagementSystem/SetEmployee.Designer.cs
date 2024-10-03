namespace EmployeeManagementSystem
{
    partial class SetEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fieldAssignedEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.fieldStatus = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.fieldLastN = new System.Windows.Forms.TextBox();
            this.fieldFirstN = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.fieldClientID = new System.Windows.Forms.TextBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClientData = new System.Windows.Forms.DataGridView();
            this.labelTotalEmployees = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.fieldAssignedEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.fieldStatus);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.fieldLastN);
            this.panel1.Controls.Add(this.fieldFirstN);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.fieldClientID);
            this.panel1.Controls.Add(this.labelEmployeeID);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 676);
            this.panel1.TabIndex = 2;
            // 
            // fieldAssignedEmployee
            // 
            this.fieldAssignedEmployee.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldAssignedEmployee.Location = new System.Drawing.Point(19, 385);
            this.fieldAssignedEmployee.MaxLength = 100;
            this.fieldAssignedEmployee.Name = "fieldAssignedEmployee";
            this.fieldAssignedEmployee.Size = new System.Drawing.Size(288, 29);
            this.fieldAssignedEmployee.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Assigned Employee:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(19, 524);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(288, 67);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(19, 597);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(288, 67);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // fieldStatus
            // 
            this.fieldStatus.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldStatus.Location = new System.Drawing.Point(19, 311);
            this.fieldStatus.MaxLength = 100;
            this.fieldStatus.Name = "fieldStatus";
            this.fieldStatus.Size = new System.Drawing.Size(288, 29);
            this.fieldStatus.TabIndex = 4;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(14, 281);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(58, 27);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "Status:";
            // 
            // fieldLastN
            // 
            this.fieldLastN.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldLastN.Location = new System.Drawing.Point(19, 236);
            this.fieldLastN.MaxLength = 100;
            this.fieldLastN.Name = "fieldLastN";
            this.fieldLastN.Size = new System.Drawing.Size(288, 29);
            this.fieldLastN.TabIndex = 3;
            // 
            // fieldFirstN
            // 
            this.fieldFirstN.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldFirstN.Location = new System.Drawing.Point(19, 159);
            this.fieldFirstN.MaxLength = 100;
            this.fieldFirstN.Name = "fieldFirstN";
            this.fieldFirstN.Size = new System.Drawing.Size(288, 29);
            this.fieldFirstN.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(14, 206);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 27);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(14, 129);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 27);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "First Name:";
            // 
            // fieldClientID
            // 
            this.fieldClientID.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldClientID.Location = new System.Drawing.Point(19, 89);
            this.fieldClientID.MaxLength = 100;
            this.fieldClientID.Name = "fieldClientID";
            this.fieldClientID.Size = new System.Drawing.Size(288, 29);
            this.fieldClientID.TabIndex = 1;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(14, 59);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(72, 27);
            this.labelEmployeeID.TabIndex = 5;
            this.labelEmployeeID.Text = "Client ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridViewClientData);
            this.panel2.Controls.Add(this.labelTotalEmployees);
            this.panel2.Location = new System.Drawing.Point(340, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 676);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewClientData
            // 
            this.dataGridViewClientData.AllowUserToAddRows = false;
            this.dataGridViewClientData.AllowUserToDeleteRows = false;
            this.dataGridViewClientData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.dataGridViewClientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClientData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewClientData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientData.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientData.EnableHeadersVisualStyles = false;
            this.dataGridViewClientData.Location = new System.Drawing.Point(20, 59);
            this.dataGridViewClientData.Name = "dataGridViewClientData";
            this.dataGridViewClientData.ReadOnly = true;
            this.dataGridViewClientData.RowHeadersVisible = false;
            this.dataGridViewClientData.RowTemplate.Height = 40;
            this.dataGridViewClientData.Size = new System.Drawing.Size(695, 605);
            this.dataGridViewClientData.TabIndex = 4;
            this.dataGridViewClientData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientData_CellClick);
            // 
            // labelTotalEmployees
            // 
            this.labelTotalEmployees.AutoSize = true;
            this.labelTotalEmployees.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotalEmployees.Location = new System.Drawing.Point(14, 12);
            this.labelTotalEmployees.Name = "labelTotalEmployees";
            this.labelTotalEmployees.Size = new System.Drawing.Size(121, 33);
            this.labelTotalEmployees.TabIndex = 3;
            this.labelTotalEmployees.Text = "CLIENTS";
            // 
            // SetEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SetEmployee";
            this.Size = new System.Drawing.Size(1087, 706);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fieldAssignedEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox fieldStatus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox fieldLastN;
        private System.Windows.Forms.TextBox fieldFirstN;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox fieldClientID;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewClientData;
        private System.Windows.Forms.Label labelTotalEmployees;
    }
}
