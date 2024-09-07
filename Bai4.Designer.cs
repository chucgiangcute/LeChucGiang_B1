namespace LeChucGiang_buoi1
{
    partial class Bai4
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
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new TextBox();
            btnthuch = new Button();
            btntt = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(386, 41);
            label1.Name = "label1";
            label1.Size = new Size(786, 77);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất trong 3 số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(146, 243);
            label2.Name = "label2";
            label2.Size = new Size(130, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhập A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(146, 410);
            label3.Name = "label3";
            label3.Size = new Size(130, 42);
            label3.TabIndex = 1;
            label3.Text = "Nhập B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(146, 571);
            label4.Name = "label4";
            label4.Size = new Size(130, 42);
            label4.TabIndex = 1;
            label4.Text = "Nhập C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(146, 728);
            label5.Name = "label5";
            label5.Size = new Size(137, 42);
            label5.TabIndex = 1;
            label5.Text = "Kết quả";
            // 
            // txta
            // 
            txta.Font = new Font("Tahoma", 13F);
            txta.Location = new Point(386, 243);
            txta.Name = "txta";
            txta.Size = new Size(200, 49);
            txta.TabIndex = 2;
            // 
            // txtb
            // 
            txtb.Font = new Font("Tahoma", 13F);
            txtb.Location = new Point(386, 403);
            txtb.Name = "txtb";
            txtb.Size = new Size(200, 49);
            txtb.TabIndex = 2;
            // 
            // txtc
            // 
            txtc.Font = new Font("Tahoma", 13F);
            txtc.Location = new Point(386, 564);
            txtc.Name = "txtc";
            txtc.Size = new Size(200, 49);
            txtc.TabIndex = 2;
            // 
            // txtkq
            // 
            txtkq.BackColor = Color.FromArgb(224, 224, 224);
            txtkq.Font = new Font("Tahoma", 13F);
            txtkq.Location = new Point(386, 728);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(670, 49);
            txtkq.TabIndex = 2;
            // 
            // btnthuch
            // 
            btnthuch.BackColor = Color.Yellow;
            btnthuch.Font = new Font("Tahoma", 13F);
            btnthuch.Location = new Point(805, 243);
            btnthuch.Name = "btnthuch";
            btnthuch.Size = new Size(251, 64);
            btnthuch.TabIndex = 3;
            btnthuch.Text = "Thực Hiện";
            btnthuch.UseVisualStyleBackColor = false;
            btnthuch.Click += btnthuch_Click;
            // 
            // btntt
            // 
            btntt.BackColor = Color.Lime;
            btntt.Font = new Font("Tahoma", 13F);
            btntt.Location = new Point(805, 395);
            btntt.Name = "btntt";
            btntt.Size = new Size(251, 64);
            btntt.TabIndex = 3;
            btntt.Text = "Tiếp tục";
            btntt.UseVisualStyleBackColor = false;
            btntt.Click += btntt_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Cyan;
            btnthoat.Font = new Font("Tahoma", 13F);
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(805, 560);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(251, 64);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1643, 985);
            Controls.Add(btnthoat);
            Controls.Add(btntt);
            Controls.Add(btnthuch);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai4";
            Text = "Bai4";
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
        private TextBox txtkq;
        private Button btnthuch;
        private Button btntt;
        private Button btnthoat;
    }
}