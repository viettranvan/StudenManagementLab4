using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;



namespace QlySinhVienLab4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString.ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string md5Hash = Encryptor.MD5Hash(password);
                byte[] theBytesSV = Encoding.UTF8.GetBytes(md5Hash);

                string querySV = "SELECT * FROM SINHVIEN WHERE TENDN='" + username + "'AND MATKHAU= @matkhauSV";
                SqlCommand cmdSV = new SqlCommand(querySV, con);
                cmdSV.Parameters.Add("@matkhauSV", SqlDbType.VarBinary).Value = theBytesSV;

                SqlDataReader readerSV = cmdSV.ExecuteReader();
                if (readerSV.Read()) 
                {
                    MessageBox.Show("đăng nhập hệ thống thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmdSV.Dispose();
                    readerSV.Close();
                    string sha1Hash = Encryptor.SHA1Hash(password);
                    byte[] theBytesNV = Encoding.UTF8.GetBytes(sha1Hash);

                    string queryNV = "SELECT * FROM NHANVIEN WHERE TENDN='" + username + "' AND MATKHAU = @matkhauNV";
                    SqlCommand cmdNV = new SqlCommand(queryNV, con);
                    cmdNV.Parameters.Add("@matkhauNV", SqlDbType.VarBinary).Value = theBytesNV;
                    SqlDataReader readerNV = cmdNV.ExecuteReader();
                    if (readerNV.Read())
                    {
                        MessageBox.Show("đăng nhập hệ thống thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("tên đăng nhập hoặc mật khẩu không hợp lệ!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("không thể kết nối đến server!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string hash = Encryptor.SHA1Hash(username);
            txt_password.Text = hash;
        }
    }
}
