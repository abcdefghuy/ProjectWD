namespace WindowsFormsApp2
{
    partial class UCActiviti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCActiviti));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tienthanhtoan = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_chitiet = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(10, 210);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 15);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đánh giá:";
            // 
            // lbl_tienthanhtoan
            // 
            this.lbl_tienthanhtoan.AutoSize = true;
            this.lbl_tienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tienthanhtoan.Location = new System.Drawing.Point(10, 153);
            this.lbl_tienthanhtoan.Name = "lbl_tienthanhtoan";
            this.lbl_tienthanhtoan.Size = new System.Drawing.Size(112, 15);
            this.lbl_tienthanhtoan.TabIndex = 12;
            this.lbl_tienthanhtoan.Text = "Tiền đã thanh toán:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(10, 127);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 15);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Họ tên:";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(65, 178);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(120, 27);
            this.rating.TabIndex = 16;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.Location = new System.Drawing.Point(10, 236);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(65, 15);
            this.lbl_trangthai.TabIndex = 14;
            this.lbl_trangthai.Text = "Trạng thái:";
            // 
            // ptb_avt
            // 
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(28, 7);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(126, 117);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 15;
            this.ptb_avt.TabStop = false;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chitiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chitiet.ForeColor = System.Drawing.Color.White;
            this.btn_chitiet.Location = new System.Drawing.Point(38, 268);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(107, 36);
            this.btn_chitiet.TabIndex = 17;
            this.btn_chitiet.Text = "Chi tiet";
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // UCActiviti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tienthanhtoan);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.lbl_trangthai);
            this.Name = "UCActiviti";
            this.Size = new System.Drawing.Size(194, 307);
            this.Load += new System.EventHandler(this.UCActiviti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tienthanhtoan;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_avt;
        private System.Windows.Forms.Label lbl_trangthai;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btn_chitiet;
    }
}
