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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
        List<int> arr_daySo = new List<int>(); // Khia báo list

        private void btnnhap_Click(object sender, EventArgs e)
        {
            int so = int.Parse(txtso.Text);
            int tong = 0;
            arr_daySo.Add(so);
            txtvuanhap.Text = " ";
            foreach (int i in arr_daySo)
            {
                txtvuanhap.Text += i + " ";
                tong += i;
            }
            txtso.Text = " ";

            int sum = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                sum += arr_daySo[i];
                txttong.Text = sum.ToString();
            }

            int tongchan = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                if (arr_daySo[i] % 2 == 0)
                {
                    tongchan += arr_daySo[i];
                    txtchan.Text = tongchan.ToString();
                }

            }


            int tongle = 0;
            for (int i = 0; i < arr_daySo.Count; i++)
            {
                if (arr_daySo[i] % 2 != 0)
                {
                    tongle += arr_daySo[i];
                    txtle.Text = tongle.ToString();
                }
            }






        }

        private void btntt_Click(object sender, EventArgs e)
        {
            txtso.ResetText();
            txtvuanhap.ResetText();
            txttong.ResetText();
            txtchan.ResetText();
            txtle.ResetText();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
