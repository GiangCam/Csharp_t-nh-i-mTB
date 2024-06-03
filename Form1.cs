using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tínhđiểmTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        txttoan.Text = 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntinhtrungbinh_Click(object sender, EventArgs e)
        {
            Double Toan, Van, tb;
            Toan = Convert.ToDouble(txttoan.Text);
            Van = Convert.ToDouble(txtvan.Text);
            tb = (Toan + Van) / 2;
            txttb.Text = tb.ToString();
            if (tb < 5)
            {
                txtxeploai.Text = "Yếu";
            }
            else if (tb <= 6)
            {
                txtxeploai.Text = "Tb";
            }
            else if (tb < 8)
            {
                txtxeploai.Text = "Khá";
            }
            else {tb <= 10}
            {
                txtxeploai.Text = "Gioi";
            }
            }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

