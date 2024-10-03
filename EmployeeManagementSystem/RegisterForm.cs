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
    public partial class RegisterForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string password = registerPassword.Text.Trim();
            if(registerUsername.Text == "" || registerPassword.Text == "" || registerEmail.Text == "" )
            {
                MessageBox.Show("Please fill in all Fields", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (password.Length < 8)
                {
                    MessageBox.Show("Password is too short, it must be 8 characters or more. Current Length is " + password.Length, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            String selectUsername = "Select COUNT(id) FROM users WHERE username = @user";

                            using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                            {
                                checkUser.Parameters.AddWithValue("@user", registerUsername.Text.Trim());
                                int count = (int)checkUser.ExecuteScalar();
                                if (count >= 1)
                                {
                                    MessageBox.Show(registerUsername.Text.Trim() + "Account already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                                }
                                else
                                {
                                    DateTime today = DateTime.Today;

                                    string insertData = "INSERT INTO users" + "(username, password, email, date_register) " +
                                        "VALUES(@username, @password, @email, @dateReg)";

                                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@username", registerUsername.Text.Trim());
                                        cmd.Parameters.AddWithValue("@password", registerPassword.Text.Trim());
                                        cmd.Parameters.AddWithValue("@email", registerEmail.Text.Trim());
                                        cmd.Parameters.AddWithValue("@dateReg", today);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Account Created Successfully", "Information Message",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Form1 loginForm = new Form1();
                                        loginForm.Show();
                                        this.Hide();
                                    }
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
        }

        private void loginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = loginShowPassword.Checked ? '\0' : '•';
        }

        private void registerUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
