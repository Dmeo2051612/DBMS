namespace BT_CK
{
    partial class Bai_7_5
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
            this.txt_MaPB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Kq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_MaPB
            // 
            this.txt_MaPB.Location = new System.Drawing.Point(252, 286);
            this.txt_MaPB.Name = "txt_MaPB";
            this.txt_MaPB.Size = new System.Drawing.Size(183, 30);
            this.txt_MaPB.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nhập mã phòng ban";
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(438, 359);
            this.btn_Solve.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(284, 171);
            this.btn_Solve.TabIndex = 47;
            this.btn_Solve.Text = "Tra cứu";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 69);
            this.label3.TabIndex = 46;
            this.label3.Text = "=>";
            // 
            // txt_Kq
            // 
            this.txt_Kq.Location = new System.Drawing.Point(805, 286);
            this.txt_Kq.Name = "txt_Kq";
            this.txt_Kq.Size = new System.Drawing.Size(183, 30);
            this.txt_Kq.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tổng số dự án của phòng ban";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(894, 15);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(284, 171);
            this.btn_Dong.TabIndex = 43;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(15, 15);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(284, 171);
            this.btn_Mo.TabIndex = 42;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // Bai_7_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 619);
            this.Controls.Add(this.txt_MaPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Kq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_7_5";
            this.Text = "Bai_7_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Kq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
    }
}