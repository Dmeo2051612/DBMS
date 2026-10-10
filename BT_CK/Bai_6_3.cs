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
    public partial class Bai_6_3 : Form
    {


        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_6; Integrated Security = True; TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        string bangHienTai = "";

        public Bai_6_3()
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

                    LoadData("CUONSACH");
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
                if (bangHienTai == "CUONSACH" && dgv.Columns.Contains("MA_CUONSACH"))
                {
                    txt_maCS.Text = dgv.Rows[e.RowIndex].Cells["MA_CUONSACH"].Value?.ToString();
                    txt_ISBN.Text = dgv.Rows[e.RowIndex].Cells["ISBN"].Value?.ToString();
                    txt_trangthai.Text = dgv.Rows[e.RowIndex].Cells["TINHTRANG"].Value?.ToString();
                }
            }
        }

        private void btn_Ds_Click(object sender, EventArgs e)
        {
            LoadData("DAUSACH");
        }

        private void btn_Cs_Click(object sender, EventArgs e)
        {
            LoadData("CUONSACH");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa mở kết nối SQL!");
                return;
            }

            if (string.IsNullOrEmpty(txt_maCS.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng bên bảng Cuốn sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("SUA_CUONSACH", sqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);
                    cmd.Parameters.AddWithValue("@MACS", txt_maCS.Text);
                    cmd.Parameters.AddWithValue("@TINHTRANG", txt_trangthai.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");

                    LoadData("CUONSACH");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
