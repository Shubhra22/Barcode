using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Drawing.Printing;
namespace BarCodeGenerator
{
    public partial class BarcodeGeneration : Form
    {
        int x, y;
        public BarcodeGeneration()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public CrystalReportViewer crystalRptview 
        { 
            get
            {
                return crystalReportViewer1;
            }
            
        }
       

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
