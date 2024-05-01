namespace WindowsFormsApp2
{
    partial class UCDayFree
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
            this.lblday = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_sukien = new System.Windows.Forms.Label();
            this.btn_datlich = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("UTM Alberta Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(17, 21);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(21, 14);
            this.lblday.TabIndex = 2;
            this.lblday.Text = "00";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // lbl_sukien
            // 
            this.lbl_sukien.AutoSize = true;
            this.lbl_sukien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sukien.Font = new System.Drawing.Font("UTM Alberta Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sukien.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_sukien.Location = new System.Drawing.Point(17, 48);
            this.lbl_sukien.Name = "lbl_sukien";
            this.lbl_sukien.Size = new System.Drawing.Size(110, 14);
            this.lbl_sukien.TabIndex = 3;
            this.lbl_sukien.Text = "Không có sự kiện nào";
            // 
            // btn_datlich
            // 
            this.btn_datlich.Animated = true;
            this.btn_datlich.AutoRoundedCorners = true;
            this.btn_datlich.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_datlich.BorderRadius = 16;
            this.btn_datlich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_datlich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_datlich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_datlich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_datlich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_datlich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_datlich.ForeColor = System.Drawing.Color.Black;
            this.btn_datlich.Location = new System.Drawing.Point(29, 76);
            this.btn_datlich.Name = "btn_datlich";
            this.btn_datlich.Size = new System.Drawing.Size(75, 34);
            this.btn_datlich.TabIndex = 4;
            this.btn_datlich.Text = "Dat lich";
            this.btn_datlich.Click += new System.EventHandler(this.btn_datlich_Click);
            // 
            // UCDayFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_datlich);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lbl_sukien);
            this.Name = "UCDayFree";
            this.Size = new System.Drawing.Size(144, 113);
            this.Load += new System.EventHandler(this.UCDayFree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblday;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_sukien;
        private Guna.UI2.WinForms.Guna2Button btn_datlich;
    }
}
