namespace BarCodeGenerator
{
    partial class BarcodeGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeGeneration));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button_home = new System.Windows.Forms.Button();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(999, 532);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button_home
            // 
            this.button_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_home.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_home;
            this.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_home.Location = new System.Drawing.Point(900, -1);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(32, 32);
            this.button_home.TabIndex = 18;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_Power
            // 
            this.button_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Power.BackgroundImage = global::BarCodeGenerator.Properties.Resources.appbar_power;
            this.button_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_Power.Location = new System.Drawing.Point(964, -1);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(32, 32);
            this.button_Power.TabIndex = 17;
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
            this.button_Minimize.Location = new System.Drawing.Point(932, -1);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(32, 32);
            this.button_Minimize.TabIndex = 19;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // BarcodeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.crystalReportViewer1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeGeneration";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_Minimize;
    }
}