namespace BarCodeGenerator
{
    partial class ShirtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShirtForm));
            this.generate = new System.Windows.Forms.Button();
            this.BarCoder = new System.Windows.Forms.Label();
            this.textBox_NumberOfCodes = new System.Windows.Forms.TextBox();
            this.textBox_Random = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Catagory = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.calendarClock1 = new CalendarClock.CalendarClock();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(133, 510);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(248, 51);
            this.generate.TabIndex = 18;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // BarCoder
            // 
            this.BarCoder.AutoSize = true;
            this.BarCoder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(62)))));
            this.BarCoder.Location = new System.Drawing.Point(116, 18);
            this.BarCoder.Name = "BarCoder";
            this.BarCoder.Size = new System.Drawing.Size(257, 30);
            this.BarCoder.TabIndex = 3;
            this.BarCoder.Text = "BarCode With Small Detail";
            // 
            // textBox_NumberOfCodes
            // 
            this.textBox_NumberOfCodes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberOfCodes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_NumberOfCodes.Location = new System.Drawing.Point(3, 43);
            this.textBox_NumberOfCodes.Name = "textBox_NumberOfCodes";
            this.textBox_NumberOfCodes.Size = new System.Drawing.Size(245, 39);
            this.textBox_NumberOfCodes.TabIndex = 5;
            this.textBox_NumberOfCodes.Text = "Amount";
            this.textBox_NumberOfCodes.Enter += new System.EventHandler(this.textBox_NumberOfCodes_Enter);
            this.textBox_NumberOfCodes.Leave += new System.EventHandler(this.textBox_NumberOfCodes_Leave);
            // 
            // textBox_Random
            // 
            this.textBox_Random.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Random.Location = new System.Drawing.Point(3, 223);
            this.textBox_Random.Name = "textBox_Random";
            this.textBox_Random.Size = new System.Drawing.Size(245, 39);
            this.textBox_Random.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox_NumberOfCodes);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Catagory);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Price);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Name);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Random);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 289);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // textBox_Catagory
            // 
            this.textBox_Catagory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Catagory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Catagory.Location = new System.Drawing.Point(3, 88);
            this.textBox_Catagory.Name = "textBox_Catagory";
            this.textBox_Catagory.Size = new System.Drawing.Size(245, 39);
            this.textBox_Catagory.TabIndex = 6;
            this.textBox_Catagory.Text = "Catagory";
            this.textBox_Catagory.Enter += new System.EventHandler(this.textBox_Catagory_Enter);
            this.textBox_Catagory.Leave += new System.EventHandler(this.textBox_Catagory_Leave);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Price.Location = new System.Drawing.Point(3, 133);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(245, 39);
            this.textBox_Price.TabIndex = 7;
            this.textBox_Price.Text = "Price";
            this.textBox_Price.Enter += new System.EventHandler(this.textBox_Price_Enter);
            this.textBox_Price.Leave += new System.EventHandler(this.textBox_Price_Leave);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Name.Location = new System.Drawing.Point(3, 178);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(245, 39);
            this.textBox_Name.TabIndex = 8;
            this.textBox_Name.Text = "Brand Name";
            this.textBox_Name.Enter += new System.EventHandler(this.textBox_Name_Enter);
            this.textBox_Name.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // calendarClock1
            // 
            this.calendarClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.calendarClock1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarClock1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendarClock1.Location = new System.Drawing.Point(288, 188);
            this.calendarClock1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calendarClock1.Name = "calendarClock1";
            this.calendarClock1.Size = new System.Drawing.Size(195, 296);
            this.calendarClock1.TabIndex = 21;
            // 
            // button_Power
            // 
            this.button_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Power.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_power;
            this.button_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_Power.Location = new System.Drawing.Point(464, 2);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(32, 32);
            this.button_Power.TabIndex = 22;
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click_1);
            // 
            // button_home
            // 
            this.button_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_home.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_home;
            this.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_home.Location = new System.Drawing.Point(434, 2);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(32, 32);
            this.button_home.TabIndex = 23;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BarCoder);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 131);
            this.panel1.TabIndex = 24;
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 0);
            this.panel2.TabIndex = 20;
            // 
            // ShirtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(498, 566);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.calendarClock1);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShirtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShirtForm";
            this.Load += new System.EventHandler(this.ShirtForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label BarCoder;
        private System.Windows.Forms.TextBox textBox_NumberOfCodes;
        private System.Windows.Forms.TextBox textBox_Random;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Catagory;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Name;
        private CalendarClock.CalendarClock calendarClock1;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;

    }
}