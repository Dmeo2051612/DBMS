namespace BT_CK
{
    partial class Bai_7_6
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
            this.btn_Multi = new System.Windows.Forms.Button();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_Inline = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Multi
            // 
            this.btn_Multi.Location = new System.Drawing.Point(976, 424);
            this.btn_Multi.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(219, 122);
            this.btn_Multi.TabIndex = 55;
            this.btn_Multi.Text = "Multistatement Table-Valued";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(12, 12);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(953, 532);
            this.dgv_NhanVien.TabIndex = 54;
            // 
            // btn_Inline
            // 
            this.btn_Inline.Location = new System.Drawing.Point(976, 290);
            this.btn_Inline.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Inline.Name = "btn_Inline";
            this.btn_Inline.Size = new System.Drawing.Size(219, 122);
            this.btn_Inline.TabIndex = 53;
            this.btn_Inline.Text = " Inline Table-Valued";
            this.btn_Inline.UseVisualStyleBackColor = true;
            this.btn_Inline.Click += new System.EventHandler(this.btn_Inline_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(976, 137);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(219, 122);
            this.btn_Dong.TabIndex = 52;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(976, 3);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(219, 122);
            this.btn_Mo.TabIndex = 51;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // Bai_7_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 619);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.btn_Inline);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_7_6";
            this.Text = "Bai_7_6";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_Inline;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Mo;
    }
}