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
    public partial class Bai_6_2 : Form
    {


        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_6; Integrated Security = True; TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        public Bai_6_2()
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

                    LoadData("MUON");
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

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            LoadData("MUON");
        }

        private void btn_Cs_Click(object sender, EventArgs e)
        {
            LoadData("CUONSACH");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa mở kết nối SQL!");
                return;
            }


            bool tonTai = false;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["MA_CUONSACH"].Value != null && row.Cells["MA_CUONSACH"].Value.ToString() == txt_maCS.Text)
                {
                    tonTai = true;
                    break; 
                }
            }

            if (tonTai)
            {
                MessageBox.Show("Mã cuốn sách này đang được mượn. Vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            try
            {
                using (SqlCommand cmd = new SqlCommand("THEM_MUON", sqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);
                    cmd.Parameters.AddWithValue("@MACS", txt_maCS.Text);
                    cmd.Parameters.AddWithValue("@MADG", txt_maDG.Text);
                    cmd.Parameters.AddWithValue("@NGAYMUON", dtp_muon.Value);
                    cmd.Parameters.AddWithValue("@NGAYHETHAN", dtp_tra.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");

                    LoadData("MUON");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
