namespace WindowsFormsApp2
{
    partial class PostWorkerForm
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
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.box_congviec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_filterDay = new Guna.UI2.WinForms.Guna2Button();
            this.end_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelPage = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbtn_quantam = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 25;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.flContainer.Location = new System.Drawing.Point(243, 4);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(851, 673);
            this.flContainer.TabIndex = 2;
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
            // box_congviec
            // 
            this.box_congviec.AutoRoundedCorners = true;
            this.box_congviec.BackColor = System.Drawing.Color.Transparent;
            this.box_congviec.BorderRadius = 17;
            this.box_congviec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_congviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_congviec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_congviec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.box_congviec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_congviec.ItemHeight = 30;
            this.box_congviec.Items.AddRange(new object[] {
            "ThoDien",
            "Dien Lanh",
            "Ong Nuoc",
            "Tho Moc",
            "Xay Dung"});
            this.box_congviec.Location = new System.Drawing.Point(19, 310);
            this.box_congviec.Name = "box_congviec";
            this.box_congviec.Size = new System.Drawing.Size(200, 36);
            this.box_congviec.TabIndex = 47;
            this.box_congviec.SelectedIndexChanged += new System.EventHandler(this.box_congviec_SelectedIndexChanged);
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
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.cbtn_quantam);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.box_congviec);
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
            // panelPage
            // 
            this.panelPage.Controls.Add(this.flContainer);
            this.panelPage.Controls.Add(this.guna2ShadowPanel1);
            this.panelPage.Location = new System.Drawing.Point(11, 12);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1097, 691);
            this.panelPage.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.flContainer;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 25;
            // 
            // cbtn_quantam
            // 
            this.cbtn_quantam.AutoSize = true;
            this.cbtn_quantam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_quantam.CheckedState.BorderRadius = 0;
            this.cbtn_quantam.CheckedState.BorderThickness = 0;
            this.cbtn_quantam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_quantam.Location = new System.Drawing.Point(23, 364);
            this.cbtn_quantam.Name = "cbtn_quantam";
            this.cbtn_quantam.Size = new System.Drawing.Size(99, 17);
            this.cbtn_quantam.TabIndex = 49;
            this.cbtn_quantam.Text = "Đang quan tâm";
            this.cbtn_quantam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_quantam.UncheckedState.BorderRadius = 0;
            this.cbtn_quantam.UncheckedState.BorderThickness = 0;
            this.cbtn_quantam.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_quantam.CheckedChanged += new System.EventHandler(this.cbtn_quantam_CheckedChanged);
            // 
            // PostWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1118, 715);
            this.Controls.Add(this.panelPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostWorkerForm";
            this.Text = "PostWorkerForm";
            this.Load += new System.EventHandler(this.PostWorkerForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox box_congviec;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Button btn_filterDay;
        private Guna.UI2.WinForms.Guna2DateTimePicker end_day;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2CheckBox cbtn_quantam;
    }
}