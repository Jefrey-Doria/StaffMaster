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
    public partial class Payment : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Payment()
        {
            InitializeComponent();

            displayEmployees();
            disableFields();
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listdata = ed.salaryEmployeeListData();

            dataGridViewEmployeeData.DataSource = listdata;
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayEmployees();
            disableFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (fieldEmployeeID.Text == "" || fieldFirstN.Text == "" || fieldLastN.Text == "" || fieldPosition.Text == "" ||
                fieldSalary.Text == "")
            {
                MessageBox.Show("Please Fill In All Field By Clicking The Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update Salary " + fieldSalary.Text.Trim() + "?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(check == DialogResult.Yes)
                {
                    if(connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateSalary = "UPDATE employees SET salary = @salary, update_date = @updateDate " +
                                "WHERE employee_id = @employeeID";

                            using(SqlCommand update = new SqlCommand(updateSalary, connect)) 
                            {
                                update.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                                update.Parameters.AddWithValue("@salary", fieldSalary.Text.Trim());
                                update.Parameters.AddWithValue("@updateDate", today);

                                update.ExecuteNonQuery();
                                displayEmployees();

                                MessageBox.Show("Employee " + fieldEmployeeID.Text.Trim() + " " + fieldFirstN.Text.Trim() + " " + fieldLastN.Text.Trim()
                                    + " Salary Has Been Updated", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
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
                }
                else
                {
                    MessageBox.Show("Updating Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void clearFields()
        {
            fieldEmployeeID.Text = "";
            fieldFirstN.Text = "";
            fieldLastN.Text = "";
            fieldPosition.Text = "";
            fieldSalary.Text = "";
        }

        public void disableFields()
        {
            fieldFirstN.Enabled = false;
            fieldLastN.Enabled = false;
            fieldEmployeeID.Enabled = false;
            fieldPosition.Enabled = false;
        }

        private void dataGridViewEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewEmployeeData.Rows[e.RowIndex];
                fieldEmployeeID.Text = row.Cells[0].Value.ToString();
                fieldFirstN.Text = row.Cells[1].Value.ToString();
                fieldLastN.Text = row.Cells[2].Value.ToString();
                fieldPosition.Text = row.Cells[3].Value.ToString();
                fieldSalary.Text = row.Cells[6].Value.ToString();


            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
