namespace WindowsFormsApp2
{
    partial class UCPost
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_Congviec = new System.Windows.Forms.Label();
            this.txb_danhgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_anh = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_Congviec
            // 
            this.lbl_Congviec.AutoSize = true;
            this.lbl_Congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Congviec.Location = new System.Drawing.Point(224, 17);
            this.lbl_Congviec.Name = "lbl_Congviec";
            this.lbl_Congviec.Size = new System.Drawing.Size(48, 14);
            this.lbl_Congviec.TabIndex = 36;
            this.lbl_Congviec.Text = "congviec";
            // 
            // txb_danhgia
            // 
            this.txb_danhgia.Animated = true;
            this.txb_danhgia.BackColor = System.Drawing.Color.Transparent;
            this.txb_danhgia.BorderRadius = 15;
            this.txb_danhgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_danhgia.DefaultText = "";
            this.txb_danhgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_danhgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_danhgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F);
            this.txb_danhgia.ForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Location = new System.Drawing.Point(6, 55);
            this.txb_danhgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_danhgia.Multiline = true;
            this.txb_danhgia.Name = "txb_danhgia";
            this.txb_danhgia.PasswordChar = '\0';
            this.txb_danhgia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.PlaceholderText = "";
            this.txb_danhgia.ReadOnly = true;
            this.txb_danhgia.SelectedText = "";
            this.txb_danhgia.Size = new System.Drawing.Size(399, 92);
            this.txb_danhgia.TabIndex = 33;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(66, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 16);
            this.lbl_name.TabIndex = 31;
            this.lbl_name.Text = "Họ Tên";
            // 
            // panel_anh
            // 
            this.panel_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_anh.Location = new System.Drawing.Point(9, 154);
            this.panel_anh.Name = "panel_anh";
            this.panel_anh.Size = new System.Drawing.Size(396, 124);
            this.panel_anh.TabIndex = 37;
            // 
            // btnDetail
            // 
            this.btnDetail.Animated = true;
            this.btnDetail.AutoRoundedCorners = true;
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BorderRadius = 21;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(119, 305);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.BorderRadius = 25;
            this.btnDetail.ShadowDecoration.Enabled = true;
            this.btnDetail.Size = new System.Drawing.Size(180, 45);
            this.btnDetail.TabIndex = 38;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.UseTransparentBackground = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ptb_avt
            // 
            this.ptb_avt.BackColor = System.Drawing.Color.Transparent;
            this.ptb_avt.FillColor = System.Drawing.SystemColors.Control;
            this.ptb_avt.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(21, 11);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb_avt.Size = new System.Drawing.Size(39, 36);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 34;
            this.ptb_avt.TabStop = false;
            this.ptb_avt.UseTransparentBackground = true;
            // 
            // UCPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panel_anh);
            this.Controls.Add(this.lbl_Congviec);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.txb_danhgia);
            this.Controls.Add(this.lbl_name);
            this.Name = "UCPost";
            this.Size = new System.Drawing.Size(411, 370);
            this.Load += new System.EventHandler(this.UCPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_Congviec;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2TextBox txb_danhgia;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private System.Windows.Forms.FlowLayoutPanel panel_anh;
    }
}
