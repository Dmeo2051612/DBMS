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
    public partial class Bai_10 : Form
    {
        public Bai_10()
        {
            InitializeComponent();
        }

        private void btn_Bai10_1_Click(object sender, EventArgs e)
        {
            Bai_10_1 f = new Bai_10_1();
            f.Show();
        }

        private void btn_Bai10_2_Click(object sender, EventArgs e)
        {
            Bai_10_2 f = new Bai_10_2();
            f.Show();
        }
    }
}
