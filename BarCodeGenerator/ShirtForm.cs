using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDAutomation.NetAssembly;
using CrystalDecisions.CrystalReports.Engine;
namespace BarCodeGenerator
{
    public partial class ShirtForm : Form
    {
        FontEncoder fe = new FontEncoder();
        DataTable dtaTbl;
        RandomNumber rnd;
        ReportDocument cry = new ReportDocument();
        BarcodeGeneration bcd = new BarcodeGeneration();
        public ShirtForm()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Convert.ToInt32(textBox_NumberOfCodes.Text); i++)
                {
                    rnd = new RandomNumber();
                    textBox_Random.Text = textBox_Name.Text + rnd.GenerateRandom() + DateTime.Now.Day + DateTime.Now.Month;
                    string encodeData = fe.Code39(textBox_Random.Text);
                    // MessageBox.Show(encodedData);
                    dtaTbl.Rows.Add(encodeData, textBox_Catagory.Text, textBox_Price.Text + " BDT");

                    cry.Load(@"C:\BarCodes\BarCodesShirt.rpt");
                    cry.SetDataSource(dtaTbl);
                    bcd.crystalRptview.ReportSource = cry;

                }
                bcd.Show();
            }
            catch 
            {
                MessageBox.Show("Please Retry by closing this window");
            }
            
            //MessageBox.Show(textBox_Name.Text + " " + textBox_NumberOfCodes.Text + " " + textBox_Price.Text);
        }

        public ReportDocument doc
        {
            get
            {
                return cry;
            }
        }
        private void PrintBarcode_Load(object sender, EventArgs e)
        {
            dtaTbl = new DataTable();
            dtaTbl.TableName = "BarcodeDataset";
            dtaTbl.Columns.Add("Number", typeof(string));
            dtaTbl.Columns.Add("Catagory", typeof(string));
            dtaTbl.Columns.Add("Price", typeof(string));
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button_Cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button_Power_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_home_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void ShirtForm_Load(object sender, EventArgs e)
        {
            dtaTbl = new DataTable();
            dtaTbl.TableName = "BarcodeDataset";
            dtaTbl.Columns.Add("Number", typeof(string));
            dtaTbl.Columns.Add("Catagory", typeof(string));
            dtaTbl.Columns.Add("Price", typeof(string));
        }

        private void textBox_NumberOfCodes_Enter(object sender, EventArgs e)
        {
            if (textBox_NumberOfCodes.Text == "Amount")
            {
                textBox_NumberOfCodes.Text = "";
                textBox_NumberOfCodes.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_NumberOfCodes_Leave(object sender, EventArgs e)
        {
            if (textBox_NumberOfCodes.Text.Length == 0)
            {
                textBox_NumberOfCodes.Text = "Amount";
                textBox_NumberOfCodes.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox_Catagory_Enter(object sender, EventArgs e)
        {
            textBox_Catagory.Text = "";
            textBox_Catagory.ForeColor = SystemColors.WindowText;
        }

        private void textBox_Catagory_Leave(object sender, EventArgs e)
        {
            if (textBox_Catagory.Text == "")
            {
                textBox_Catagory.Text = "Catagory";
                textBox_Catagory.ForeColor = SystemColors.GrayText;
            }

        }

        private void textBox_Price_Enter(object sender, EventArgs e)
        {
            textBox_Price.Text = "";
            textBox_Price.ForeColor = SystemColors.WindowText;
        }

        private void textBox_Price_Leave(object sender, EventArgs e)
        {
            if (textBox_Price.Text == "")
            {
                textBox_Price.Text = "Price";
                textBox_Price.ForeColor = SystemColors.GrayText;
            }

        }

        private void textBox_Name_Enter(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            textBox_Name.ForeColor = SystemColors.WindowText;
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                textBox_Name.Text = "Brand Name";
                textBox_Name.ForeColor = SystemColors.GrayText;
            }

        }
    }
}
