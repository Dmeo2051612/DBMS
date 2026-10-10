using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BT_CK
{
    public partial class Bai_6_4 : Form
    {
        string strConn = @"Data Source =.; Initial Catalog = CK_BAI_6; Integrated Security = True; TrustServerCertificate=True";
        SqlConnection sqlConn = null;

        string maTuaSachDuocChon = "";

        public Bai_6_4()
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

                    // Gắn "tai nghe" để bắt các lệnh PRINT từ SQL Server
                    sqlConn.InfoMessage += new SqlInfoMessageEventHandler(sqlConn_InfoMessage);
                }

                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                    LoadData("TUASACH");
                    lbl_thongbao.Text = "Sẵn sàng thao tác!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sqlConn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            lbl_thongbao.Text = e.Message;
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed) return;

            if (string.IsNullOrEmpty(txt_maTS.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã tựa sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tonTai = dgv.Rows.Cast<DataGridViewRow>()
                            .Any(x => x.Cells["MA_TUASACH"].Value != null && x.Cells["MA_TUASACH"].Value.ToString() == txt_maTS.Text);

            if (tonTai)
            {
                MessageBox.Show("Mã tựa sách này đã tồn tại. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_maTS.Focus(); 
                return; 
            }

            lbl_thongbao.Text = "";

            try
            {
                string query = "INSERT INTO TUASACH (MA_TUASACH, TUASACH, TACGIA) VALUES (@MA, @TEN, @TACGIA)";
                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MA", txt_maTS.Text);
                    cmd.Parameters.AddWithValue("@TEN", txt_tenTS.Text);
                    cmd.Parameters.AddWithValue("@TACGIA", txt_tacgia.Text);

                    cmd.ExecuteNonQuery();

                    LoadData("TUASACH");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (sqlConn == null || sqlConn.State == ConnectionState.Closed) return;

            if (string.IsNullOrEmpty(txt_maTS.Text))
            {
                MessageBox.Show("Vui lòng chọn tựa sách cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txt_maTS.Text != maTuaSachDuocChon)
            {
                MessageBox.Show("Bạn không được phép thay đổi Mã tựa sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_maTS.Text = maTuaSachDuocChon;

                return; 
            }

            lbl_thongbao.Text = "";

            try
            {
                string query = "UPDATE TUASACH SET TUASACH = @TEN, TACGIA = @TACGIA WHERE MA_TUASACH = @MA";
                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MA", txt_maTS.Text);
                    cmd.Parameters.AddWithValue("@TEN", txt_tenTS.Text);
                    cmd.Parameters.AddWithValue("@TACGIA", txt_tacgia.Text);

                    cmd.ExecuteNonQuery();

                    LoadData("TUASACH");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                txt_maTS.Text = row.Cells["MA_TUASACH"].Value?.ToString();
                txt_tenTS.Text = row.Cells["TUASACH"].Value?.ToString();
                txt_tacgia.Text = row.Cells["TACGIA"].Value?.ToString();

                maTuaSachDuocChon = txt_maTS.Text;
            }
        }

        private void btn_Dong_Click_1(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                dgv.DataSource = null;
                lbl_thongbao.Text = "Đã đóng kết nối.";
            }
        }
    }
}