namespace Azkar_Al_Muslm.FORMS
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_About = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Setting = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Home = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LBL_TimeNow = new System.Windows.Forms.Label();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.TM_TimeNow = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(169)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN_About);
            this.panel1.Controls.Add(this.BTN_Setting);
            this.panel1.Controls.Add(this.BTN_Home);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 105);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azkar_Al_Muslm.Properties.Resources.LogoBig;
            this.pictureBox1.Location = new System.Drawing.Point(1288, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_About
            // 
            this.BTN_About.Animated = true;
            this.BTN_About.AnimatedGIF = true;
            this.BTN_About.BackColor = System.Drawing.Color.Transparent;
            this.BTN_About.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_About.BorderRadius = 10;
            this.BTN_About.BorderThickness = 3;
            this.BTN_About.CustomizableEdges.BottomLeft = false;
            this.BTN_About.CustomizableEdges.TopRight = false;
            this.BTN_About.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_About.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_About.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_About.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_About.FillColor = System.Drawing.Color.Transparent;
            this.BTN_About.Font = new System.Drawing.Font("El Messiri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(214)))), ((int)(((byte)(112)))));
            this.BTN_About.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(210)))));
            this.BTN_About.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_About.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_About.HoverState.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_About_50px;
            this.BTN_About.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_About_50px_2;
            this.BTN_About.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_About.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_About.Location = new System.Drawing.Point(269, 26);
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(298, 52);
            this.BTN_About.TabIndex = 2;
            this.BTN_About.Text = "حول التطبيق";
            this.BTN_About.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // BTN_Setting
            // 
            this.BTN_Setting.Animated = true;
            this.BTN_Setting.AnimatedGIF = true;
            this.BTN_Setting.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Setting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_Setting.BorderRadius = 10;
            this.BTN_Setting.BorderThickness = 3;
            this.BTN_Setting.CustomizableEdges.BottomLeft = false;
            this.BTN_Setting.CustomizableEdges.TopRight = false;
            this.BTN_Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Setting.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Setting.Font = new System.Drawing.Font("El Messiri", 13.2F, System.Drawing.FontStyle.Bold);
            this.BTN_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(214)))), ((int)(((byte)(112)))));
            this.BTN_Setting.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(210)))));
            this.BTN_Setting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_Setting.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Setting.HoverState.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_administrative_tools_50px_1;
            this.BTN_Setting.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Setting.Image")));
            this.BTN_Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Setting.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Setting.Location = new System.Drawing.Point(613, 26);
            this.BTN_Setting.Name = "BTN_Setting";
            this.BTN_Setting.Size = new System.Drawing.Size(298, 52);
            this.BTN_Setting.TabIndex = 1;
            this.BTN_Setting.Text = "الاعدادات";
            this.BTN_Setting.Click += new System.EventHandler(this.BTN_Setting_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.Animated = true;
            this.BTN_Home.AnimatedGIF = true;
            this.BTN_Home.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Home.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_Home.BorderRadius = 10;
            this.BTN_Home.BorderThickness = 3;
            this.BTN_Home.CustomizableEdges.BottomLeft = false;
            this.BTN_Home.CustomizableEdges.TopRight = false;
            this.BTN_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Home.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Home.Font = new System.Drawing.Font("El Messiri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(214)))), ((int)(((byte)(112)))));
            this.BTN_Home.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(210)))));
            this.BTN_Home.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.BTN_Home.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_home_50px;
            this.BTN_Home.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_home_50px_1;
            this.BTN_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Home.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Home.Location = new System.Drawing.Point(950, 26);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(298, 52);
            this.BTN_Home.TabIndex = 0;
            this.BTN_Home.Text = "الرئيسية";
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.LBL_TimeNow);
            this.guna2Panel1.Controls.Add(this.LBL_Date);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 9);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 90);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LBL_TimeNow
            // 
            this.LBL_TimeNow.Font = new System.Drawing.Font("Cascadia Code", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeNow.ForeColor = System.Drawing.Color.Goldenrod;
            this.LBL_TimeNow.Location = new System.Drawing.Point(53, 47);
            this.LBL_TimeNow.Name = "LBL_TimeNow";
            this.LBL_TimeNow.Size = new System.Drawing.Size(168, 36);
            this.LBL_TimeNow.TabIndex = 5;
            this.LBL_TimeNow.Text = "Time";
            this.LBL_TimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Date
            // 
            this.LBL_Date.Font = new System.Drawing.Font("Cascadia Code", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Date.ForeColor = System.Drawing.Color.Goldenrod;
            this.LBL_Date.Location = new System.Drawing.Point(53, 6);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(168, 36);
            this.LBL_Date.TabIndex = 4;
            this.LBL_Date.Text = "5\\2\\2002";
            this.LBL_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1431, 572);
            this.panelContainer.TabIndex = 1;
            // 
            // TM_TimeNow
            // 
            this.TM_TimeNow.Enabled = true;
            this.TM_TimeNow.Tick += new System.EventHandler(this.TM_TimeNow_Tick);
            // 
            // Form_Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(210)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 677);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("El Messiri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Azkar_Al_Muslm.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1433, 717);
            this.MinimumSize = new System.Drawing.Size(1433, 717);
            this.Name = "Form_Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BTN_About;
        private Guna.UI2.WinForms.Guna2Button BTN_Setting;
        private Guna.UI2.WinForms.Guna2Button BTN_Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Date;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Timer TM_TimeNow;
        private System.Windows.Forms.Label LBL_TimeNow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panelContainer;
    }
}