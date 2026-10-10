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
    public partial class Bai_6_1 : Form
    {

        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_6; Integrated Security = True; TrustServerCertificate=True";

        SqlConnection sqlConn = null;

        string maCuonSachDuocChon = "";

        public Bai_6_1()
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv.Columns.Contains("MA_CUONSACH"))
                {
                    maCuonSachDuocChon = dgv.Rows[e.RowIndex].Cells["MA_CUONSACH"].Value.ToString();
                }
            }
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            maCuonSachDuocChon = "";
            LoadData("MUON");
        }

        private void btn_Cs_Click(object sender, EventArgs e)
        {
            maCuonSachDuocChon = ""; 
            LoadData("CUONSACH");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa mở kết nối SQL!");
                return;
            }

            if (string.IsNullOrEmpty(maCuonSachDuocChon))
            {
                MessageBox.Show("Vui lòng chọn một dòng bên bảng Mượn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("XOA_MUON", sqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MACS", maCuonSachDuocChon);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");

                    LoadData("MUON");
                    maCuonSachDuocChon = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
