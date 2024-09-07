using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeChucGiang_buoi1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnthuch_Click(object sender, EventArgs e)
        {

            int a, b, c, max;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            max = a;

            if ((max < b || max == b))
            {
                max = b;
                txtkq.Text = max.ToString();

                if ((max < c || max == c))
                {
                    max = c;
                    txtkq.Text = max.ToString();
                }

            }
            else
            {
                txtkq.Text = max.ToString();
            }






        }

        private void btntt_Click(object sender, EventArgs e)
        {
            txta.ResetText();
            txtb.ResetText();
            txtc.ResetText();
            txtkq.ResetText();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
