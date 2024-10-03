using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class EmployeeInactive
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<EmployeeInactive> employeeInactiveListData()
        {
            List<EmployeeInactive> listdata = new List<EmployeeInactive>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL AND status = 'Inctive'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeInactive ed = new EmployeeInactive();
                            ed.ID = reader["employee_id"].ToString();
                            ed.FirstName = reader["first_name"].ToString();
                            ed.LastName = reader["last_name"].ToString();
                            ed.Position = reader["position"].ToString();

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
