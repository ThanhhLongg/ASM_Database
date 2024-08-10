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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
        }
        SqlConnection connection;

        public ViewStudent(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
            lbUser.Text = "User" + username;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Mở kết nối khi form tải
            connection.Open();

            // Điền dữ liệu vào DataGridView và ComboBox
            FillData();
            // GetStudents();
           // GetClasses();
        }
        public void FillData()
        {
            string query = "select * from student";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvViewStudent.DataSource = tbl;
            connection.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Dispose();
        }

        private void dgvViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy student_id từ TextBox
            string studentID = txtSearchID.Text;

            // Kiểm tra nếu studentID không rỗng
            if (!string.IsNullOrEmpty(studentID))
            {
                // Chuỗi kết nối tới cơ sở dữ liệu
                string connectionString = "Server=LONGG\\SQLEXPRESS; Database=ASM2 thầy toàn; Integrated Security=True;";

                // Câu lệnh SQL để tìm kiếm học sinh theo student_id
                string query = "SELECT s.student_id, s.student_name_id, s.student_gender, s.student_date_of_birth, s.class_id " +
                               "FROM dbo.student s " +
                               "WHERE s.student_id = @studentID";

                // Kết nối tới cơ sở dữ liệu và thực hiện truy vấn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = int.Parse(studentID);

                        connection.Open();
                        DataTable tbl = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tbl);
                        dgvViewStudent.DataSource = tbl;
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Student ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
