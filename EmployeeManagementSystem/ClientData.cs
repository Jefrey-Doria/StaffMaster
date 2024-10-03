using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class ClientData
    {
        public string ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string AssignedEmployee { get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");



        public List<ClientData> clientListData()
        {
            List<ClientData> clientList = new List<ClientData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM clients WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ClientData cd = new ClientData();
                            cd.ClientID = reader["client_id"].ToString();
                            cd.FirstName = reader["first_name"].ToString();
                            cd.LastName = reader["last_name"].ToString();
                            cd.ContactInfo = reader["contact_info"].ToString();
                            cd.Email = reader["email"].ToString();
                            cd.Status = reader["status"].ToString();
                            cd.AssignedEmployee = reader["assigned_employee"].ToString();

                            clientList.Add(cd);
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
            return clientList;
        }
    }
}
