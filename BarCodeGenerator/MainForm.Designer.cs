namespace BarCodeGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Shirt = new System.Windows.Forms.Button();
            this.button_Pant = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_ContactUs = new System.Windows.Forms.Button();
            this.calendarClock1 = new CalendarClock.CalendarClock();
            this.panel_Side = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonExitSecomdary = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_QuickMode = new System.Windows.Forms.Button();
            this.button_Catagoried = new System.Windows.Forms.Button();
            this.button_BCodeWithTag = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_Side.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Shirt);
            this.flowLayoutPanel1.Controls.Add(this.button_Pant);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button_ContactUs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(449, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 40, 20, 40);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 538);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_Shirt
            // 
            this.button_Shirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button_Shirt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Shirt.Image = global::BarCodeGenerator.Properties.Resources.appbar1;
            this.button_Shirt.Location = new System.Drawing.Point(23, 43);
            this.button_Shirt.Name = "button_Shirt";
            this.button_Shirt.Size = new System.Drawing.Size(156, 145);
            this.button_Shirt.TabIndex = 7;
            this.button_Shirt.UseVisualStyleBackColor = false;
            this.button_Shirt.Click += new System.EventHandler(this.button_Shirt_Click);
            // 
            // button_Pant
            // 
            this.button_Pant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Pant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Pant.Image = global::BarCodeGenerator.Properties.Resources.Trousers_Filled_50;
            this.button_Pant.Location = new System.Drawing.Point(185, 43);
            this.button_Pant.Name = "button_Pant";
            this.button_Pant.Size = new System.Drawing.Size(156, 145);
            this.button_Pant.TabIndex = 0;
            this.button_Pant.UseVisualStyleBackColor = false;
            this.button_Pant.Click += new System.EventHandler(this.button_Pant_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Image = global::BarCodeGenerator.Properties.Resources.Thumbnails_Filled_50;
            this.button6.Location = new System.Drawing.Point(23, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(318, 145);
            this.button6.TabIndex = 5;
            this.button6.Text = "Advanced";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BarCodeGenerator.Properties.Resources.Document_50;
            this.button2.Location = new System.Drawing.Point(23, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 145);
            this.button2.TabIndex = 6;
            this.button2.Text = "Documentation";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_ContactUs
            // 
            this.button_ContactUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.button_ContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ContactUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ContactUs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ContactUs.Image = global::BarCodeGenerator.Properties.Resources.Marker_Filled_50;
            this.button_ContactUs.Location = new System.Drawing.Point(185, 345);
            this.button_ContactUs.Name = "button_ContactUs";
            this.button_ContactUs.Size = new System.Drawing.Size(156, 145);
            this.button_ContactUs.TabIndex = 8;
            this.button_ContactUs.Text = "Contact Us";
            this.button_ContactUs.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_ContactUs.UseVisualStyleBackColor = false;
            this.button_ContactUs.Click += new System.EventHandler(this.button_ContactUs_Click);
            // 
            // calendarClock1
            // 
            this.calendarClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.calendarClock1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarClock1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendarClock1.Location = new System.Drawing.Point(823, 184);
            this.calendarClock1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calendarClock1.Name = "calendarClock1";
            this.calendarClock1.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.calendarClock1.Size = new System.Drawing.Size(195, 349);
            this.calendarClock1.TabIndex = 5;
            this.calendarClock1.Load += new System.EventHandler(this.calendarClock1_Load);
            // 
            // panel_Side
            // 
            this.panel_Side.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel_Side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel_Side.Controls.Add(this.button12);
            this.panel_Side.Controls.Add(this.buttonExitSecomdary);
            this.panel_Side.Controls.Add(this.button8);
            this.panel_Side.Location = new System.Drawing.Point(1128, 1);
            this.panel_Side.Name = "panel_Side";
            this.panel_Side.Size = new System.Drawing.Size(89, 737);
            this.panel_Side.TabIndex = 11;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button12.Image = global::BarCodeGenerator.Properties.Resources.appbar_home;
            this.button12.Location = new System.Drawing.Point(-5, 334);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(78, 79);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // buttonExitSecomdary
            // 
            this.buttonExitSecomdary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExitSecomdary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.buttonExitSecomdary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitSecomdary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.buttonExitSecomdary.Image = global::BarCodeGenerator.Properties.Resources.appbar_power;
            this.buttonExitSecomdary.Location = new System.Drawing.Point(-6, 438);
            this.buttonExitSecomdary.Name = "buttonExitSecomdary";
            this.buttonExitSecomdary.Size = new System.Drawing.Size(78, 79);
            this.buttonExitSecomdary.TabIndex = 12;
            this.buttonExitSecomdary.UseVisualStyleBackColor = false;
            this.buttonExitSecomdary.Click += new System.EventHandler(this.buttonExitSecomdary_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button8.Image = global::BarCodeGenerator.Properties.Resources.appbar_chevron_down;
            this.button8.Location = new System.Drawing.Point(-4, 231);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 79);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // tm
            // 
            this.tm.Interval = 50;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_QuickMode);
            this.flowLayoutPanel2.Controls.Add(this.button_Catagoried);
            this.flowLayoutPanel2.Controls.Add(this.button_BCodeWithTag);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(78, 180);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 40, 20, 40);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(365, 540);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // button_QuickMode
            // 
            this.button_QuickMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(186)))));
            this.button_QuickMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_QuickMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuickMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_QuickMode.Image = global::BarCodeGenerator.Properties.Resources.Exercise_Filled_100;
            this.button_QuickMode.Location = new System.Drawing.Point(23, 43);
            this.button_QuickMode.Name = "button_QuickMode";
            this.button_QuickMode.Size = new System.Drawing.Size(156, 145);
            this.button_QuickMode.TabIndex = 7;
            this.button_QuickMode.Text = "Quick Mode";
            this.button_QuickMode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_QuickMode.UseVisualStyleBackColor = false;
            this.button_QuickMode.Click += new System.EventHandler(this.button_QuickMode_Click);
            // 
            // button_Catagoried
            // 
            this.button_Catagoried.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Catagoried.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Catagoried.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Catagoried.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Catagoried.Image = global::BarCodeGenerator.Properties.Resources.Triforce_Filled_100;
            this.button_Catagoried.Location = new System.Drawing.Point(185, 43);
            this.button_Catagoried.Name = "button_Catagoried";
            this.button_Catagoried.Size = new System.Drawing.Size(156, 145);
            this.button_Catagoried.TabIndex = 0;
            this.button_Catagoried.Text = "Categorized";
            this.button_Catagoried.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Catagoried.UseVisualStyleBackColor = false;
            this.button_Catagoried.Click += new System.EventHandler(this.button_Catagoried_Click);
            // 
            // button_BCodeWithTag
            // 
            this.button_BCodeWithTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(147)))));
            this.button_BCodeWithTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BCodeWithTag.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BCodeWithTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_BCodeWithTag.Image = global::BarCodeGenerator.Properties.Resources.Scan_Stock_Filled_100;
            this.button_BCodeWithTag.Location = new System.Drawing.Point(23, 194);
            this.button_BCodeWithTag.Name = "button_BCodeWithTag";
            this.button_BCodeWithTag.Size = new System.Drawing.Size(318, 296);
            this.button_BCodeWithTag.TabIndex = 5;
            this.button_BCodeWithTag.Text = "Create With Detail";
            this.button_BCodeWithTag.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_BCodeWithTag.UseVisualStyleBackColor = false;
            this.button_BCodeWithTag.Click += new System.EventHandler(this.button_BCodeWithTag_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.calendarClock1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(75, 40, 50, 50);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1129, 736);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(78, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 131);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BarCodeGenerator.Properties.Resources.Barlogo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // button_Power
            // 
            this.button_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Power.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_power;
            this.button_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_Power.Location = new System.Drawing.Point(1084, 11);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(32, 32);
            this.button_Power.TabIndex = 14;
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_chevron_down;
            this.button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_Minimize.Location = new System.Drawing.Point(1046, 11);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(32, 32);
            this.button_Minimize.TabIndex = 16;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1129, 736);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.panel_Side);
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_Side.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Pant;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Shirt;
        private System.Windows.Forms.Button button_ContactUs;
        private CalendarClock.CalendarClock calendarClock1;
        private System.Windows.Forms.Panel panel_Side;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_QuickMode;
        private System.Windows.Forms.Button button_Catagoried;
        private System.Windows.Forms.Button button_BCodeWithTag;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonExitSecomdary;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Minimize;
    }
}