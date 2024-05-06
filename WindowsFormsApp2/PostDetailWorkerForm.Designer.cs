namespace WindowsFormsApp2
{
    partial class PostDetailWorkerForm
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelPage1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel_anh = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Diachi = new System.Windows.Forms.Label();
            this.lbl_Congviec = new System.Windows.Forms.Label();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txb_danhgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panelPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.btnBack);
            this.panelPage1.Controls.Add(this.btnAdd);
            this.panelPage1.Controls.Add(this.panel_anh);
            this.panelPage1.Controls.Add(this.lbl_Diachi);
            this.panelPage1.Controls.Add(this.lbl_Congviec);
            this.panelPage1.Controls.Add(this.ptb_avt);
            this.panelPage1.Controls.Add(this.txb_danhgia);
            this.panelPage1.Controls.Add(this.lbl_name);
            this.panelPage1.Location = new System.Drawing.Point(12, 13);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(595, 758);
            this.panelPage1.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(207, 640);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Quan Tâm";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // PostDetailWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 783);
            this.Controls.Add(this.panelPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostDetailWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostDetailWorkerForm";
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage1;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel panel_anh;
        private System.Windows.Forms.Label lbl_Diachi;
        private System.Windows.Forms.Label lbl_Congviec;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2TextBox txb_danhgia;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}