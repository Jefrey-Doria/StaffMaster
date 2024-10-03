using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class SetEmployee : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public SetEmployee()
        {
            InitializeComponent();
            displayClients();

            disableFields();
        }
        public void displayClients()
        {
            ClientEmployee ce = new ClientEmployee();
            List<ClientEmployee> listdata = ce.clientEmployeesListData();

            dataGridViewClientData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientData.DataSource = listdata;   
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayClients();
            disableFields();
        }
        public void disableFields()
        {
            fieldClientID.Enabled = false;
            fieldFirstN.Enabled = false;
            fieldLastN.Enabled = false;
            fieldStatus.Enabled = false;
        }
        public void clearfields()
        {
            fieldClientID.Text = "";
            fieldFirstN.Text = "";
            fieldLastN.Text = "";
            fieldStatus.Text = "";
            fieldAssignedEmployee.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (fieldClientID.Text == "" || fieldFirstN.Text == "" || fieldLastN.Text == "" || fieldStatus.Text == "" || fieldAssignedEmployee.Text == "")
            {
                MessageBox.Show("Please Fill In All Field By Clicking The Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update The Assigned Employee?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateClientEmployee = "UPDATE clients SET assigned_employee = @assignedEmployee, update_date = @updateDate WHERE client_id = @clientID";

                        using(SqlCommand update = new SqlCommand(updateClientEmployee, connect))
                        {
                            update.Parameters.AddWithValue("@assignedEmployee", fieldAssignedEmployee.Text.Trim());
                            update.Parameters.AddWithValue("@updateDate", today);
                            update.Parameters.AddWithValue("@clientID", fieldClientID.Text.Trim());

                            update.ExecuteNonQuery();
                            displayClients();

                            MessageBox.Show("Client " + fieldClientID.Text.Trim() + " " + fieldFirstN.Text.Trim() + " " + fieldLastN.Text.Trim()
                                    + " Client Has Been Updated", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearfields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Updating Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewClientData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClientData.Rows[e.RowIndex];
                fieldClientID.Text = row.Cells[0].Value.ToString();
                fieldFirstN.Text = row.Cells[1].Value.ToString();
                fieldLastN.Text = row.Cells[2].Value.ToString();
                fieldStatus.Text = row.Cells[3].Value.ToString();
                fieldAssignedEmployee.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
