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
    public partial class Dashboard : UserControl
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public Dashboard()
        {
            InitializeComponent();


            displayTotalEmployees();
            displayActiveEmployees();
            displayInactiveEmployees();
            displayPendingEmployees();
            displayTotalClients();
            displayActiveClients();
            displayInactiveClients();
            displayOnHoldClients();
            displayTotalEmployeeData();
        }

        

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalEmployees();
            displayActiveEmployees();
            displayInactiveEmployees();
            displayPendingEmployees();
            displayTotalClients();
            displayActiveClients();
            displayInactiveClients();
            displayOnHoldClients();
            displayTotalEmployeeData();
        }
        public void displayTotalEmployees()
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            TotalEmployees.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }    
            }
        }
        public void displayActiveEmployees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            ActiveEmployees.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayInactiveEmployees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            InactiveEmployees.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayPendingEmployees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            PendingEmployees.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayTotalClients()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM clients WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            totalClients.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayActiveClients()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM clients WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            activeClients.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayInactiveClients()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM clients WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            inactiveClients.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayOnHoldClients()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM clients WHERE delete_date IS NULL AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "On Hold");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            onHoldClients.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error" + ex, "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
        public void displayTotalEmployeeData()
        {
            EmployeeTotal ed = new EmployeeTotal();
            List<EmployeeTotal> listData = ed.employeeTotalListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = listData;
        }
        public void displayActiveEmployeeData()
        {
            EmployeeActive ed = new EmployeeActive();
            List<EmployeeActive> listData = ed.employeeActiveListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = listData;
        }
        public void displayInactiveEmployeeData()
        {
            EmployeeInactive ed = new EmployeeInactive();
            List<EmployeeInactive> listData = ed.employeeInactiveListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = listData;
        }
        public void displayPendingEmployeeData()
        {
            EmployeePending ed = new EmployeePending();
            List<EmployeePending> listData = ed.employeePendingListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = listData;
        }

        public void displayTotalClientData()
        {
            ClientTotal cd = new ClientTotal();
            List<ClientTotal> clientData = cd.clientTotalListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = clientData;
        }
        public void displayActiveClientData()
        {
            ClientActive cd = new ClientActive();
            List<ClientActive> clientData = cd.clientActiveListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = clientData;
        }
        public void displayInactiveClientData()
        {
            ClientInactive cd = new ClientInactive();
            List<ClientInactive> clientData = cd.clientInactiveListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = clientData;
        }
        public void displayOnHoldClientData()
        {
            ClientOnHold cd = new ClientOnHold();
            List<ClientOnHold> clientData = cd.clientOnHoldListData();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.DataSource = clientData;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelTotalEmployees_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Total Employees";
            displayTotalEmployeeData();
        }

        private void panelTotalClients_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Total Clients";
            displayTotalClientData();
        }

        private void panelActiveClients_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Active Clients";
            displayActiveClientData();
        }

        private void panelInactiveClients_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Inactive Clients";
            displayInactiveClientData();
        }

        private void panelOnHoldClients_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "On Hold Clients";
            displayOnHoldClientData();
        }

        private void panelActiveEmployees_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Active Employees";
            displayActiveEmployeeData();
        }

        private void panelInactiveEmployees_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "Inactive Employees";
            displayInactiveEmployeeData();
        }

        private void panelPendingEmployees_Click(object sender, EventArgs e)
        {
            gridLabel.Text = "On Hold Employees";
            displayPendingEmployeeData();
        }

        private void totalClients_Click(object sender, EventArgs e)
        {

        }
    }
}
