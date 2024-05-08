namespace WindowsFormsApp2
{
    partial class PostForm
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
            this.panelPage = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.box_congViec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_filterDay = new Guna.UI2.WinForms.Guna2Button();
            this.end_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.date_lamviec = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.diaChiBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_image = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.chitiet_txb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CongViecBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_ngayLamViec = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelPage.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelPage
            // 
            this.panelPage.Controls.Add(this.btnAdd);
            this.panelPage.Controls.Add(this.flContainer);
            this.panelPage.Controls.Add(this.guna2ShadowPanel1);
            this.panelPage.Location = new System.Drawing.Point(12, 12);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1097, 691);
            this.panelPage.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 24;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(570, 611);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.BorderRadius = 25;
            this.btnAdd.ShadowDecoration.Enabled = true;
            this.btnAdd.Size = new System.Drawing.Size(176, 51);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm bài";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.flContainer.Location = new System.Drawing.Point(243, 4);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(851, 601);
            this.flContainer.TabIndex = 2;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.box_congViec);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator3);
            this.guna2ShadowPanel1.Controls.Add(this.btn_filterDay);
            this.guna2ShadowPanel1.Controls.Add(this.end_day);
            this.guna2ShadowPanel1.Controls.Add(this.start_day);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(233, 674);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Công Việc";
            // 
            // box_congViec
            // 
            this.box_congViec.AutoRoundedCorners = true;
            this.box_congViec.BackColor = System.Drawing.Color.Transparent;
            this.box_congViec.BorderRadius = 17;
            this.box_congViec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_congViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_congViec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_congViec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_congViec.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.box_congViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_congViec.ItemHeight = 30;
            this.box_congViec.Items.AddRange(new object[] {
            "ThoDien",
            "Dien Lanh",
            "Ong Nuoc",
            "Tho Moc",
            "Xay Dung"});
            this.box_congViec.Location = new System.Drawing.Point(19, 310);
            this.box_congViec.Name = "box_congViec";
            this.box_congViec.Size = new System.Drawing.Size(200, 36);
            this.box_congViec.TabIndex = 47;
            this.box_congViec.SelectedIndexChanged += new System.EventHandler(this.box_congViec_SelectedIndexChanged);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(19, 232);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 45;
            // 
            // btn_filterDay
            // 
            this.btn_filterDay.AutoRoundedCorners = true;
            this.btn_filterDay.BackColor = System.Drawing.Color.Transparent;
            this.btn_filterDay.BorderRadius = 16;
            this.btn_filterDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_filterDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_filterDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_filterDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_filterDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_filterDay.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filterDay.ForeColor = System.Drawing.Color.White;
            this.btn_filterDay.Location = new System.Drawing.Point(58, 179);
            this.btn_filterDay.Name = "btn_filterDay";
            this.btn_filterDay.ShadowDecoration.BorderRadius = 21;
            this.btn_filterDay.ShadowDecoration.Enabled = true;
            this.btn_filterDay.Size = new System.Drawing.Size(111, 34);
            this.btn_filterDay.TabIndex = 44;
            this.btn_filterDay.Text = "Áp dụng";
            this.btn_filterDay.Click += new System.EventHandler(this.btn_filterDay_Click);
            // 
            // end_day
            // 
            this.end_day.Animated = true;
            this.end_day.BorderRadius = 10;
            this.end_day.Checked = true;
            this.end_day.CustomFormat = "dd/MM/yyyy";
            this.end_day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.end_day.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_day.Location = new System.Drawing.Point(19, 113);
            this.end_day.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.end_day.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.end_day.Name = "end_day";
            this.end_day.Size = new System.Drawing.Size(200, 36);
            this.end_day.TabIndex = 43;
            this.end_day.Value = new System.DateTime(2024, 3, 10, 18, 35, 49, 58);
            // 
            // start_day
            // 
            this.start_day.Animated = true;
            this.start_day.BorderRadius = 10;
            this.start_day.Checked = true;
            this.start_day.CustomFormat = "dd/MM/yyyy";
            this.start_day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start_day.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_day.Location = new System.Drawing.Point(19, 44);
            this.start_day.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.start_day.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.start_day.Name = "start_day";
            this.start_day.Size = new System.Drawing.Size(200, 36);
            this.start_day.TabIndex = 42;
            this.start_day.Value = new System.DateTime(2024, 3, 10, 18, 35, 49, 58);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tới ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Từ ngày";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Controls.Add(this.date_lamviec);
            this.panelAdd.Controls.Add(this.diaChiBox);
            this.panelAdd.Controls.Add(this.panel_image);
            this.panelAdd.Controls.Add(this.btnBack);
            this.panelAdd.Controls.Add(this.chitiet_txb);
            this.panelAdd.Controls.Add(this.btnAddImage);
            this.panelAdd.Controls.Add(this.btn_Save);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.label9);
            this.panelAdd.Controls.Add(this.CongViecBox);
            this.panelAdd.Controls.Add(this.lbl_ngayLamViec);
            this.panelAdd.Controls.Add(this.label16);
            this.panelAdd.Location = new System.Drawing.Point(12, 12);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.ShadowDecoration.BorderRadius = 30;
            this.panelAdd.Size = new System.Drawing.Size(1097, 691);
            this.panelAdd.TabIndex = 4;
            // 
            // date_lamviec
            // 
            this.date_lamviec.Animated = true;
            this.date_lamviec.BackColor = System.Drawing.Color.Transparent;
            this.date_lamviec.BorderRadius = 10;
            this.date_lamviec.Checked = true;
            this.date_lamviec.CustomFormat = "dd/MM/yyyy";
            this.date_lamviec.FillColor = System.Drawing.Color.White;
            this.date_lamviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lamviec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_lamviec.Location = new System.Drawing.Point(516, 120);
            this.date_lamviec.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_lamviec.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_lamviec.Name = "date_lamviec";
            this.date_lamviec.Size = new System.Drawing.Size(289, 36);
            this.date_lamviec.TabIndex = 62;
            this.date_lamviec.UseTransparentBackground = true;
            this.date_lamviec.Value = new System.DateTime(2024, 3, 10, 15, 59, 56, 382);
            // 
            // diaChiBox
            // 
            this.diaChiBox.Animated = true;
            this.diaChiBox.BorderRadius = 15;
            this.diaChiBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diaChiBox.DefaultText = "";
            this.diaChiBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.diaChiBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.diaChiBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diaChiBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diaChiBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diaChiBox.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiBox.ForeColor = System.Drawing.Color.Black;
            this.diaChiBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diaChiBox.Location = new System.Drawing.Point(516, 163);
            this.diaChiBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diaChiBox.Name = "diaChiBox";
            this.diaChiBox.PasswordChar = '\0';
            this.diaChiBox.PlaceholderText = "";
            this.diaChiBox.SelectedText = "";
            this.diaChiBox.Size = new System.Drawing.Size(289, 43);
            this.diaChiBox.TabIndex = 59;
            // 
            // panel_image
            // 
            this.panel_image.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_image.Location = new System.Drawing.Point(279, 364);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(526, 162);
            this.panel_image.TabIndex = 61;
            // 
            // btnBack
            // 
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
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 60;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chitiet_txb
            // 
            this.chitiet_txb.Animated = true;
            this.chitiet_txb.BorderRadius = 15;
            this.chitiet_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chitiet_txb.DefaultText = "";
            this.chitiet_txb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chitiet_txb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chitiet_txb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chitiet_txb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chitiet_txb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chitiet_txb.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chitiet_txb.ForeColor = System.Drawing.Color.Black;
            this.chitiet_txb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chitiet_txb.Location = new System.Drawing.Point(516, 214);
            this.chitiet_txb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chitiet_txb.Multiline = true;
            this.chitiet_txb.Name = "chitiet_txb";
            this.chitiet_txb.PasswordChar = '\0';
            this.chitiet_txb.PlaceholderText = "";
            this.chitiet_txb.SelectedText = "";
            this.chitiet_txb.Size = new System.Drawing.Size(289, 121);
            this.chitiet_txb.TabIndex = 59;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Animated = true;
            this.btnAddImage.AutoRoundedCorners = true;
            this.btnAddImage.BackColor = System.Drawing.Color.Transparent;
            this.btnAddImage.BorderRadius = 21;
            this.btnAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImage.Font = new System.Drawing.Font("UTM Alexander", 10.8F);
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(279, 577);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.ShadowDecoration.BorderRadius = 25;
            this.btnAddImage.ShadowDecoration.Enabled = true;
            this.btnAddImage.Size = new System.Drawing.Size(180, 45);
            this.btnAddImage.TabIndex = 58;
            this.btnAddImage.Text = "Thêm ảnh";
            this.btnAddImage.UseTransparentBackground = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Animated = true;
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 21;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("UTM Alexander", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(625, 577);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.BorderRadius = 25;
            this.btn_Save.ShadowDecoration.Enabled = true;
            this.btn_Save.Size = new System.Drawing.Size(180, 45);
            this.btn_Save.TabIndex = 58;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseTransparentBackground = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Địa Chỉ";
            this.label2.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "Mô Tả Chi Tiết";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CongViecBox
            // 
            this.CongViecBox.AutoRoundedCorners = true;
            this.CongViecBox.BackColor = System.Drawing.Color.Transparent;
            this.CongViecBox.BorderRadius = 17;
            this.CongViecBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CongViecBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CongViecBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CongViecBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CongViecBox.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.2F);
            this.CongViecBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CongViecBox.ItemHeight = 30;
            this.CongViecBox.Items.AddRange(new object[] {
            "Thợ Điện",
            "Điện lạnh",
            "Ống nước",
            "Thợ mộc",
            "Xây dựng",
            "Thông tắc",
            "Vệ Sinh",
            "Sửa Nhà"});
            this.CongViecBox.Location = new System.Drawing.Point(516, 71);
            this.CongViecBox.Name = "CongViecBox";
            this.CongViecBox.Size = new System.Drawing.Size(289, 36);
            this.CongViecBox.TabIndex = 47;
            // 
            // lbl_ngayLamViec
            // 
            this.lbl_ngayLamViec.AutoSize = true;
            this.lbl_ngayLamViec.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayLamViec.Location = new System.Drawing.Point(276, 126);
            this.lbl_ngayLamViec.Name = "lbl_ngayLamViec";
            this.lbl_ngayLamViec.Size = new System.Drawing.Size(101, 18);
            this.lbl_ngayLamViec.TabIndex = 49;
            this.lbl_ngayLamViec.Text = "Ngày làm việc:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("UTM Alberta Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(276, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 18);
            this.label16.TabIndex = 49;
            this.label16.Text = "Công Việc";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.flContainer;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panelAdd;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 25;
            this.guna2Elipse4.TargetControl = this.panel_image;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1118, 715);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.panelPage.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Button btn_filterDay;
        private Guna.UI2.WinForms.Guna2DateTimePicker end_day;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox box_congViec;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel panelAdd;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2TextBox chitiet_txb;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox CongViecBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.FlowLayoutPanel panel_image;
        private Guna.UI2.WinForms.Guna2Button btnAddImage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2TextBox diaChiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ngayLamViec;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_lamviec;
    }
}