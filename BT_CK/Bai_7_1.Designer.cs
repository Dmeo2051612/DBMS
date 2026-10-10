namespace BT_CK
{
    partial class Bai_7_1
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
            this.btn_Solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.txt_Kq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(424, 396);
            this.btn_Solve.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(284, 171);
            this.btn_Solve.TabIndex = 23;
            this.btn_Solve.Text = "Tra cứu";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 69);
            this.label3.TabIndex = 22;
            this.label3.Text = "=>";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(906, 15);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(284, 171);
            this.btn_Dong.TabIndex = 21;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(11, 15);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(284, 171);
            this.btn_Mo.TabIndex = 20;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // txt_Kq
            // 
            this.txt_Kq.Location = new System.Drawing.Point(775, 296);
            this.txt_Kq.Name = "txt_Kq";
            this.txt_Kq.Size = new System.Drawing.Size(183, 30);
            this.txt_Kq.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số tiền lương trung bình phòng ban";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(160, 296);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(183, 30);
            this.txt_Ma.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập mã phòng ban";
            // 
            // Bai_7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 635);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Controls.Add(this.txt_Kq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_7_1";
            this.Text = "Bai_7_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.TextBox txt_Kq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label1;
    }
}