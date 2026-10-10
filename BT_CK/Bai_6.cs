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
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
        }

        private void btn_B6_1_Click(object sender, EventArgs e)
        {
            Bai_6_1 f = new Bai_6_1();
            f.Show();
        }

        private void btn_B6_2_Click(object sender, EventArgs e)
        {
            Bai_6_2 f = new Bai_6_2();
            f.Show();
        }

        private void btn_B6_3_Click(object sender, EventArgs e)
        {
            Bai_6_3 f = new Bai_6_3();
            f.Show();
        }

        private void btn_B6_4_Click(object sender, EventArgs e)
        {
            Bai_6_4 f = new Bai_6_4();
            f.Show();
        }
    }
}
