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
    public partial class Bai_10_1b : Form
    {

        string strConn = @"Data Source=.; Initial Catalog=CK_BAI_10; Integrated Security=True; TrustServerCertificate=True";
        SqlConnection sqlConn = null;
        string bangHienTai = "";

        public Bai_10_1b()
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

                    LoadData("BUOITHI");
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
            if (bangHienTai != "BUOITHI")
                return;

            if (e.RowIndex < 0)
                return;

            txt_HocKy.Text = dgv.Rows[e.RowIndex].Cells["HKY"].Value?.ToString();

            if (dgv.Rows[e.RowIndex].Cells["NGAY"].Value != DBNull.Value)
            {
                dtp_Ngay.Value = Convert.ToDateTime(
                    dgv.Rows[e.RowIndex].Cells["NGAY"].Value
                );
            }

            txt_Gio.Text = dgv.Rows[e.RowIndex].Cells["GIO"].Value?.ToString();
            txt_MaMH.Text = dgv.Rows[e.RowIndex].Cells["MAMH"].Value?.ToString();
            txt_tgThi.Text = dgv.Rows[e.RowIndex].Cells["TGTHI"].Value?.ToString();
            txt_Phong.Text = dgv.Rows[e.RowIndex].Cells["PHG"].Value?.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa mở kết nối SQL!");
                return;
            }

            if (string.IsNullOrEmpty(txt_MaMH.Text) ||
                string.IsNullOrEmpty(txt_HocKy.Text) ||
                string.IsNullOrEmpty(txt_Gio.Text) ||
                string.IsNullOrEmpty(txt_Phong.Text) ||
                string.IsNullOrEmpty(txt_tgThi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string queryCheck = @"
            SELECT dbo.FN_30_TIET
            (
                @HK,
                @NGAY,
                @GIO,
                @PHG,
                @MAMH,
                @TGTHI
            )";

                float tgThi = float.Parse(txt_tgThi.Text);
                int ketQua;

                using (SqlCommand cmd = new SqlCommand(queryCheck, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@HK", txt_HocKy.Text);
                    cmd.Parameters.AddWithValue("@NGAY", dtp_Ngay.Value.Date);
                    cmd.Parameters.AddWithValue("@GIO", TimeSpan.Parse(txt_Gio.Text));
                    cmd.Parameters.AddWithValue("@PHG", txt_Phong.Text);
                    cmd.Parameters.AddWithValue("@MAMH", txt_MaMH.Text);
                    cmd.Parameters.AddWithValue("@TGTHI", tgThi);

                    ketQua = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (ketQua == 0)
                {
                    MessageBox.Show(
                        "Môn học có 30 tiết thì thời gian thi phải là 120 phút!",
                        "Vi phạm ràng buộc",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string query = @"
            INSERT INTO BUOITHI
            (
                HKY,
                NGAY,
                GIO,
                PHG,
                MAMH,
                TGTHI
            )
            VALUES
            (
                @HK,
                @NGAY,
                @GIO,
                @PHG,
                @MAMH,
                @TGTHI
            )";

                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@HK", txt_HocKy.Text);
                    cmd.Parameters.AddWithValue("@NGAY", dtp_Ngay.Value.Date);
                    cmd.Parameters.AddWithValue("@GIO", TimeSpan.Parse(txt_Gio.Text));
                    cmd.Parameters.AddWithValue("@PHG", txt_Phong.Text);
                    cmd.Parameters.AddWithValue("@MAMH", txt_MaMH.Text);
                    cmd.Parameters.AddWithValue("@TGTHI", tgThi);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công!");
                    LoadData("BUOITHI");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Giờ thi hoặc thời gian thi không đúng định dạng!",
                    "Lỗi định dạng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("CHK_30_TIET"))
                {
                    MessageBox.Show(
                        "Môn học có 30 tiết thì thời gian thi phải là 120 phút!",
                        "Vi phạm ràng buộc",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show(
                        "Mã môn học không tồn tại hoặc dữ liệu khóa ngoại không hợp lệ!",
                        "Lỗi khóa ngoại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "Lỗi CSDL: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_Bang1_Click(object sender, EventArgs e)
        {
            LoadData("MHOC");
        }

        private void btn_Bang2_Click(object sender, EventArgs e)
        {
            LoadData("BUOITHI");
        }
    }
}
