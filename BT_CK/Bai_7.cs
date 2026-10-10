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
    public partial class Bai_7 : Form
    {
        public Bai_7()
        {
            InitializeComponent();
        }

        private void btn_LuongPB_Click(object sender, EventArgs e)
        {
            Bai_7_1 f = new Bai_7_1();
            f.Show();
        }

        private void btn_LuongDA_Click(object sender, EventArgs e)
        {
            Bai_7_2 f = new Bai_7_2();  
            f.Show();
        }

        private void btn_DangMuon_Click(object sender, EventArgs e)
        {
            Bai_7_3 f = new Bai_7_3();
            f.Show();
        }

        private void btn_QuaHan_Click(object sender, EventArgs e)
        {
            Bai_7_4 f = new Bai_7_4();
            f.Show();
        }

        private void btn_TreEmMuon_Click(object sender, EventArgs e)
        {
            Bai_7_5 f = new Bai_7_5();
            f.Show();
        }

        private void btn_BaiCuoi_Click(object sender, EventArgs e)
        {
            Bai_7_6 f = new Bai_7_6();
            f.Show();
        }
    }
}
