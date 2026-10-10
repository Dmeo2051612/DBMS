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
    public partial class Bai_10_1 : Form
    {
        public Bai_10_1()
        {
            InitializeComponent();
        }

        private void btn_Bai10_1a_Click(object sender, EventArgs e)
        {
            Bai_10_1a f = new Bai_10_1a();
            f.Show();
        }

        private void btn_Bai10_1b_Click(object sender, EventArgs e)
        {
            Bai_10_1b f = new Bai_10_1b();
            f.Show();
        }

        private void btn_Bai10_1c_Click(object sender, EventArgs e)
        {
            Bai_10_1c f = new Bai_10_1c();
            f.Show();
        }
    }
}
