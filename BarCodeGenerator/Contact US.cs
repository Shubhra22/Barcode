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
    public partial class Contact_US : Form
    {
        public Contact_US()
        {
            InitializeComponent();
            ThemeManager mngr = new ThemeManager();
            mngr.ApplyFormThemeSizable(this);
        }

        void ShowPosition()
        {
            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("https://www.google.com.bd/maps/search/Appstick/@22.8116561,89.5646244,21z/data=!4m7!2m6!3m5!1sAppstick!2s22.8117,+89.5647!4m2!1d89.564721!2d22.8116848?hl=en");
                mapBrowser.Navigate(queryAddress.ToString());
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Contact_US_Load(object sender, EventArgs e)
        {
            ShowPosition();
        }
    }
}
