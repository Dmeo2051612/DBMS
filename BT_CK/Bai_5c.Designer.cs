namespace BT_CK
{
    partial class Bai_5c
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
            this.dgv_DocGia.Location = new System.Drawing.Point(2, 157);
            this.dgv_DocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DocGia.Name = "dgv_DocGia";
            this.dgv_DocGia.RowHeadersWidth = 51;
            this.dgv_DocGia.RowTemplate.Height = 24;
            this.dgv_DocGia.Size = new System.Drawing.Size(1095, 457);
            this.dgv_DocGia.TabIndex = 13;
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(915, 16);
            this.btn_Solve.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(182, 103);
            this.btn_Solve.TabIndex = 12;
            this.btn_Solve.Text = "Tra cứu";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(300, -2);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(286, 148);
            this.btn_Dong.TabIndex = 11;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(2, -2);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(286, 148);
            this.btn_Mo.TabIndex = 10;
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
            // Bai_5c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 618);
            this.Controls.Add(this.dgv_DocGia);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Bai_5c";
            this.Text = "Bai_5c";
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