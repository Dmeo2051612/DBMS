namespace BT_CK
{
    partial class Bai_6_1
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
            this.btn_Mo = new System.Windows.Forms.Button();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Cs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(777, 34);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(111, 83);
            this.btn_Mo.TabIndex = 0;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // btn_Muon
            // 
            this.btn_Muon.Location = new System.Drawing.Point(777, 333);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(111, 83);
            this.btn_Muon.TabIndex = 3;
            this.btn_Muon.Text = "Kiểm tra bảng mượn";
            this.btn_Muon.UseVisualStyleBackColor = true;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(777, 235);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 83);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(747, 510);
            this.dgv.TabIndex = 22;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(777, 134);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(111, 83);
            this.btn_Dong.TabIndex = 23;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Cs
            // 
            this.btn_Cs.Location = new System.Drawing.Point(777, 439);
            this.btn_Cs.Name = "btn_Cs";
            this.btn_Cs.Size = new System.Drawing.Size(111, 83);
            this.btn_Cs.TabIndex = 24;
            this.btn_Cs.Text = "Kiểm tra bảng cuốn sách";
            this.btn_Cs.UseVisualStyleBackColor = true;
            this.btn_Cs.Click += new System.EventHandler(this.btn_Cs_Click);
            // 
            // Bai_6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btn_Cs);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Muon);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai_6_1";
            this.Text = "Bai_6_1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Cs;
    }
}