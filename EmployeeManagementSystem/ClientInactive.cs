using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class ClientInactive
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public List<ClientInactive> clientInactiveListData()
        {
            List<ClientInactive> listdata = new List<ClientInactive>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM clients WHERE delete_date IS NULL AND status = 'Inactive'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ClientInactive ed = new ClientInactive();
                            ed.ID = reader["client_id"].ToString();
                            ed.FirstName = reader["first_name"].ToString();
                            ed.LastName = reader["last_name"].ToString();
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
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
            return listdata;
        }
    }
}
