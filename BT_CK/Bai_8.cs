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
    public partial class Bai_8 : Form
    {
        public Bai_8()
        {
            InitializeComponent();
        }

        private void btn_Bai8_1_Click(object sender, EventArgs e)
        {
            Bai_8_1 f = new Bai_8_1();
            f.Show();
        }

        private void btn_Bai8_2_Click(object sender, EventArgs e)
        {
            Bai_8_2 f = new Bai_8_2();
            f.Show();
        }

        private void btn_Bai8_3_Click(object sender, EventArgs e)
        {
            Bai_8_3 f = new Bai_8_3();
            f.Show();
        }

        private void btn_Bai8_4_Click(object sender, EventArgs e)
        {
            Bai_8_4 f = new Bai_8_4();  
            f.Show();
        }

        private void btn_Bai8_5_Click(object sender, EventArgs e)
        {
            Bai_8_5 f = new Bai_8_5();
            f.Show();
        }
    }
}
