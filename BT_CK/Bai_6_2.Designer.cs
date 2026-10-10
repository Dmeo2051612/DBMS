namespace BT_CK
{
    partial class Bai_6_2
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
            this.btn_Cs = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Mo = new System.Windows.Forms.Button();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maCS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maDG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_muon = new System.Windows.Forms.DateTimePicker();
            this.dtp_tra = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cs
            // 
            this.btn_Cs.Location = new System.Drawing.Point(880, 465);
            this.btn_Cs.Name = "btn_Cs";
            this.btn_Cs.Size = new System.Drawing.Size(111, 83);
            this.btn_Cs.TabIndex = 30;
            this.btn_Cs.Text = "Kiểm tra bảng cuốn sách";
            this.btn_Cs.UseVisualStyleBackColor = true;
            this.btn_Cs.Click += new System.EventHandler(this.btn_Cs_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(880, 160);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(111, 83);
            this.btn_Dong.TabIndex = 29;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 96);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(850, 440);
            this.dgv.TabIndex = 28;
            // 
            // btn_Muon
            // 
            this.btn_Muon.Location = new System.Drawing.Point(880, 359);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(111, 83);
            this.btn_Muon.TabIndex = 27;
            this.btn_Muon.Text = "Kiểm tra bảng mượn";
            this.btn_Muon.UseVisualStyleBackColor = true;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(880, 261);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 83);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Mo
            // 
            this.btn_Mo.Location = new System.Drawing.Point(880, 60);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(111, 83);
            this.btn_Mo.TabIndex = 25;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(89, 7);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(140, 28);
            this.txt_ISBN.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "ISBN:";
            // 
            // txt_maCS
            // 
            this.txt_maCS.Location = new System.Drawing.Point(457, 7);
            this.txt_maCS.Name = "txt_maCS";
            this.txt_maCS.Size = new System.Drawing.Size(140, 28);
            this.txt_maCS.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã cuốn sách:";
            // 
            // txt_maDG
            // 
            this.txt_maDG.Location = new System.Drawing.Point(784, 11);
            this.txt_maDG.Name = "txt_maDG";
            this.txt_maDG.Size = new System.Drawing.Size(140, 28);
            this.txt_maDG.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã độc giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ngày trả:";
            // 
            // dtp_muon
            // 
            this.dtp_muon.Location = new System.Drawing.Point(138, 62);
            this.dtp_muon.Name = "dtp_muon";
            this.dtp_muon.Size = new System.Drawing.Size(301, 28);
            this.dtp_muon.TabIndex = 43;
            // 
            // dtp_tra
            // 
            this.dtp_tra.Location = new System.Drawing.Point(573, 63);
            this.dtp_tra.Name = "dtp_tra";
            this.dtp_tra.Size = new System.Drawing.Size(301, 28);
            this.dtp_tra.TabIndex = 44;
            // 
            // Bai_6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dtp_tra);
            this.Controls.Add(this.dtp_muon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cs);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Muon);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Mo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai_6_2";
            this.Text = "Bai_6_2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cs;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Mo;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maCS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_muon;
        private System.Windows.Forms.DateTimePicker dtp_tra;
    }
}