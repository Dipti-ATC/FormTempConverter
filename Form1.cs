using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTempConverter
{
    public partial class TempConverter : Form
    {

        //instance of a class
        Conversion myConversion = new Conversion();

       
       
        public TempConverter()
        {
            InitializeComponent();
        }

        private void btnFahToCel_Click(object sender, EventArgs e)
        {
            txtCel.Text = myConversion.FahToCel(txtFah.Text);
        }

        private void btnCelToFah_Click(object sender, EventArgs e)
        {
            txtFah.Text = myConversion.CelToFah(txtCel.Text);
        }
    }
}
