namespace BT_CK
{
    partial class Bai_5a
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
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DocGia
            // 
            this.dgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocGia.Location = new System.Drawing.Point(16, 152);
            this.dgv_DocGia.Name = "dgv_DocGia";
            this.dgv_DocGia.RowHeadersWidth = 51;
            this.dgv_DocGia.RowTemplate.Height = 24;
            this.dgv_DocGia.Size = new System.Drawing.Size(968, 393);
            this.dgv_DocGia.TabIndex = 18;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(402, 47);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(88, 51);
            this.btn_Tim.TabIndex = 17;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(198, 65);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(144, 27);
            this.txt_Ma.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập mã độc giả: ";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(836, 17);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(149, 114);
            this.btn_Dong.TabIndex = 14;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mo.Location = new System.Drawing.Point(651, 17);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(149, 114);
            this.btn_Mo.TabIndex = 13;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // Bai_5a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgv_DocGia);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_5a";
            this.Text = "Bai_5a";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DocGia;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
    }
}