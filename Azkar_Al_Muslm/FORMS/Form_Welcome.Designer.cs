namespace Azkar_Al_Muslm
{
    partial class Form_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WE_Progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.TM_Prograss = new System.Windows.Forms.Timer(this.components);
            this.TM_Text = new System.Windows.Forms.Timer(this.components);
            this.LB_astghfar = new System.Windows.Forms.Label();
            this.BTN_Cont = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(169)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 265);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("El Messiri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(248, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "تطبيق اذكار المسلم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WE_Progressbar
            // 
            this.WE_Progressbar.animated = true;
            this.WE_Progressbar.animationIterval = 5;
            this.WE_Progressbar.animationSpeed = 10;
            this.WE_Progressbar.BackColor = System.Drawing.Color.Transparent;
            this.WE_Progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WE_Progressbar.BackgroundImage")));
            this.WE_Progressbar.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WE_Progressbar.ForeColor = System.Drawing.Color.Goldenrod;
            this.WE_Progressbar.LabelVisible = true;
            this.WE_Progressbar.LineProgressThickness = 10;
            this.WE_Progressbar.LineThickness = 10;
            this.WE_Progressbar.Location = new System.Drawing.Point(235, 281);
            this.WE_Progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.WE_Progressbar.MaxValue = 100;
            this.WE_Progressbar.Name = "WE_Progressbar";
            this.WE_Progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.WE_Progressbar.ProgressColor = System.Drawing.Color.Goldenrod;
            this.WE_Progressbar.Size = new System.Drawing.Size(210, 210);
            this.WE_Progressbar.TabIndex = 3;
            this.WE_Progressbar.UseWaitCursor = true;
            this.WE_Progressbar.Value = 50;
            // 
            // TM_Prograss
            // 
            this.TM_Prograss.Enabled = true;
            this.TM_Prograss.Interval = 50;
            this.TM_Prograss.Tick += new System.EventHandler(this.TM_Prograss_Tick);
            // 
            // TM_Text
            // 
            this.TM_Text.Enabled = true;
            this.TM_Text.Interval = 75;
            this.TM_Text.Tick += new System.EventHandler(this.TM_Text_Tick);
            // 
            // LB_astghfar
            // 
            this.LB_astghfar.AutoSize = true;
            this.LB_astghfar.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_astghfar.ForeColor = System.Drawing.Color.Goldenrod;
            this.LB_astghfar.Location = new System.Drawing.Point(219, 513);
            this.LB_astghfar.Name = "LB_astghfar";
            this.LB_astghfar.Size = new System.Drawing.Size(242, 36);
            this.LB_astghfar.TabIndex = 1;
            this.LB_astghfar.Text = "استغفر الله العظيم . . . ";
            // 
            // BTN_Cont
            // 
            this.BTN_Cont.Animated = true;
            this.BTN_Cont.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(169)))), ((int)(((byte)(20)))));
            this.BTN_Cont.BorderRadius = 5;
            this.BTN_Cont.BorderThickness = 2;
            this.BTN_Cont.CustomizableEdges.BottomLeft = false;
            this.BTN_Cont.CustomizableEdges.TopRight = false;
            this.BTN_Cont.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Cont.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Cont.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Cont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Cont.FillColor = System.Drawing.Color.Goldenrod;
            this.BTN_Cont.Font = new System.Drawing.Font("El Messiri", 12F);
            this.BTN_Cont.ForeColor = System.Drawing.Color.White;
            this.BTN_Cont.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_Back_Arrow_50px_1;
            this.BTN_Cont.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Cont.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Cont.Location = new System.Drawing.Point(225, 596);
            this.BTN_Cont.Name = "BTN_Cont";
            this.BTN_Cont.Size = new System.Drawing.Size(219, 49);
            this.BTN_Cont.TabIndex = 4;
            this.BTN_Cont.Text = "متابعة ";
            this.BTN_Cont.Click += new System.EventHandler(this.BTN_Cont_Click);
            // 
            // Form_Welcome
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(210)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(672, 703);
            this.Controls.Add(this.BTN_Cont);
            this.Controls.Add(this.LB_astghfar);
            this.Controls.Add(this.WE_Progressbar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::Azkar_Al_Muslm.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(674, 743);
            this.MinimumSize = new System.Drawing.Size(674, 743);
            this.Name = "Form_Welcome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اذكار المسلم";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar WE_Progressbar;
        private System.Windows.Forms.Timer TM_Prograss;
        private System.Windows.Forms.Timer TM_Text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_astghfar;
        private Guna.UI2.WinForms.Guna2Button BTN_Cont;
    }
}

