namespace LeChucGiang_buoi1
{
    partial class Bai2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btntt = new Button();
            btnthoat = new Button();
            btnnhap = new Button();
            txtso = new TextBox();
            txtvuanhap = new TextBox();
            txttong = new TextBox();
            txtchan = new TextBox();
            txtle = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(511, 56);
            label1.Name = "label1";
            label1.Size = new Size(794, 77);
            label1.TabIndex = 0;
            label1.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(127, 226);
            label2.Name = "label2";
            label2.Size = new Size(144, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhập số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(127, 325);
            label3.Name = "label3";
            label3.Size = new Size(232, 42);
            label3.TabIndex = 1;
            label3.Text = "Dãy vừa nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(127, 433);
            label4.Name = "label4";
            label4.Size = new Size(448, 42);
            label4.TabIndex = 1;
            label4.Text = "Tổng các phần tử trong dãy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(127, 547);
            label5.Name = "label5";
            label5.Size = new Size(181, 42);
            label5.TabIndex = 1;
            label5.Text = "Tổng chẵn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13F);
            label6.Location = new Point(941, 547);
            label6.Name = "label6";
            label6.Size = new Size(133, 42);
            label6.TabIndex = 1;
            label6.Text = "Tổng lẻ";
            // 
            // btntt
            // 
            btntt.BackColor = Color.FromArgb(128, 255, 255);
            btntt.Font = new Font("Tahoma", 13F);
            btntt.ForeColor = Color.Red;
            btntt.Location = new Point(127, 752);
            btntt.Name = "btntt";
            btntt.Size = new Size(232, 73);
            btntt.TabIndex = 2;
            btntt.Text = "Tiếp tục";
            btntt.UseVisualStyleBackColor = false;
            btntt.Click += btntt_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.FromArgb(128, 255, 255);
            btnthoat.Font = new Font("Tahoma", 13F);
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(950, 752);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(232, 73);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnnhap
            // 
            btnnhap.BackColor = Color.FromArgb(128, 255, 128);
            btnnhap.Font = new Font("Tahoma", 13F);
            btnnhap.ForeColor = Color.Maroon;
            btnnhap.Location = new Point(965, 208);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(232, 73);
            btnnhap.TabIndex = 2;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = false;
            btnnhap.Click += btnnhap_Click;
            // 
            // txtso
            // 
            txtso.Font = new Font("Tahoma", 13F);
            txtso.Location = new Point(458, 232);
            txtso.Name = "txtso";
            txtso.Size = new Size(348, 49);
            txtso.TabIndex = 3;
            // 
            // txtvuanhap
            // 
            txtvuanhap.Enabled = false;
            txtvuanhap.Font = new Font("Tahoma", 13F);
            txtvuanhap.Location = new Point(471, 341);
            txtvuanhap.Name = "txtvuanhap";
            txtvuanhap.Size = new Size(493, 49);
            txtvuanhap.TabIndex = 3;
            // 
            // txttong
            // 
            txttong.Enabled = false;
            txttong.Font = new Font("Tahoma", 13F);
            txttong.Location = new Point(611, 426);
            txttong.Name = "txttong";
            txttong.Size = new Size(340, 49);
            txttong.TabIndex = 3;
            // 
            // txtchan
            // 
            txtchan.Enabled = false;
            txtchan.Font = new Font("Tahoma", 13F);
            txtchan.Location = new Point(402, 540);
            txtchan.Name = "txtchan";
            txtchan.Size = new Size(340, 49);
            txtchan.TabIndex = 3;
            // 
            // txtle
            // 
            txtle.Enabled = false;
            txtle.Font = new Font("Tahoma", 13F);
            txtle.Location = new Point(1124, 540);
            txtle.Name = "txtle";
            txtle.Size = new Size(340, 49);
            txtle.TabIndex = 3;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 972);
            Controls.Add(txtle);
            Controls.Add(txtchan);
            Controls.Add(txttong);
            Controls.Add(txtvuanhap);
            Controls.Add(txtso);
            Controls.Add(btnthoat);
            Controls.Add(btnnhap);
            Controls.Add(btntt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btntt;
        private Button btnthoat;
        private Button btnnhap;
        private TextBox txtso;
        private TextBox txtvuanhap;
        private TextBox txttong;
        private TextBox txtchan;
        private TextBox txtle;
    }
}