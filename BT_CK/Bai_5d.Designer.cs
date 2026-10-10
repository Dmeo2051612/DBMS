namespace BT_CK
{
    partial class Bai_5d
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
            this.dgv_DocGia = new System.Windows.Forms.DataGridView();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.MA_DOCGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DocGia
            // 
            this.dgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_DOCGIA,
            this.HOTEN,
            this.NGAYSINH});
            this.dgv_DocGia.Location = new System.Drawing.Point(12, 149);
            this.dgv_DocGia.Name = "dgv_DocGia";
            this.dgv_DocGia.RowHeadersWidth = 51;
            this.dgv_DocGia.RowTemplate.Height = 24;
            this.dgv_DocGia.Size = new System.Drawing.Size(1076, 458);
            this.dgv_DocGia.TabIndex = 17;
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(902, 32);
            this.btn_Solve.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(165, 89);
            this.btn_Solve.TabIndex = 16;
            this.btn_Solve.Text = "Tra cứu";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(306, 12);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(260, 128);
            this.btn_Dong.TabIndex = 15;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(24, 12);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(260, 128);
            this.btn_Mo.TabIndex = 14;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // MA_DOCGIA
            // 
            this.MA_DOCGIA.DataPropertyName = "MA_DOCGIA";
            this.MA_DOCGIA.HeaderText = "Mã độc giả";
            this.MA_DOCGIA.MinimumWidth = 6;
            this.MA_DOCGIA.Name = "MA_DOCGIA";
            this.MA_DOCGIA.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 125;
            // 
            // Bai_5d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.dgv_DocGia);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_5d";
            this.Text = "Bai_5d";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DocGia;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DOCGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
    }
}