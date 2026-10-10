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
    public partial class Bai_7_6 : Form
    {


        string strConn = @"Data Source=.;Initial Catalog=CK_BAI_7;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        public Bai_7_6()
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


        private void LoadDataToGrid(string query)
        {
            try
            {
                if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Chưa mở kết nối SQL!");
                    return;
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_NhanVien.DataSource = dt;
                    dgv_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dt.Columns.Contains("TONGLUONGTB"))
                    {
                        dgv_NhanVien.Columns["TONGLUONGTB"].DefaultCellStyle.Format = "#,##0";
                    }
                    else if (dt.Columns.Contains("TONG_LUONG_TB"))
                    {
                        dgv_NhanVien.Columns["TONG_LUONG_TB"].DefaultCellStyle.Format = "#,##0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi Hệ Thống");
            }
        }


        private void btn_Inline_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DBO.Inline_Table_Valued()";
            LoadDataToGrid(query);
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DBO.Multistatement()";
            LoadDataToGrid(query);
        }
    }
}
