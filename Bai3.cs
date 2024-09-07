using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

namespace LeChucGiang_buoi1
{


    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }


        int n;
        private void txtn_TextChanged(object sender, EventArgs e)
        {
            
            n = Convert.ToInt32(txtn.Text);
            if (SNT(n))
                txtkt.Text = n + " là số nguyên tố";
            else txtkt.Text = n + " không phải là số nguyên tố!!!";


            List<int> list = new List<int>();
            string chuoi = "";

            for (int i = 2; i < n; i++)
            {
                if (SNT(i))
                    list.Add(i);
            }

            for(int i =0; i< list.Count; i++)
            {
                chuoi += list[i].ToString() + " ";
            }
             txtnhohon.Text = chuoi;
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i < n; i++) 
                {
                    if (n % i == 0)
                    {
                        return false;
                        break;
                    }
                }
            } 
                 return true;
        
        }
        private void Bai3_Load(object sender, EventArgs e)
        {
            

        }
    }
}

