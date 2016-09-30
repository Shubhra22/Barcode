using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xthemecore_macos;

namespace BarCodeGenerator
{
    public partial class MainForm : Form
    {
        int widthCount = 0;
        int height, width;

        Point startSlidePos;

        public MainForm()
        {
            InitializeComponent();
            startSlidePos = panel_Side.Location;
            height = SystemInformation.VirtualScreen.Height;
            width = SystemInformation.VirtualScreen.Width;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            tm.Enabled = true;
        }

        private void tm_Tick(object sender, EventArgs e)
        {    
                   
            if(widthCount > 6 || widthCount < 0)
            {
                tm.Enabled = false;
                //panel_OverLaySide.Visible = true;
            }
            else
            {
                widthCount++; 
                Point p = new Point();
                p.X = panel_Side.Location.X;
                p.X -= 12;
                panel_Side.Location = p;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calendarClock1_Load(object sender, EventArgs e)
        {

        }


        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Y.ToString());
            //if (e.Y <= height - 15 && e.X > (width - panel_Side.Width))
            //{
            //    tm.Enabled = true;
               
            //}
            
            
        }

        private void button_BCodeWithTag_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
            //this.WindowState = FormWindowState.Minimized;
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExitSecomdary_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ContactUs_Click(object sender, EventArgs e)
        {
            Contact_US cus = new Contact_US();
            cus.Show();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       public void ChangeEnabled(bool enabled, Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c.Name == "button_Minimize" || c.Name == "button_Power" || c.Name == "calendarClock1")
                    continue;
                c.Enabled = enabled;
                
            }
        }

       private void button_QuickMode_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Under Development");
       }

       private void button_Catagoried_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Under Development");
       }
        

       private void button_Shirt_Click(object sender, EventArgs e)
       {
           ShirtForm m = new ShirtForm();
           m.Show();
           this.Hide();
       }

       private void button_Pant_Click(object sender, EventArgs e)
       {
           Main m = new Main();
           m.Show();
           this.Hide();
       }
    }
}
