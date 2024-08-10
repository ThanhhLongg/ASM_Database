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

namespace ASM_2_Thầy_Toàn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
            textBox2.PasswordChar = '*';
            textBox1.PasswordChar = '*';
        }
        public Form1(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
            lbUser.Text = "User" + username;
            textBox2.PasswordChar = '*';
            textBox1.PasswordChar = '*';
        }

        SqlConnection connection;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            string password = textBox2.Text;

            string query = "select * from account where username =@username and u_password =@passwoгd";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);

            cmd.Parameters["@username"].Value = username;

            cmd.Parameters.AddWithValue("@passwoгd", SqlDbType.VarChar);

            cmd.Parameters["@passwoгd"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login successful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Form3 p = new Form3(username);
                    p.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("user"))
                {
                    MessageBox.Show(this, "Login successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    ViewStudent vp = new ViewStudent(username);
                    vp.ShowDialog();
                    this.Dispose();
                }
                else
                    lbError.Text = "You are not allowed to access";
            }
            else
            {
                lbError.Text = "Wrong username or password";
            }
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to Exit? ", "Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
