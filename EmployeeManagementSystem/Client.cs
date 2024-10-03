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
using System.Security.Cryptography;

namespace EmployeeManagementSystem
{
    public partial class Client : UserControl
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");



        public Client()
        {
            InitializeComponent();
        }

        private void fieldClientID_TextChanged(object sender, EventArgs e)
        {

        }
        public void displayClientData()
        {
            ClientData cd = new ClientData();
            List<ClientData> clientData = cd.clientListData();
            dataGridClientData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientData.DataSource = clientData;
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayClientData();
        }
        public void clearFields()
        {
            fieldClientID.Text = "";
            fieldFirstN.Text = "";
            fieldLastN.Text = "";
            fieldContact.Text = "";
            fieldEmail.Text = "";
            fieldStatus.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(fieldClientID.Text == "" || fieldContact.Text == "" || fieldEmail.Text == "" || fieldFirstN.Text == "" ||
                fieldLastN.Text == "" || fieldStatus.Text == "")
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(fieldStatus.Text.Trim() == "Active" || fieldStatus.Text.Trim() == "Inactive" || fieldStatus.Text.Trim() == "On Hold")
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkClientID = "select COUNT(*) FROM clients WHERE client_id = @clientID AND delete_date IS NULL";

                        using(SqlCommand checkClient = new SqlCommand(checkClientID, connect))
                        {
                            checkClient.Parameters.AddWithValue("@clientID", fieldClientID.Text.Trim());
                            int count = (int)checkClient.ExecuteScalar();
                            if(count > 0)
                            {
                                MessageBox.Show(fieldClientID.Text.Trim() + " is already taken",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string insertData = "INSERT INTO clients" + "(client_id, first_name, last_name, contact_info, email, status, insert_date)" +
                                                                    "VALUES(@clientID, @firstName, @lastName, @contactInfo, @email, @status, @insertDate)";

                                DateTime today = DateTime.Today;

                                using(SqlCommand insert = new SqlCommand(insertData, connect))
                                {
                                    insert.Parameters.AddWithValue("@clientID", fieldClientID.Text.Trim());
                                    insert.Parameters.AddWithValue("@firstName", fieldFirstN.Text.Trim());
                                    insert.Parameters.AddWithValue("@lastName", fieldLastN.Text.Trim());
                                    insert.Parameters.AddWithValue("@contactInfo", fieldContact.Text.Trim());
                                    insert.Parameters.AddWithValue("@email", fieldEmail.Text.Trim());
                                    insert.Parameters.AddWithValue("@status", fieldStatus.Text.Trim());
                                    insert.Parameters.AddWithValue("@insertDate", today);

                                    insert.ExecuteNonQuery();

                                    displayClientData();

                                    MessageBox.Show("Client Details Added Successfully",
                                        "Client Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
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
            }
            else
            {
                MessageBox.Show("Invalid Status Field " + fieldStatus.Text + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridClientData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridClientData.Rows[e.RowIndex];

                fieldClientID.Text = row.Cells[0].Value.ToString();
                fieldFirstN.Text = row.Cells[1].Value.ToString();
                fieldLastN.Text = row.Cells[2].Value.ToString();
                fieldContact.Text = row.Cells[3].Value.ToString();
                fieldEmail.Text = row.Cells[4].Value.ToString();
                fieldStatus.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (fieldClientID.Text == "" || fieldContact.Text == "" || fieldEmail.Text == "" || fieldFirstN.Text == "" ||
                fieldLastN.Text == "" || fieldStatus.Text == "")
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(fieldStatus.Text.Trim() == "Active" || fieldStatus.Text.Trim() == "Inactive" || fieldStatus.Text.Trim() == "On Hold")
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update Details of " + fieldClientID.Text.Trim() + "?",
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE clients SET first_name = @firstName, last_name = @lastName, contact_info = @contact, email = @email, status = @status, update_date = @updateDate" +
                            " WHERE client_id = @clientID";

                        DateTime today = DateTime.Today;

                        using(SqlCommand update = new SqlCommand(updateData, connect))
                        {
                            update.Parameters.AddWithValue("@clientID", fieldClientID.Text.Trim());
                            update.Parameters.AddWithValue("@firstName", fieldFirstN.Text.Trim());
                            update.Parameters.AddWithValue("@lastName", fieldLastN.Text.Trim());
                            update.Parameters.AddWithValue("@contact", fieldContact.Text.Trim());
                            update.Parameters.AddWithValue("@email", fieldEmail.Text.Trim());
                            update.Parameters.AddWithValue("@status", fieldStatus.Text.Trim());
                            update.Parameters.AddWithValue("@updateDate", today);

                            update.ExecuteNonQuery();

                            displayClientData();
                            MessageBox.Show("Client Details Updated Successfully",
                                    "Client Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (fieldClientID.Text == "" || fieldContact.Text == "" || fieldEmail.Text == "" || fieldFirstN.Text == "" ||
                fieldLastN.Text == "" || fieldStatus.Text == "")
            {
                MessageBox.Show("Please Fill in all Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Delete Details of " + fieldClientID.Text.Trim() + "?",
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "UPDATE clients SET delete_date = @deleteDate WHERE client_id = @clientID";

                        DateTime today = DateTime.Now;

                        using(SqlCommand delete = new SqlCommand(deleteData, connect))
                        {
                            delete.Parameters.AddWithValue("@clientID", fieldClientID.Text.Trim());
                            delete.Parameters.AddWithValue("@deleteDate", today);

                            delete.ExecuteNonQuery();

                            displayClientData();
                            MessageBox.Show("Client Details Deleted Successfully",
                                "Client Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();

                        }
                    }
                    catch (Exception ex )
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
