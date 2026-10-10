namespace BT_CK
{
    partial class Bai_6_4
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_thongbao = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(858, 188);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(134, 90);
            this.btn_Dong.TabIndex = 61;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(858, 296);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(138, 81);
            this.btn_Sua.TabIndex = 58;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(854, 84);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(138, 89);
            this.btn_Mo.TabIndex = 57;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 84);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(832, 466);
            this.dgv.TabIndex = 62;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick_1);
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Location = new System.Drawing.Point(784, 25);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(140, 28);
            this.txt_tacgia.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tác giả: ";
            // 
            // txt_tenTS
            // 
            this.txt_tenTS.Location = new System.Drawing.Point(457, 21);
            this.txt_tenTS.Name = "txt_tenTS";
            this.txt_tenTS.Size = new System.Drawing.Size(140, 28);
            this.txt_tenTS.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên tựa sách:";
            // 
            // txt_maTS
            // 
            this.txt_maTS.Location = new System.Drawing.Point(125, 21);
            this.txt_maTS.Name = "txt_maTS";
            this.txt_maTS.Size = new System.Drawing.Size(140, 28);
            this.txt_maTS.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã tựa sách: ";
            // 
            // lbl_thongbao
            // 
            this.lbl_thongbao.AutoSize = true;
            this.lbl_thongbao.Location = new System.Drawing.Point(854, 509);
            this.lbl_thongbao.Name = "lbl_thongbao";
            this.lbl_thongbao.Size = new System.Drawing.Size(0, 20);
            this.lbl_thongbao.TabIndex = 69;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(858, 400);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(138, 81);
            this.btn_Them.TabIndex = 70;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Bai_6_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_thongbao);
            this.Controls.Add(this.txt_tacgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai_6_4";
            this.Text = "Bai_6_4";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_thongbao;
        private System.Windows.Forms.Button btn_Them;
    }
}