using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace EmployeeManagementSystem
{
    class EmployeeData
    {
        //public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string Email {  get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        //public int salary { get; set; }
        public string Status { get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            //left is local right is in DB
                            EmployeeData ed = new EmployeeData();
                            //ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.FirstName = reader["first_name"].ToString();
                            ed.LastName = reader["last_name"].ToString();
                            ed.Address = reader["current_address"].ToString();
                            ed.ContactInfo = reader["contact_info"].ToString();
                            ed.Email = reader["email"].ToString();
                            ed.Sex = reader["gender"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            //ed.salary = (int)reader["salary"];
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
