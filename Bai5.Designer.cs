namespace LeChucGiang_buoi1
{
    partial class Bai5
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
            txtso = new TextBox();
            txtkq = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(344, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(535, 77);
            label1.TabIndex = 0;
            label1.Text = "Đọc số thành chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(328, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhập n (từ 1 đến 9)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 334);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 42);
            label3.TabIndex = 1;
            label3.Text = "Kết quả";
            // 
            // txtso
            // 
            txtso.Location = new Point(664, 185);
            txtso.Name = "txtso";
            txtso.Size = new Size(280, 49);
            txtso.TabIndex = 2;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(527, 327);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(417, 49);
            txtkq.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(194, 543);
            button1.Name = "button1";
            button1.Size = new Size(215, 56);
            button1.TabIndex = 3;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(752, 543);
            button2.Name = "button2";
            button2.Size = new Size(215, 56);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(19F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 714);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtkq);
            Controls.Add(txtso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 13F);
            Margin = new Padding(4);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtso;
        private TextBox txtkq;
        private Button button1;
        private Button button2;
    }
}