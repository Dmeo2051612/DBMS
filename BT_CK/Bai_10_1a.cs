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

namespace BT_CK
{
    public partial class Bai_10_1a : Form
    {

        string strConn = @"Data Source=.; Initial Catalog=CK_BAI_10; Integrated Security=True; TrustServerCertificate=True";
        SqlConnection sqlConn = null;
        string bangHienTai = "";

        public Bai_10_1a()
        {
            InitializeComponent();
        }


        private void LoadData(string tableName)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Vui lòng mở kết nối trước!");
                return;
            }
            string query = $"SELECT * FROM {tableName}";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            bangHienTai = tableName;
        }


        private void btn_Mo_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn == null)
                {
                    sqlConn = new SqlConnection(strConn);
                }

                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                    MessageBox.Show("Kết nối thành công!");

                    LoadData("PC_COI_THI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                dgv.DataSource = null;
                MessageBox.Show("Đóng kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_HocKy.Text = dgv.Rows[e.RowIndex].Cells["HKY"].Value?.ToString(); 

                if (dgv.Rows[e.RowIndex].Cells["NGAY"].Value != DBNull.Value)
                {
                    dtp_Ngay.Value = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["NGAY"].Value);
                }

                txt_Gio.Text = dgv.Rows[e.RowIndex].Cells["GIO"].Value?.ToString();
                txt_Phong.Text = dgv.Rows[e.RowIndex].Cells["PHG"].Value?.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa mở kết nối SQL!");
                return;
            }

            if (string.IsNullOrEmpty(txt_MaGV.Text) || string.IsNullOrEmpty(txt_HocKy.Text) ||
                string.IsNullOrEmpty(txt_Gio.Text) || string.IsNullOrEmpty(txt_Phong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO PC_COI_THI (MAGV, HK, NGAY, GIO, PHG) VALUES (@MAGV, @HK, @NGAY, @GIO, @PHG)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MAGV", txt_MaGV.Text);
                    cmd.Parameters.AddWithValue("@HK", txt_HocKy.Text);
                    cmd.Parameters.AddWithValue("@NGAY", dtp_Ngay.Value.Date);
                    cmd.Parameters.AddWithValue("@GIO", TimeSpan.Parse(txt_Gio.Text));
                    cmd.Parameters.AddWithValue("@PHG", txt_Phong.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");

                    LoadData("PC_COI_THI");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("CHK_KIEMTRA_GACTHI"))
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: Giáo viên không thể gác thi môn mình dạy vào thời gian này!", "Vi phạm ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ex.Message.Contains("FOREIGN KEY") && ex.Message.Contains("BUOITHI"))
                {
                    MessageBox.Show("Lỗi: Buổi thi (Học kỳ, Ngày, Giờ, Phòng) bạn nhập chưa tồn tại trong hệ thống. Vui lòng kiểm tra lại bảng BUOITHI!", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu đầu vào: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Bang1_Click(object sender, EventArgs e)
        {
            LoadData("GV");
        }

        private void btn_Bang2_Click(object sender, EventArgs e)
        {
            LoadData("BUOITHI");
        }
    }
}
