namespace BT_CK
{
    partial class Bai_10_2b
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
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Mo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traCuu.Location = new System.Drawing.Point(780, 392);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(6);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.Size = new System.Drawing.Size(127, 114);
            this.btn_traCuu.TabIndex = 73;
            this.btn_traCuu.Text = "Tra cứu";
            this.btn_traCuu.UseVisualStyleBackColor = true;
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(780, 214);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(127, 114);
            this.btn_Dong.TabIndex = 72;
            this.btn_Dong.Text = "Đóng kết nối";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 27);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(759, 479);
            this.dgv.TabIndex = 71;
            // 
            // btn_Mo
            // 
            this.btn_Mo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mo.Location = new System.Drawing.Point(780, 41);
            this.btn_Mo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Mo.Name = "btn_Mo";
            this.btn_Mo.Size = new System.Drawing.Size(127, 114);
            this.btn_Mo.TabIndex = 70;
            this.btn_Mo.Text = "Mở kết nối";
            this.btn_Mo.UseVisualStyleBackColor = true;
            this.btn_Mo.Click += new System.EventHandler(this.btn_Mo_Click);
            // 
            // Bai_10_2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.btn_traCuu);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Mo);
            this.Name = "Bai_10_2b";
            this.Text = "Bai_10_2b";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Mo;
    }
}