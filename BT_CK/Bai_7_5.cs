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
    public partial class Bai_7_5 : Form
    {


        string strConn = @"Data Source=.;Initial Catalog=CK_BAI_7;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        public Bai_7_5()
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

                string maPB = txt_MaPB.Text.Trim();

                if (string.IsNullOrEmpty(maPB))
                {
                    MessageBox.Show("Nhập mã phòng ban!");
                    txt_MaPB.Focus();
                    return;
                }

                string query = "SELECT DBO.SO_DA_PB(@MAPB)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MAPB", maPB);

                    object result = cmd.ExecuteScalar();

                    int so_da = Convert.ToInt32(result);

                    txt_Kq.Enabled = false;
                    txt_Kq.Text = so_da.ToString() + " dự án";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi Hệ Thống");
            }
        }
    }
}
