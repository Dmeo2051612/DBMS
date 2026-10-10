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
    public partial class Bai_1 : Form
    {


        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_1; Integrated Security = True; TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        public Bai_1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Chưa mở kết nối SQL!");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand("GIAI_PT_BAC_1", sqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@A", txt_a.Text);
                    cmd.Parameters.AddWithValue("@B", txt_b.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string thongBao = reader["THONGBAO"].ToString();

                            if (reader["NGHIEM"] != DBNull.Value)
                            {
                                double nghiem = Convert.ToDouble(reader["NGHIEM"]);
                                txt_Kq.Text = $"{thongBao}: x = {nghiem}";
                            }
                            else
                            {
                                txt_Kq.Text = thongBao;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Kq.Text = ""; 
            }
        }
    }
}
