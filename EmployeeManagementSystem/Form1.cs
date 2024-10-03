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
    public partial class Form1 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = loginShowPassword.Checked ? '\0' : '•';
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (loginUsername.Text == "" || loginPassword.Text == "")
            {
                MessageBox.Show("Please Input All Fields", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using(SqlCommand cmd = new SqlCommand(selectData, connect)) 
                        {
                            cmd.Parameters.AddWithValue("username", loginUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("password", loginPassword.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                //MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
                
        }

        private void loginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn_Click(sender, e);
            }
        }
    }
}
