namespace WindowsFormsApp2
{
    partial class PostDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelPage1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_viewWorker = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_anh = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Diachi = new System.Windows.Forms.Label();
            this.lbl_Congviec = new System.Windows.Forms.Label();
            this.txb_danhgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panelPage2 = new Guna.UI2.WinForms.Guna2Panel();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.panelPage2);
            this.panelPage1.Controls.Add(this.btn_viewWorker);
            this.panelPage1.Controls.Add(this.btnBack);
            this.panelPage1.Controls.Add(this.guna2Button2);
            this.panelPage1.Controls.Add(this.guna2Button1);
            this.panelPage1.Controls.Add(this.panel_anh);
            this.panelPage1.Controls.Add(this.lbl_Diachi);
            this.panelPage1.Controls.Add(this.lbl_Congviec);
            this.panelPage1.Controls.Add(this.ptb_avt);
            this.panelPage1.Controls.Add(this.txb_danhgia);
            this.panelPage1.Controls.Add(this.lbl_name);
            this.panelPage1.Location = new System.Drawing.Point(13, 13);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(595, 758);
            this.panelPage1.TabIndex = 0;
            // 
            // btn_viewWorker
            // 
            this.btn_viewWorker.Animated = true;
            this.btn_viewWorker.AutoRoundedCorners = true;
            this.btn_viewWorker.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewWorker.BorderRadius = 21;
            this.btn_viewWorker.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.right_arrow;
            this.btn_viewWorker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewWorker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewWorker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewWorker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewWorker.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_viewWorker.Font = new System.Drawing.Font("UTM Alberta Heavy", 8.25F);
            this.btn_viewWorker.ForeColor = System.Drawing.Color.Black;
            this.btn_viewWorker.Location = new System.Drawing.Point(427, 3);
            this.btn_viewWorker.Name = "btn_viewWorker";
            this.btn_viewWorker.Size = new System.Drawing.Size(165, 45);
            this.btn_viewWorker.TabIndex = 57;
            this.btn_viewWorker.Text = "Xem Thợ Quan Tâm";
            this.btn_viewWorker.UseTransparentBackground = true;
            this.btn_viewWorker.Click += new System.EventHandler(this.btn_viewWorker_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(402, 688);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 55;
            this.guna2Button2.Text = "Chỉnh Sửa";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(37, 688);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Xóa bài";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // panel_anh
            // 
            this.panel_anh.BackColor = System.Drawing.Color.Transparent;
            this.panel_anh.Location = new System.Drawing.Point(24, 317);
            this.panel_anh.Name = "panel_anh";
            this.panel_anh.Size = new System.Drawing.Size(558, 138);
            this.panel_anh.TabIndex = 53;
            // 
            // lbl_Diachi
            // 
            this.lbl_Diachi.AutoSize = true;
            this.lbl_Diachi.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Diachi.Location = new System.Drawing.Point(258, 83);
            this.lbl_Diachi.Name = "lbl_Diachi";
            this.lbl_Diachi.Size = new System.Drawing.Size(51, 17);
            this.lbl_Diachi.TabIndex = 51;
            this.lbl_Diachi.Text = "Dia Chi";
            // 
            // lbl_Congviec
            // 
            this.lbl_Congviec.AutoSize = true;
            this.lbl_Congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Congviec.Location = new System.Drawing.Point(258, 39);
            this.lbl_Congviec.Name = "lbl_Congviec";
            this.lbl_Congviec.Size = new System.Drawing.Size(58, 17);
            this.lbl_Congviec.TabIndex = 52;
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
            this.txb_danhgia.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.txb_danhgia.ForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Location = new System.Drawing.Point(24, 118);
            this.txb_danhgia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txb_danhgia.Multiline = true;
            this.txb_danhgia.Name = "txb_danhgia";
            this.txb_danhgia.PasswordChar = '\0';
            this.txb_danhgia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.PlaceholderText = "";
            this.txb_danhgia.ReadOnly = true;
            this.txb_danhgia.SelectedText = "";
            this.txb_danhgia.Size = new System.Drawing.Size(558, 171);
            this.txb_danhgia.TabIndex = 49;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(34, 83);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 16);
            this.lbl_name.TabIndex = 48;
            this.lbl_name.Text = "Họ Tên";
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.btnBack2);
            this.panelPage2.Controls.Add(this.flContainer);
            this.panelPage2.Location = new System.Drawing.Point(0, 0);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(596, 758);
            this.panelPage2.TabIndex = 58;
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.Location = new System.Drawing.Point(3, 83);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(589, 675);
            this.flContainer.TabIndex = 0;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Transparent;
            this.btnBack2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack2.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack2.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack2.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack2.ImageRotate = 0F;
            this.btnBack2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack2.Location = new System.Drawing.Point(3, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack2.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack2.Size = new System.Drawing.Size(41, 45);
            this.btnBack2.TabIndex = 57;
            this.btnBack2.UseTransparentBackground = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(41, 45);
            this.btnBack.TabIndex = 56;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ptb_avt
            // 
            this.ptb_avt.BackColor = System.Drawing.Color.Transparent;
            this.ptb_avt.FillColor = System.Drawing.SystemColors.Control;
            this.ptb_avt.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(37, 39);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb_avt.Size = new System.Drawing.Size(39, 36);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 50;
            this.ptb_avt.TabStop = false;
            this.ptb_avt.UseTransparentBackground = true;
            // 
            // PostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 783);
            this.Controls.Add(this.panelPage1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostDetailForm";
            this.Load += new System.EventHandler(this.PostDetailForm_Load);
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage1;
        private Guna.UI2.WinForms.Guna2Panel panelPage2;
        private Guna.UI2.WinForms.Guna2Button btn_viewWorker;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel panel_anh;
        private System.Windows.Forms.Label lbl_Diachi;
        private System.Windows.Forms.Label lbl_Congviec;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2TextBox txb_danhgia;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack2;
    }
}