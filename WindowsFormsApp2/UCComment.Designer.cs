﻿namespace WindowsFormsApp2
{
    partial class UCComment
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
            this.txb_danhgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lbl_name = new System.Windows.Forms.Label();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_anh = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Congviec = new System.Windows.Forms.Label();
            this.lbl_ngaylamviec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_danhgia
            // 
            this.txb_danhgia.Animated = true;
            this.txb_danhgia.BorderRadius = 15;
            this.txb_danhgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_danhgia.DefaultText = "";
            this.txb_danhgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_danhgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_danhgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.FillColor = System.Drawing.Color.Gainsboro;
            this.txb_danhgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F);
            this.txb_danhgia.ForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Location = new System.Drawing.Point(64, 68);
            this.txb_danhgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_danhgia.Multiline = true;
            this.txb_danhgia.Name = "txb_danhgia";
            this.txb_danhgia.PasswordChar = '\0';
            this.txb_danhgia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.PlaceholderText = "";
            this.txb_danhgia.ReadOnly = true;
            this.txb_danhgia.SelectedText = "";
            this.txb_danhgia.Size = new System.Drawing.Size(651, 113);
            this.txb_danhgia.TabIndex = 26;
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(64, 34);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(116, 26);
            this.rating.TabIndex = 25;
            this.rating.Value = 5F;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(64, 11);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 20);
            this.lbl_name.TabIndex = 24;
            this.lbl_name.Text = "Họ Tên";
            // 
            // ptb_avt
            // 
            this.ptb_avt.BackColor = System.Drawing.Color.Transparent;
            this.ptb_avt.FillColor = System.Drawing.SystemColors.Control;
            this.ptb_avt.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(4, 4);
            this.ptb_avt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb_avt.Size = new System.Drawing.Size(52, 44);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 27;
            this.ptb_avt.TabStop = false;
            this.ptb_avt.UseTransparentBackground = true;
            // 
            // panel_anh
            // 
            this.panel_anh.Location = new System.Drawing.Point(68, 188);
            this.panel_anh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_anh.Name = "panel_anh";
            this.panel_anh.Size = new System.Drawing.Size(647, 204);
            this.panel_anh.TabIndex = 28;
            // 
            // lbl_Congviec
            // 
            this.lbl_Congviec.AutoSize = true;
            this.lbl_Congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Congviec.Location = new System.Drawing.Point(296, 11);
            this.lbl_Congviec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Congviec.Name = "lbl_Congviec";
            this.lbl_Congviec.Size = new System.Drawing.Size(58, 17);
            this.lbl_Congviec.TabIndex = 30;
            this.lbl_Congviec.Text = "congviec";
            // 
            // lbl_ngaylamviec
            // 
            this.lbl_ngaylamviec.AutoSize = true;
            this.lbl_ngaylamviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaylamviec.Location = new System.Drawing.Point(296, 34);
            this.lbl_ngaylamviec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngaylamviec.Name = "lbl_ngaylamviec";
            this.lbl_ngaylamviec.Size = new System.Drawing.Size(80, 17);
            this.lbl_ngaylamviec.TabIndex = 30;
            this.lbl_ngaylamviec.Text = "ngaylamviec";
            // 
            // UCComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lbl_ngaylamviec);
            this.Controls.Add(this.lbl_Congviec);
            this.Controls.Add(this.panel_anh);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.txb_danhgia);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCComment";
            this.Size = new System.Drawing.Size(780, 423);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txb_danhgia;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptb_avt;
        private System.Windows.Forms.FlowLayoutPanel panel_anh;
        private System.Windows.Forms.Label lbl_Congviec;
        private System.Windows.Forms.Label lbl_ngaylamviec;
    }
}
