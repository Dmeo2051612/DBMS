namespace BT_CK
{
    partial class Bai_3
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
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.dgv_ThongTin = new System.Windows.Forms.DataGridView();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_TUASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGONNGU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOMTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_SACH_CHUA_DUOC_MUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(875, 41);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(133, 85);
            this.btn_Dong.TabIndex = 11;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(705, 41);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(133, 85);
            this.btn_Mo.TabIndex = 10;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // dgv_ThongTin
            // 
            this.dgv_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.MA_TUASACH,
            this.NGONNGU,
            this.BIA,
            this.TRANGTHAI,
            this.TUASACH,
            this.TACGIA,
            this.TOMTAT,
            this.SL_SACH_CHUA_DUOC_MUON});
            this.dgv_ThongTin.Location = new System.Drawing.Point(107, 167);
            this.dgv_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ThongTin.Name = "dgv_ThongTin";
            this.dgv_ThongTin.RowHeadersWidth = 51;
            this.dgv_ThongTin.RowTemplate.Height = 24;
            this.dgv_ThongTin.Size = new System.Drawing.Size(901, 405);
            this.dgv_ThongTin.TabIndex = 9;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(520, 38);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(133, 85);
            this.btn_Tim.TabIndex = 8;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(242, 86);
            this.txt_ISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(132, 30);
            this.txt_ISBN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập ISBN:";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // MA_TUASACH
            // 
            this.MA_TUASACH.DataPropertyName = "MA_TUASACH";
            this.MA_TUASACH.HeaderText = "Mã tựa sách";
            this.MA_TUASACH.MinimumWidth = 6;
            this.MA_TUASACH.Name = "MA_TUASACH";
            this.MA_TUASACH.Width = 125;
            // 
            // NGONNGU
            // 
            this.NGONNGU.DataPropertyName = "NGONNGU";
            this.NGONNGU.HeaderText = "Ngôn ngữ";
            this.NGONNGU.MinimumWidth = 6;
            this.NGONNGU.Name = "NGONNGU";
            this.NGONNGU.Width = 125;
            // 
            // BIA
            // 
            this.BIA.DataPropertyName = "BIA";
            this.BIA.HeaderText = "Bìa";
            this.BIA.MinimumWidth = 6;
            this.BIA.Name = "BIA";
            this.BIA.Width = 125;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Width = 125;
            // 
            // TUASACH
            // 
            this.TUASACH.DataPropertyName = "TUASACH";
            this.TUASACH.HeaderText = "Tựa sách";
            this.TUASACH.MinimumWidth = 6;
            this.TUASACH.Name = "TUASACH";
            this.TUASACH.Width = 125;
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TACGIA";
            this.TACGIA.HeaderText = "Tác giả";
            this.TACGIA.MinimumWidth = 6;
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.Width = 125;
            // 
            // TOMTAT
            // 
            this.TOMTAT.DataPropertyName = "TOMTAT";
            this.TOMTAT.HeaderText = "Tóm tắt";
            this.TOMTAT.MinimumWidth = 6;
            this.TOMTAT.Name = "TOMTAT";
            this.TOMTAT.Width = 125;
            // 
            // SL_SACH_CHUA_DUOC_MUON
            // 
            this.SL_SACH_CHUA_DUOC_MUON.DataPropertyName = "SL_SACH_CHUA_DUOC_MUON";
            this.SL_SACH_CHUA_DUOC_MUON.HeaderText = "Số lượng sách chưa được mượn";
            this.SL_SACH_CHUA_DUOC_MUON.MinimumWidth = 6;
            this.SL_SACH_CHUA_DUOC_MUON.Name = "SL_SACH_CHUA_DUOC_MUON";
            this.SL_SACH_CHUA_DUOC_MUON.Width = 125;
            // 
            // Bai_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Controls.Add(this.dgv_ThongTin);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Bai_3";
            this.Text = "Bai_3cs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.DataGridView dgv_ThongTin;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_TUASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGONNGU;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOMTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_SACH_CHUA_DUOC_MUON;
    }
}