namespace LeChucGiang_buoi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            label6 = new Label();
            txtkq = new TextBox();
            btngiai = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Tahoma", 24F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(498, 38);
            label1.Name = "label1";
            label1.Size = new Size(702, 77);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Tahoma", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 161);
            label2.Name = "label2";
            label2.Size = new Size(184, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhập a,b,c";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(265, 261);
            label3.Name = "label3";
            label3.Size = new Size(36, 42);
            label3.TabIndex = 1;
            label3.Text = "a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(265, 359);
            label4.Name = "label4";
            label4.Size = new Size(37, 42);
            label4.TabIndex = 1;
            label4.Text = "b";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(265, 446);
            label5.Name = "label5";
            label5.Size = new Size(34, 42);
            label5.TabIndex = 1;
            label5.Text = "c";
            // 
            // txta
            // 
            txta.Font = new Font("Tahoma", 13F);
            txta.Location = new Point(386, 265);
            txta.Name = "txta";
            txta.Size = new Size(710, 49);
            txta.TabIndex = 2;
            // 
            // txtb
            // 
            txtb.Font = new Font("Tahoma", 13F);
            txtb.Location = new Point(386, 356);
            txtb.Name = "txtb";
            txtb.Size = new Size(710, 49);
            txtb.TabIndex = 2;
            // 
            // txtc
            // 
            txtc.Font = new Font("Tahoma", 13F);
            txtc.Location = new Point(386, 446);
            txtc.Name = "txtc";
            txtc.Size = new Size(710, 49);
            txtc.TabIndex = 2;
            txtc.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13F);
            label6.Location = new Point(627, 564);
            label6.Name = "label6";
            label6.Size = new Size(137, 42);
            label6.TabIndex = 1;
            label6.Text = "Kết quả";
            label6.Click += label2_Click;
            // 
            // txtkq
            // 
            txtkq.Font = new Font("Tahoma", 13F);
            txtkq.Location = new Point(386, 645);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(710, 49);
            txtkq.TabIndex = 2;
            txtkq.TextChanged += textBox3_TextChanged;
            // 
            // btngiai
            // 
            btngiai.Font = new Font("Tahoma", 13F);
            btngiai.Location = new Point(199, 881);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(150, 60);
            btngiai.TabIndex = 3;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Tahoma", 13F);
            btnxoa.Location = new Point(572, 881);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(150, 60);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xoá";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Tahoma", 13F);
            btnthoat.Location = new Point(1025, 881);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(150, 60);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cyan;
            label7.Font = new Font("Tahoma", 13F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 738);
            label7.Name = "label7";
            label7.Size = new Size(235, 42);
            label7.TabIndex = 1;
            label7.Text = "Chọn thao tác";
            label7.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1701, 1031);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btngiai);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private Label label6;
        private TextBox txtkq;
        private Button btngiai;
        private Button btnxoa;
        private Button btnthoat;
        private Label label7;
    }
}
