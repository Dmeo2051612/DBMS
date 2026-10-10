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

    public partial class Bai_2 : Form
    {

        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_2; Integrated Security = True; TrustServerCertificate=True";

        SqlConnection sqlConn = null;


        public Bai_2()
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

                
                string query = "SELECT * FROM dbo.GIAI_PT_BAC_2(@A, @B, @C)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.CommandType = CommandType.Text; 

                    cmd.Parameters.AddWithValue("@A", txt_a.Text);
                    cmd.Parameters.AddWithValue("@B", txt_b.Text);
                    cmd.Parameters.AddWithValue("@C", txt_c.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string thongBao = reader["THONGBAO"].ToString();

                            bool hasNghiem1 = reader["NGHIEM1"] != DBNull.Value;
                            bool hasNghiem2 = reader["NGHIEM2"] != DBNull.Value;

                            // Trường hợp có 2 nghiệm (Hai nghiệm phân biệt hoặc Nghiệm kép)
                            if (hasNghiem1 && hasNghiem2)
                            {
                                double nghiem1 = Convert.ToDouble(reader["NGHIEM1"]);
                                double nghiem2 = Convert.ToDouble(reader["NGHIEM2"]);

                                if (thongBao == "Nghiệm kép")
                                {
                                    txt_Kq.Text = $"{thongBao}: x = {nghiem1}";
                                }
                                else
                                {
                                    txt_Kq.Text = $"{thongBao}: x1 = {nghiem1}; x2 = {nghiem2}";
                                }
                            }
                            
                            else if (hasNghiem1 && !hasNghiem2)
                            {
                                double nghiem1 = Convert.ToDouble(reader["NGHIEM1"]);
                                txt_Kq.Text = $"{thongBao}: x = {nghiem1}";
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
