namespace WindowsFormsApp2
{
    partial class UCWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorker));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblRating = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_tiencong = new System.Windows.Forms.Label();
            this.lbl_kinhnghiem = new System.Windows.Forms.Label();
            this.btn_chitiet = new Guna.UI2.WinForms.Guna2Button();
            this.txb_mota = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("UTM Alberta Heavy", 10F);
            this.lblRating.Location = new System.Drawing.Point(196, 194);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(82, 23);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "Đánh giá:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("UTM Alberta Heavy", 10F);
            this.lblName.Location = new System.Drawing.Point(196, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("UTM Alberta Heavy", 10F);
            this.lblPhone.Location = new System.Drawing.Point(196, 73);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(116, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(285, 186);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(160, 34);
            this.rating.TabIndex = 7;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(4, 4);
            this.ptb_avt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(168, 144);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 6;
            this.ptb_avt.TabStop = false;
            // 
            // lbl_tiencong
            // 
            this.lbl_tiencong.AutoSize = true;
            this.lbl_tiencong.Font = new System.Drawing.Font("UTM Alberta Heavy", 10F);
            this.lbl_tiencong.Location = new System.Drawing.Point(196, 150);
            this.lbl_tiencong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tiencong.Name = "lbl_tiencong";
            this.lbl_tiencong.Size = new System.Drawing.Size(88, 23);
            this.lbl_tiencong.TabIndex = 5;
            this.lbl_tiencong.Text = "Tiền Công";
            // 
            // lbl_kinhnghiem
            // 
            this.lbl_kinhnghiem.AutoSize = true;
            this.lbl_kinhnghiem.Font = new System.Drawing.Font("UTM Alberta Heavy", 10F);
            this.lbl_kinhnghiem.Location = new System.Drawing.Point(196, 112);
            this.lbl_kinhnghiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kinhnghiem.Name = "lbl_kinhnghiem";
            this.lbl_kinhnghiem.Size = new System.Drawing.Size(109, 23);
            this.lbl_kinhnghiem.TabIndex = 5;
            this.lbl_kinhnghiem.Text = "Kinh Nghiệm";
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.BorderRadius = 10;
            this.btn_chitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chitiet.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.ForeColor = System.Drawing.Color.White;
            this.btn_chitiet.Location = new System.Drawing.Point(17, 176);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(143, 44);
            this.btn_chitiet.TabIndex = 18;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // txb_mota
            // 
            this.txb_mota.BackColor = System.Drawing.Color.White;
            this.txb_mota.BorderRadius = 10;
            this.txb_mota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_mota.DefaultText = "";
            this.txb_mota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_mota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_mota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mota.FillColor = System.Drawing.Color.Gainsboro;
            this.txb_mota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mota.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_mota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mota.Location = new System.Drawing.Point(17, 238);
            this.txb_mota.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_mota.Multiline = true;
            this.txb_mota.Name = "txb_mota";
            this.txb_mota.PasswordChar = '\0';
            this.txb_mota.PlaceholderText = "";
            this.txb_mota.ReadOnly = true;
            this.txb_mota.SelectedText = "";
            this.txb_mota.Size = new System.Drawing.Size(428, 197);
            this.txb_mota.TabIndex = 19;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txb_mota);
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lbl_kinhnghiem);
            this.Controls.Add(this.lbl_tiencong);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCWorker";
            this.Size = new System.Drawing.Size(464, 445);
            this.Load += new System.EventHandler(this.UCWorker_Load);
            this.Click += new System.EventHandler(this.UCWorker_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_avt;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private System.Windows.Forms.Label lbl_kinhnghiem;
        private System.Windows.Forms.Label lbl_tiencong;
        private Guna.UI2.WinForms.Guna2Button btn_chitiet;
        private Guna.UI2.WinForms.Guna2TextBox txb_mota;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}
