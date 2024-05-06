namespace WindowsFormsApp2
{
    partial class FormCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancel));
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelPage2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.BackColor = System.Drawing.Color.White;
            this.flContainer.Location = new System.Drawing.Point(3, 61);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(590, 651);
            this.flContainer.TabIndex = 44;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.btnBack);
            this.panelPage2.Controls.Add(this.flContainer);
            this.panelPage2.Controls.Add(this.label5);
            this.panelPage2.Location = new System.Drawing.Point(4, -7);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(597, 759);
            this.panelPage2.TabIndex = 42;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 45;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Bình Luận";
            // 
            // FormCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 783);
            this.Controls.Add(this.panelPage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCancel";
            this.Load += new System.EventHandler(this.FormCancel_Load);
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelPage2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.Label label5;
    }
}