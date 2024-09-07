namespace LeChucGiang_buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, delta;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtkq.Text = "Phương trình vô số nghiệm";
                    }
                    if (c != 0)
                    {
                        txtkq.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    txtkq.Text = "Phương trình có một nghiệm duy nhất :" + -c / b;
                }


            }
            else
            {
                if (delta < 0)
                {
                    txtkq.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    txtkq.Text = "Phương trình có nghiệm kép x1 = x2 = " + -b / 2 * a;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                    txtkq.Text = "Nghiệm của phương trình là :" + x1 + " và " + x2;
                }

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
            txtkq.Text = "";
        }
    }
}
    

