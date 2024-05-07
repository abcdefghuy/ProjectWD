﻿namespace WindowsFormsApp2
{
    partial class UCHistoryWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistoryWorker));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_tienthanhtoan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.btn_chitiet = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 146);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Họ tên:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_tienthanhtoan
            // 
            this.lbl_tienthanhtoan.AutoSize = true;
            this.lbl_tienthanhtoan.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tienthanhtoan.Location = new System.Drawing.Point(12, 178);
            this.lbl_tienthanhtoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tienthanhtoan.Name = "lbl_tienthanhtoan";
            this.lbl_tienthanhtoan.Size = new System.Drawing.Size(137, 20);
            this.lbl_tienthanhtoan.TabIndex = 0;
            this.lbl_tienthanhtoan.Text = "Tiền đã thanh toán:";
            this.lbl_tienthanhtoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đánh giá:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(12, 249);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 20);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Ngày:";
            this.lbl_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(86, 209);
            this.rating.Margin = new System.Windows.Forms.Padding(4);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(160, 33);
            this.rating.TabIndex = 2;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(45, -1);
            this.ptb_avt.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(168, 144);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 1;
            this.ptb_avt.TabStop = false;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.Location = new System.Drawing.Point(12, 281);
            this.lbl_trangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(81, 20);
            this.lbl_trangthai.TabIndex = 0;
            this.lbl_trangthai.Text = "Trạng thái:";
            this.lbl_trangthai.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.Animated = true;
            this.btn_chitiet.AutoRoundedCorners = true;
            this.btn_chitiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_chitiet.BorderRadius = 21;
            this.btn_chitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chitiet.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F);
            this.btn_chitiet.ForeColor = System.Drawing.Color.White;
            this.btn_chitiet.Location = new System.Drawing.Point(58, 314);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.ShadowDecoration.BorderRadius = 20;
            this.btn_chitiet.ShadowDecoration.Enabled = true;
            this.btn_chitiet.Size = new System.Drawing.Size(143, 44);
            this.btn_chitiet.TabIndex = 18;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // UCHistoryWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.lbl_trangthai);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tienthanhtoan);
            this.Controls.Add(this.lbl_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHistoryWorker";
            this.Size = new System.Drawing.Size(259, 369);
            this.Click += new System.EventHandler(this.UCHistoryWorker_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_tienthanhtoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_date;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private System.Windows.Forms.Label lbl_trangthai;
        private Guna.UI2.WinForms.Guna2Button btn_chitiet;
    }
}
