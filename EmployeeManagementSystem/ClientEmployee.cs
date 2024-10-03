using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class ClientEmployee
    {
        public string ClientID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string AssignedEmployee {  get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public List<ClientEmployee> clientEmployeesListData()
        {        
            List<ClientEmployee> clientEmployees = new List<ClientEmployee>();
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM clients WHERE status = 'Active' AND delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ClientEmployee ce = new ClientEmployee();
                            ce.ClientID = reader["client_id"].ToString();
                            ce.FirstName = reader["first_name"].ToString();
                            ce.LastName = reader["last_name"].ToString();
                            ce.Status = reader["status"].ToString();
                            ce.AssignedEmployee = reader["assigned_employee"].ToString();

                            clientEmployees.Add(ce);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }

            }
            return clientEmployees;
        }


    }
}
