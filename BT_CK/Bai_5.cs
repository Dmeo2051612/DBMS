using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_CK
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            Bai_5a f = new Bai_5a();
            f.Show();
        }

        private void btn_DauSach_Click(object sender, EventArgs e)
        {
            Bai_5b f = new Bai_5b();
            f.Show();
        }

        private void btn_DangMuon_Click(object sender, EventArgs e)
        {
            Bai_5c f = new Bai_5c();
            f.Show();
        }

        private void btn_QuaHan_Click(object sender, EventArgs e)
        {
            Bai_5d f = new Bai_5d();
            f.Show();
        }

        private void btn_TreEmMuon_Click(object sender, EventArgs e)
        {
            Bai_5e f = new Bai_5e();
            f.Show();
        }
    }
}
