namespace WindowsFormsApp2
{
    partial class UCWorkerYT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorkerYT));
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_diachi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(76, 228);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 13;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(46, 3);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(126, 117);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 12;
            this.ptb_avt.TabStop = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(14, 234);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 15);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Đánh giá:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(14, 168);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(82, 15);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Họ tên:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Location = new System.Drawing.Point(16, 195);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(180, 30);
            this.lbl_diachi.TabIndex = 14;
            this.lbl_diachi.Text = "Địa chỉ ";
            // 
            // UCWorkerYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "UCWorkerYT";
            this.Size = new System.Drawing.Size(210, 260);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_avt;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_diachi;
    }
}
