namespace BT_CK
{
    partial class Bai_7
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
            this.btn_BaiCuoi = new System.Windows.Forms.Button();
            this.btn_TreEmMuon = new System.Windows.Forms.Button();
            this.btn_QuaHan = new System.Windows.Forms.Button();
            this.btn_DangMuon = new System.Windows.Forms.Button();
            this.btn_LuongDA = new System.Windows.Forms.Button();
            this.btn_LuongPB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BaiCuoi
            // 
            this.btn_BaiCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaiCuoi.Location = new System.Drawing.Point(701, 296);
            this.btn_BaiCuoi.Name = "btn_BaiCuoi";
            this.btn_BaiCuoi.Size = new System.Drawing.Size(277, 246);
            this.btn_BaiCuoi.TabIndex = 24;
            this.btn_BaiCuoi.Text = "Inline Table-Valued Functions và Multistatement Table-Valued";
            this.btn_BaiCuoi.UseVisualStyleBackColor = true;
            this.btn_BaiCuoi.Click += new System.EventHandler(this.btn_BaiCuoi_Click);
            // 
            // btn_TreEmMuon
            // 
            this.btn_TreEmMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TreEmMuon.Location = new System.Drawing.Point(350, 296);
            this.btn_TreEmMuon.Name = "btn_TreEmMuon";
            this.btn_TreEmMuon.Size = new System.Drawing.Size(277, 246);
            this.btn_TreEmMuon.TabIndex = 23;
            this.btn_TreEmMuon.Text = "Tổng số dự án của mỗi phòng ban";
            this.btn_TreEmMuon.UseVisualStyleBackColor = true;
            this.btn_TreEmMuon.Click += new System.EventHandler(this.btn_TreEmMuon_Click);
            // 
            // btn_QuaHan
            // 
            this.btn_QuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuaHan.Location = new System.Drawing.Point(27, 296);
            this.btn_QuaHan.Name = "btn_QuaHan";
            this.btn_QuaHan.Size = new System.Drawing.Size(277, 246);
            this.btn_QuaHan.TabIndex = 22;
            this.btn_QuaHan.Text = "Tổng tiền thưởng của nhân viên dựa trên số giờ tham gia vào các dự án";
            this.btn_QuaHan.UseVisualStyleBackColor = true;
            this.btn_QuaHan.Click += new System.EventHandler(this.btn_QuaHan_Click);
            // 
            // btn_DangMuon
            // 
            this.btn_DangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangMuon.Location = new System.Drawing.Point(701, 16);
            this.btn_DangMuon.Name = "btn_DangMuon";
            this.btn_DangMuon.Size = new System.Drawing.Size(277, 246);
            this.btn_DangMuon.TabIndex = 21;
            this.btn_DangMuon.Text = "Tổng lương trung bình các phòng ban";
            this.btn_DangMuon.UseVisualStyleBackColor = true;
            this.btn_DangMuon.Click += new System.EventHandler(this.btn_DangMuon_Click);
            // 
            // btn_LuongDA
            // 
            this.btn_LuongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuongDA.Location = new System.Drawing.Point(350, 16);
            this.btn_LuongDA.Name = "btn_LuongDA";
            this.btn_LuongDA.Size = new System.Drawing.Size(277, 246);
            this.btn_LuongDA.TabIndex = 20;
            this.btn_LuongDA.Text = "Lương của nhân viên theo dự án";
            this.btn_LuongDA.UseVisualStyleBackColor = true;
            this.btn_LuongDA.Click += new System.EventHandler(this.btn_LuongDA_Click);
            // 
            // btn_LuongPB
            // 
            this.btn_LuongPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuongPB.Location = new System.Drawing.Point(27, 16);
            this.btn_LuongPB.Name = "btn_LuongPB";
            this.btn_LuongPB.Size = new System.Drawing.Size(277, 246);
            this.btn_LuongPB.TabIndex = 19;
            this.btn_LuongPB.Text = "Tiền lương trung bình của phòng ban";
            this.btn_LuongPB.UseVisualStyleBackColor = true;
            this.btn_LuongPB.Click += new System.EventHandler(this.btn_LuongPB_Click);
            // 
            // Bai_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 554);
            this.Controls.Add(this.btn_BaiCuoi);
            this.Controls.Add(this.btn_TreEmMuon);
            this.Controls.Add(this.btn_QuaHan);
            this.Controls.Add(this.btn_DangMuon);
            this.Controls.Add(this.btn_LuongDA);
            this.Controls.Add(this.btn_LuongPB);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai_7";
            this.Text = "Bai_7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BaiCuoi;
        private System.Windows.Forms.Button btn_TreEmMuon;
        private System.Windows.Forms.Button btn_QuaHan;
        private System.Windows.Forms.Button btn_DangMuon;
        private System.Windows.Forms.Button btn_LuongDA;
        private System.Windows.Forms.Button btn_LuongPB;
    }
}