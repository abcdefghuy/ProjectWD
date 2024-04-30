namespace WindowsFormsApp2
{
    partial class Activiti2Form
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
            this.lbl_congviec = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txbKhac = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_thanhtoan = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panelPage1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPage2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btnClose2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelPage1.SuspendLayout();
            this.panelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_congviec
            // 
            this.lbl_congviec.AutoSize = true;
            this.lbl_congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congviec.Location = new System.Drawing.Point(13, 89);
            this.lbl_congviec.Name = "lbl_congviec";
            this.lbl_congviec.Size = new System.Drawing.Size(99, 25);
            this.lbl_congviec.TabIndex = 42;
            this.lbl_congviec.Text = "Công việc:";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 21;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(37, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 45);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BorderRadius = 21;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(312, 296);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txbKhac
            // 
            this.txbKhac.Animated = true;
            this.txbKhac.BorderRadius = 10;
            this.txbKhac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbKhac.DefaultText = "";
            this.txbKhac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbKhac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbKhac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbKhac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbKhac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbKhac.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F);
            this.txbKhac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbKhac.Location = new System.Drawing.Point(37, 159);
            this.txbKhac.Multiline = true;
            this.txbKhac.Name = "txbKhac";
            this.txbKhac.PasswordChar = '\0';
            this.txbKhac.PlaceholderText = "";
            this.txbKhac.SelectedText = "";
            this.txbKhac.Size = new System.Drawing.Size(455, 131);
            this.txbKhac.TabIndex = 40;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoRoundedCorners = true;
            this.cbSelect.BackColor = System.Drawing.Color.Transparent;
            this.cbSelect.BorderRadius = 17;
            this.cbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelect.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelect.ItemHeight = 30;
            this.cbSelect.Items.AddRange(new object[] {
            "Thay đổi thời gian",
            "Thay đổi địa chỉ",
            "Thay đổi thợ",
            "Không có nhu cầu sử dụng dịch vụ",
            "Khác"});
            this.cbSelect.Location = new System.Drawing.Point(37, 63);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(455, 36);
            this.cbSelect.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Khác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lý do hủy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Đánh giá:";
            // 
            // lbl_thanhtoan
            // 
            this.lbl_thanhtoan.AutoSize = true;
            this.lbl_thanhtoan.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtoan.Location = new System.Drawing.Point(13, 133);
            this.lbl_thanhtoan.Name = "lbl_thanhtoan";
            this.lbl_thanhtoan.Size = new System.Drawing.Size(181, 25);
            this.lbl_thanhtoan.TabIndex = 39;
            this.lbl_thanhtoan.Text = "Tiền đã thanh toán:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(13, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 25);
            this.lbl_name.TabIndex = 40;
            this.lbl_name.Text = "Họ tên:";
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.AutoRoundedCorners = true;
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderRadius = 21;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(174, 296);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 45);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseTransparentBackground = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.White;
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(124, 225);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 41;
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.btnHuy);
            this.panelPage1.Controls.Add(this.rating);
            this.panelPage1.Controls.Add(this.lbl_date);
            this.panelPage1.Controls.Add(this.label3);
            this.panelPage1.Controls.Add(this.lbl_thanhtoan);
            this.panelPage1.Controls.Add(this.lbl_name);
            this.panelPage1.Controls.Add(this.lbl_congviec);
            this.panelPage1.Controls.Add(this.btnClose);
            this.panelPage1.Location = new System.Drawing.Point(12, 12);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(529, 347);
            this.panelPage1.TabIndex = 1;
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.btnBack);
            this.panelPage2.Controls.Add(this.btnConfirm);
            this.panelPage2.Controls.Add(this.txbKhac);
            this.panelPage2.Controls.Add(this.cbSelect);
            this.panelPage2.Controls.Add(this.label2);
            this.panelPage2.Controls.Add(this.label1);
            this.panelPage2.Controls.Add(this.btnClose2);
            this.panelPage2.Location = new System.Drawing.Point(9, 12);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(529, 347);
            this.panelPage2.TabIndex = 44;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(13, 179);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(61, 25);
            this.lbl_date.TabIndex = 37;
            this.lbl_date.Text = "Ngày:";
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Transparent;
            this.btnClose2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose2.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose2.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose2.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose2.ImageRotate = 0F;
            this.btnClose2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose2.IndicateFocus = true;
            this.btnClose2.Location = new System.Drawing.Point(494, 3);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose2.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose2.Size = new System.Drawing.Size(35, 36);
            this.btnClose2.TabIndex = 37;
            this.btnClose2.UseTransparentBackground = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(481, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 36;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Activiti2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 388);
            this.Controls.Add(this.panelPage2);
            this.Controls.Add(this.panelPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activiti2Form";
            this.Text = "Activiti2Form";
            this.Load += new System.EventHandler(this.Activiti2Form_Load);
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage1;
        private Guna.UI2.WinForms.Guna2Panel panelPage2;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txbKhac;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose2;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_thanhtoan;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_congviec;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}