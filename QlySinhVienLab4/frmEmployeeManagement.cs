using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace QlySinhVienLab4
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString.ToString();
        SqlConnection con;
        string Key = "4401104244VIETTV";
        string action = "";

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            
            dgv_Employee.DataSource = GetAllNhanVien(connectionString).Tables[0];
            initState();
        }

        private void initState()
        {
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;
            btn_update.Enabled = true;
            btn_exit.Enabled = true;
            btn_Save.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void AddState()
        {
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_update.Enabled = false;
            btn_exit.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void CancelState()
        {
            txt_Email.Clear();
            txt_EmployeeID.Clear();
            txt_fullname.Clear();
            txt_password.Clear();
            txt_salary.Clear();
            txt_username.Clear();
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;
            btn_update.Enabled = true;
            btn_exit.Enabled = true;
            btn_Save.Enabled = false;
            btn_cancel.Enabled = false;
        }

        DataSet GetAllNhanVien(string connectionString)
        {
            DataSet data = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_SEL_ENCRYPT_NHANVIEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }

            return data;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddState();
            action = "ADD";
        }
   
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {

        }

        // format data to string
        private void dgv_Employee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 2 - Salt, 3 - SecurePassword
            if ( e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    
                    byte[] salaryByte = (byte[])e.Value;
                    string salaryString = Encoding.UTF8.GetString(salaryByte);
                    string salaryDescyptor = Encryptor.DecryptAES(salaryString, Key);
                    e.Value = salaryDescyptor;
                    e.FormattingApplied = true;
                }
                else
                    e.FormattingApplied = false;
            }
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_EmployeeID.Text = dgv_Employee.CurrentRow.Cells[0].Value.ToString();
            txt_fullname.Text = dgv_Employee.CurrentRow.Cells[1].Value.ToString();
            txt_Email.Text = dgv_Employee.CurrentRow.Cells[2].Value.ToString();
            byte[] salaryByte = (byte[])dgv_Employee.CurrentRow.Cells[3].Value;
            string salaryString = Encoding.UTF8.GetString(salaryByte);
            string salaryDescyptor = Encryptor.DecryptAES(salaryString, Key);
            txt_salary.Text = salaryDescyptor;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(action == "ADD")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string salary = Encryptor.EncryptAES(txt_salary.Text, Key);
                    string password = Encryptor.SHA1Hash(txt_password.Text);
                    using (SqlCommand cmd = new SqlCommand("SP_INS_ENCRYPT_NHANVIEN", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = txt_EmployeeID.Text;
                        cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = txt_fullname.Text;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txt_Email.Text;
                        cmd.Parameters.Add("@luong", SqlDbType.VarChar).Value = salary;
                        cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = txt_username.Text;
                        cmd.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = password;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_Employee.DataSource = GetAllNhanVien(connectionString).Tables[0];
                    }
                }
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CancelState();
        }
    }
}
