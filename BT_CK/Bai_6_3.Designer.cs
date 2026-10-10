namespace BT_CK
{
    partial class Bai_6_3
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
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maCS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cs = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Ds = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(789, 18);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(140, 28);
            this.txt_trangthai.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Trạng thái:";
            // 
            // txt_maCS
            // 
            this.txt_maCS.Location = new System.Drawing.Point(462, 14);
            this.txt_maCS.Name = "txt_maCS";
            this.txt_maCS.Size = new System.Drawing.Size(140, 28);
            this.txt_maCS.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã cuốn sách:";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(94, 14);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(140, 28);
            this.txt_ISBN.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "ISBN:";
            // 
            // btn_Cs
            // 
            this.btn_Cs.Location = new System.Drawing.Point(885, 472);
            this.btn_Cs.Name = "btn_Cs";
            this.btn_Cs.Size = new System.Drawing.Size(111, 83);
            this.btn_Cs.TabIndex = 50;
            this.btn_Cs.Text = "Kiểm tra bảng cuốn sách";
            this.btn_Cs.UseVisualStyleBackColor = true;
            this.btn_Cs.Click += new System.EventHandler(this.btn_Cs_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(885, 167);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(111, 83);
            this.btn_Dong.TabIndex = 49;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 103);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(850, 440);
            this.dgv.TabIndex = 48;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_Ds
            // 
            this.btn_Ds.Location = new System.Drawing.Point(885, 366);
            this.btn_Ds.Name = "btn_Ds";
            this.btn_Ds.Size = new System.Drawing.Size(111, 83);
            this.btn_Ds.TabIndex = 47;
            this.btn_Ds.Text = "Kiểm tra bảng đầu sách";
            this.btn_Ds.UseVisualStyleBackColor = true;
            this.btn_Ds.Click += new System.EventHandler(this.btn_Ds_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(885, 268);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 83);
            this.btn_Sua.TabIndex = 46;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(885, 67);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(111, 83);
            this.btn_Mo.TabIndex = 45;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // Bai_6_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 568);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cs);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Ds);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai_6_3";
            this.Text = "Bai_6_3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maCS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cs;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Ds;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Mo;
    }
}