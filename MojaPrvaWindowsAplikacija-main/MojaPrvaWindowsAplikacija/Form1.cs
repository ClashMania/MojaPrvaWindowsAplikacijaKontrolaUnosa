using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            int BrojA, BrojB, Zbroj;

            try
            {

                BrojA = Convert.ToInt32(txtUnosBrojaA.Text);
                BrojB = Convert.ToInt32(txtUnosBrojaB.Text);
                Zbroj = BrojB + BrojA;

                txtIzlazBrojaA.Text = Convert.ToString(Zbroj);

            }
            catch(Exception greska)
            {
                Greska.Text = "Neispravni upis \r\nGreška: " +greska.Message;
            }




        }

        private void Greska_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
