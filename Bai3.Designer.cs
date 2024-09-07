namespace LeChucGiang_buoi1
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnhohon = new TextBox();
            txtkt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtn = new TextBox();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // txtnhohon
            // 
            txtnhohon.Enabled = false;
            txtnhohon.Font = new Font("Tahoma", 13F);
            txtnhohon.Location = new Point(571, 406);
            txtnhohon.Name = "txtnhohon";
            txtnhohon.Size = new Size(735, 49);
            txtnhohon.TabIndex = 2;
            // 
            // txtkt
            // 
            txtkt.Enabled = false;
            txtkt.Font = new Font("Tahoma", 13F);
            txtkt.Location = new Point(571, 313);
            txtkt.Name = "txtkt";
            txtkt.Size = new Size(735, 49);
            txtkt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F);
            label1.Location = new Point(489, 42);
            label1.Name = "label1";
            label1.Size = new Size(896, 77);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và Tìm số Nguyên Tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(225, 228);
            label2.Name = "label2";
            label2.Size = new Size(129, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhập n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(225, 320);
            label3.Name = "label3";
            label3.Size = new Size(222, 42);
            label3.TabIndex = 1;
            label3.Text = "Kiểm tra SNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(225, 409);
            label4.Name = "label4";
            label4.Size = new Size(321, 42);
            label4.TabIndex = 1;
            label4.Text = "Tìm SNT nhỏ hơn n";
            // 
            // txtn
            // 
            txtn.Font = new Font("Tahoma", 13F);
            txtn.Location = new Point(571, 221);
            txtn.Name = "txtn";
            txtn.Size = new Size(735, 49);
            txtn.TabIndex = 2;
            txtn.TextChanged += txtn_TextChanged;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.Font = new Font("Tahoma", 13F);
            btnthoat.ForeColor = Color.White;
            btnthoat.Location = new Point(689, 518);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(150, 74);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 987);
            Controls.Add(btnthoat);
            Controls.Add(txtkt);
            Controls.Add(txtnhohon);
            Controls.Add(txtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtn;
        private TextBox txtnhohon;
        private Button btnthoat;
        private TextBox txtkt;
    }
}