using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public MainForm()
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void profileIcon_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) 
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            client1.Visible = false;
            payment1.Visible = false;

            setEmployee1.Visible = false;

            Dashboard dashform = dashboard1 as Dashboard;
            if(dashform != null)
            {
                dashform.refreshData();
            }

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            client1.Visible = false;
            payment1.Visible = false;

            setEmployee1.Visible = false;

            AddEmployee addEmployeeForm = addEmployee1 as AddEmployee;
            if (addEmployeeForm != null)
            {
                addEmployeeForm.refreshData();
            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            client1.Visible = false;
            payment1.Visible = true;

            setEmployee1.Visible = false;

            Payment paymentForm = payment1 as Payment;
            if(paymentForm != null)
            {
                paymentForm.refreshData();
            }    
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            payment1.Visible = false;
            client1.Visible = true;
            setEmployee1.Visible = false;

            Client clientForm = client1 as Client;
            if(clientForm != null)
            {
                clientForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            payment1.Visible = false;
            client1.Visible = false;
            setEmployee1.Visible = true;

            SetEmployee setEm = setEmployee1 as SetEmployee;
            if(setEm != null)
            {
                setEm.refreshData();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
