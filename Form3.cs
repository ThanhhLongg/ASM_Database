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
using System.Xml.Linq;

namespace ASM_2_Thầy_Toàn
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
        }
        SqlConnection connection;


        public Form3(string username)
        {
            InitializeComponent();
            connection = new SqlConnection("Server= LONGG\\SQLEXPRESS; Database= ASM2 thầy toàn; Integrated Security=True;");
            lbUser.Text = "User " + username;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Mở kết nối khi form tải
            connection.Open();

            // Điền dữ liệu vào DataGridView và ComboBox
            FillData();
            // GetStudents();
            GetClasses();
        }

        private void bbtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Dispose();
        }
        public void FillData()
        {

            string query = "select * from student";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvManagement.DataSource = tbl;
            connection.Close();

        }
        /*public void GetStudents()
        {
            string query = "SELECT student_id, student_name_id FROM student";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            txtName.DataSource = tbl;
            txtName.DisplayMember = "student_name_id";
            txtName.ValueMember = "student_id";
        }*/

        public void GetClasses()
        {
            string query = "SELECT class_id, class_name FROM class";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            cbClass.DataSource = tbl;
            cbClass.DisplayMember = "class_name";
            cbClass.ValueMember = "class_id";
        }


        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;

            string studentID = txtID.Text;
            string studentNameID = txtName.Text;
            string studentGender = txtGender.Text;
            string studentDateOfBirth = txtDayofBirth.Text;
            string classID = cbClass.SelectedValue.ToString();

            // Kiểm tra lỗi cho studentID
            if (string.IsNullOrEmpty(studentID))
            {
                error++;
                lbIDError.Text = "ID can't be blank";
            }
            else
            {
                lbIDError.Text = "";
                // Kiểm tra xem studentID có tồn tại trong bảng không
                string checkQuery = "SELECT COUNT(*) FROM student WHERE student_id = @studentID";

                using (SqlConnection connection = new SqlConnection("Server=LONGG\\SQLEXPRESS; Database=ASM2 thầy toàn; Integrated Security=True;"))
                {
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.Add("@studentID", SqlDbType.Int).Value = int.Parse(studentID);

                        connection.Open();
                        int count = (int)checkCmd.ExecuteScalar();
                        connection.Close();

                        if (count > 0)
                        {
                            error++;
                            lbIDError.Text = "This ID already exists, please choose another";
                        }
                    }
                }
            }

            // Kiểm tra lỗi cho các trường khác
            if (string.IsNullOrEmpty(studentNameID))
            {
                error++;
                lbNameError.Text = "Name ID can't be blank";
            }
            else
            {
                lbNameError.Text = "";
            }

            if (string.IsNullOrEmpty(studentGender))
            {
                error++;
                lbGenderError.Text = "Gender can't be blank";
            }
            else
            {
                lbGenderError.Text = "";
            }

            if (string.IsNullOrEmpty(studentDateOfBirth))
            {
                error++;
                lbDateOfBirthError.Text = "Date of Birth can't be blank";
            }
            else
            {
                lbDateOfBirthError.Text = "";
            }

            // Nếu không có lỗi, thực hiện chèn dữ liệu
            if (error == 0)
            {
                try
                {
                    string insert = "INSERT INTO student (student_id, student_name_id, student_gender, student_date_of_birth, class_id) VALUES (@studentID, @studentNameID, @studentGender, @studentDateOfBirth, @classID)";

                    using (SqlConnection connection = new SqlConnection("Server=LONGG\\SQLEXPRESS; Database=ASM2 thầy toàn; Integrated Security=True;"))
                    {
                        using (SqlCommand cmd = new SqlCommand(insert, connection))
                        {
                            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = int.Parse(studentID);
                            cmd.Parameters.Add("@studentNameID", SqlDbType.VarChar).Value = studentNameID;
                            cmd.Parameters.Add("@studentGender", SqlDbType.VarChar).Value = studentGender;
                            cmd.Parameters.Add("@studentDateOfBirth", SqlDbType.Date).Value = DateTime.Parse(studentDateOfBirth);
                            cmd.Parameters.Add("@classID", SqlDbType.Int).Value = int.Parse(classID);

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();

                            FillData(); // Cập nhật dữ liệu hiển thị
                            MessageBox.Show("Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvManagement.Rows[e.RowIndex];
                txtID.Text = row.Cells["student_id"].Value.ToString();
                txtName.Text = row.Cells["student_name_id"].Value.ToString();
                txtGender.Text = row.Cells["student_gender"].Value.ToString();
                txtDayofBirth.Text = row.Cells["student_date_of_birth"].Value.ToString();
                cbClass.SelectedValue = row.Cells["class_id"].Value.ToString();
            }*/
        }

        private void dgvManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvManagement.Rows[e.RowIndex];
                txtID.Text = row.Cells["StudentID"].Value.ToString();
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtDayofBirth.Text = row.Cells["DateOfBirth"].Value.ToString();
                cbClass.SelectedValue = row.Cells["ClassID"].Value.ToString();
            }
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "UPDATE dbo.student SET student_name_id = @name, " +
                                "student_gender = @gender, student_date_of_birth = @dob, class_id = @classid " +
                                "WHERE student_id = @studentid";

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = txtGender.Text;
                    cmd.Parameters.Add("@dob", SqlDbType.Date).Value = DateTime.Parse(txtDayofBirth.Text);
                    cmd.Parameters.Add("@classid", SqlDbType.Int).Value = int.Parse(cbClass.SelectedValue.ToString());
                    cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = int.Parse(txtID.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        FillData();
                        MessageBox.Show(this, "Update successfully", "Result", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Update failed", "Result", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa các trường văn bản
            txtID.Text = "";
            txtName.Text = "";
            txtGender.Text = "";
            txtDayofBirth.Text = "";

            // Đặt lại ComboBox về trạng thái không chọn gì
            if (cbClass.Items.Count > 0)
            {
                cbClass.SelectedIndex = -1; // Không chọn mục nào
            }

            // Nếu có cần thiết, bạn có thể thêm mã để đặt lại các label lỗi
            lbIDError.Text = "";
            lbNameError.Text = "";
            lbGenderError.Text = "";
            lbDateOfBirthError.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa dữ liệu
            if (MessageBox.Show(this, "Do you want to delete this record?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xác nhận rằng trường ID không trống
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Câu lệnh SQL để xóa dữ liệu
                    string deleteQuery = "DELETE FROM student WHERE student_id = @studentID";

                    using (SqlConnection connection = new SqlConnection("Server=LONGG\\SQLEXPRESS; Database=ASM2 thầy toàn; Integrated Security=True;"))
                    {
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL
                            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = int.Parse(txtID.Text);

                            // Mở kết nối và thực thi câu lệnh SQL
                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật dữ liệu hiển thị
                                FillData();
                                MessageBox.Show("Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No record found with the provided ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }

        private void lbNameError_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }
    }
    }
   
