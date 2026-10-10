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
    public partial class Bai_7_2 : Form
    {


        string strConn = @"Data Source=.;Initial Catalog=CK_BAI_7;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        public Bai_7_2()
        {
            InitializeComponent();
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
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                MessageBox.Show("Đóng kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Chưa mở kết nối SQL!");
                    return;
                }

                string maNV = txt_MaNV.Text.Trim();
                string maDA = txt_MaDA.Text.Trim();

                string query = "SELECT DBO.LUONG_NV_THEO_DUAN(@MANV, @MADA)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MANV", maNV);
                    cmd.Parameters.AddWithValue("@MADA", maDA);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal luong = Convert.ToDecimal(result);

                        if (luong == -1)
                        {
                            MessageBox.Show("Lỗi: Mã nhân viên hoặc mã dự án đang bị bỏ trống!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Kq.Text = "";
                        }

                        else if (luong == -2)
                        {
                            MessageBox.Show("Lỗi: Mã nhân viên hoặc mã dự án không tồn tại!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Kq.Text = "";
                        }
                        else
                        {
                            txt_Kq.Enabled = false;
                            txt_Kq.Text = luong.ToString("#,##0");
                        }
                    }
                    else
                    {
                        txt_Kq.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi Hệ Thống");
            }
        }
    }
}
