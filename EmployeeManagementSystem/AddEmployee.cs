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
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData(); 
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            
            dataGridViewEmployeeData.DataSource = listData;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(fieldEmployeeID.Text == "" || fieldFirstN.Text == "" || fieldLastN.Text == "" 
                || fieldAddress.Text == "" || fieldContact.Text == "" || fieldEmail.Text == "" 
                || fieldPosition.Text == "" || fieldStatus.Text == "" || fieldGender.Text == ""
                || fieldProfile.Image == null)
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(fieldStatus.Text == "Active" || fieldStatus.Text == "Inactive" || fieldStatus.Text == "Pending")
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmployeeID = "SELECT COUNT(*) FROM employees WHERE employee_id = @employeeID AND delete_date IS NULL";

                        using (SqlCommand checkEmployee = new SqlCommand(checkEmployeeID, connect))
                        {
                            checkEmployee.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                            int count = (int)checkEmployee.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show(fieldEmployeeID.Text.Trim() + " is already taken",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string insertData = "INSERT INTO employees " + "(employee_id, first_name," +
                                    "last_name, current_address, contact_info, email, gender, position, image," +
                                    "salary, insert_date, status)" + "VALUES(@employeeID, @firstName, @lastName, @address, @contactInfo," +
                                    "@email, @gender, @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Images\"
                                                            + fieldEmployeeID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(fieldProfile.ImageLocation, path, true);

                                DateTime today = DateTime.Today;

                                using(SqlCommand insert = new SqlCommand(insertData, connect))
                                {
                                    insert.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                                    insert.Parameters.AddWithValue("@firstName", fieldFirstN.Text.Trim());
                                    insert.Parameters.AddWithValue("@lastName", fieldLastN.Text.Trim());
                                    insert.Parameters.AddWithValue("@address", fieldAddress.Text.Trim());
                                    insert.Parameters.AddWithValue("@contactInfo", fieldContact.Text.Trim());
                                    insert.Parameters.AddWithValue("@email", fieldEmail.Text.Trim());
                                    insert.Parameters.AddWithValue("@gender", fieldGender.Text.Trim());
                                    insert.Parameters.AddWithValue("@position", fieldPosition.Text.Trim());
                                    insert.Parameters.AddWithValue("@status", fieldStatus.Text.Trim());

                                    insert.Parameters.AddWithValue("@salary", 0);
                                    insert.Parameters.AddWithValue("@image", path);
                                    insert.Parameters.AddWithValue("@insertDate", today);

                                    insert.ExecuteNonQuery();

                                    displayEmployeeData();
                                    MessageBox.Show("Employee Details Added Successfully", 
                                        "Employee Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("There was an Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Status Field " + fieldStatus.Text + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonImportPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    fieldProfile.ImageLocation = imagePath;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There was an Error: " + ex, "ERROR 69420", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error" + ex);
            }


        }

        private void dataGridViewEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewEmployeeData.Rows[e.RowIndex];

                fieldEmployeeID.Text = row.Cells[0].Value.ToString();
                fieldFirstN.Text = row.Cells[1].Value.ToString();
                fieldLastN.Text = row.Cells[2].Value.ToString();
                fieldAddress.Text = row.Cells[3].Value.ToString();
                fieldContact.Text = row.Cells[4].Value.ToString();
                fieldEmail.Text = row.Cells[5].Value.ToString();
                fieldGender.Text = row.Cells[6].Value.ToString();
                fieldPosition.Text = row.Cells[7].Value.ToString();

                string imagePath = row.Cells[8].Value.ToString();
                if(imagePath != null)
                {
                    fieldProfile.Image = Image.FromFile(imagePath);
                }
                else
                {
                    fieldProfile.Image = null;
                }
                fieldStatus.Text = row.Cells[9].Value.ToString();
            }
        }

        public void clearFields()
        {
            fieldEmployeeID.Text = "";
            fieldFirstN.Text = "";
            fieldLastN.Text = "";
            fieldAddress.Text = "";
            fieldContact.Text ="";
            fieldEmail.Text = "";
            fieldPosition.Text = "";
            fieldStatus.SelectedIndex = -1;
            fieldGender.SelectedIndex = -1;
            fieldProfile.Image = null;
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayEmployeeData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (fieldEmployeeID.Text == "" || fieldFirstN.Text == "" || fieldLastN.Text == ""
                || fieldAddress.Text == "" || fieldContact.Text == "" || fieldEmail.Text == ""
                || fieldPosition.Text == "" || fieldStatus.Text == "" || fieldGender.Text == ""
                || fieldProfile.Image == null)
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(fieldStatus.Text == "Active" || fieldStatus.Text == "Inactive" || fieldStatus.Text == "Pending")
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update Details of " + fieldEmployeeID.Text.Trim() + "?",
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE employees SET first_name = @firstName, last_name = @lastName, current_address = @address" +
                            ",contact_info = @contact, email = @email, gender = @gender, " +
                            "position = @position, image = @image, status = @status, update_date = @updateDate " +
                            "WHERE employee_id = @employeeID";

                        //no image update
                        string updateDataNoImage = "UPDATE employees SET first_name = @firstName, last_name = @lastName, current_address = @address" +
                            ",contact_info = @contact, email = @email, gender = @gender, " +
                            "position = @position, status = @status, update_date = @updateDate " +
                            "WHERE employee_id = @employeeID";

                        DateTime today = DateTime.Today;

                        string path = Path.Combine(@"C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Images\"
                                                            + fieldEmployeeID.Text.Trim() + " update " + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        //with image update
                        if (fieldProfile.ImageLocation != null)
                        {
                            File.Copy(fieldProfile.ImageLocation, path, true);

                            using (SqlCommand update = new SqlCommand(updateData, connect))
                            {
                                update.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                                update.Parameters.AddWithValue("@firstName", fieldFirstN.Text.Trim());
                                update.Parameters.AddWithValue("@lastName", fieldLastN.Text.Trim());
                                update.Parameters.AddWithValue("@address", fieldAddress.Text.Trim());
                                update.Parameters.AddWithValue("@contact", fieldContact.Text.Trim());
                                update.Parameters.AddWithValue("@email", fieldEmail.Text.Trim());
                                update.Parameters.AddWithValue("@gender", fieldGender.Text.Trim());
                                update.Parameters.AddWithValue("@position", fieldPosition.Text.Trim());
                                update.Parameters.AddWithValue("@image", path);
                                update.Parameters.AddWithValue("@status", fieldStatus.Text.Trim());
                                update.Parameters.AddWithValue("@updateDate", today);
                                update.ExecuteNonQuery();

                                displayEmployeeData();
                                MessageBox.Show("Employee Details Added Successfully",
                                    "Employee Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        //no image update
                        else
                        {
                            using (SqlCommand update = new SqlCommand(updateDataNoImage, connect))
                            {
                                update.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                                update.Parameters.AddWithValue("@firstName", fieldFirstN.Text.Trim());
                                update.Parameters.AddWithValue("@lastName", fieldLastN.Text.Trim());
                                update.Parameters.AddWithValue("@address", fieldAddress.Text.Trim());
                                update.Parameters.AddWithValue("@contact", fieldContact.Text.Trim());
                                update.Parameters.AddWithValue("@email", fieldEmail.Text.Trim());
                                update.Parameters.AddWithValue("@gender", fieldGender.Text.Trim());
                                update.Parameters.AddWithValue("@position", fieldPosition.Text.Trim());
                                update.Parameters.AddWithValue("@status", fieldStatus.Text.Trim());
                                update.Parameters.AddWithValue("@updateDate", today);

                                update.ExecuteNonQuery();

                                displayEmployeeData();
                                MessageBox.Show("Employee Details Added Successfully",
                                    "Employee Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Invalid Status Field " + fieldStatus.Text + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (fieldEmployeeID.Text == "" || fieldFirstN.Text == "" || fieldLastN.Text == ""
                || fieldAddress.Text == "" || fieldContact.Text == "" || fieldEmail.Text == ""
                || fieldPosition.Text == "" || fieldStatus.Text == "" || fieldGender.Text == ""
                || fieldProfile.Image == null)
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Delete Details of " + fieldEmployeeID.Text.Trim() + "?",
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        DateTime today = DateTime.Today;

                        using (SqlCommand delete = new SqlCommand(deleteData, connect))
                        {
                            delete.Parameters.AddWithValue("@employeeID", fieldEmployeeID.Text.Trim());
                            delete.Parameters.AddWithValue("@deleteDate", today);

                            delete.ExecuteNonQuery();

                            displayEmployeeData();
                            MessageBox.Show("Employee Details Deleted Successfully",
                                "Employee Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Delete Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}

