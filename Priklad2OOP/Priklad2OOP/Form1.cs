using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad2OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string jmeno1 = textBox1.Text;
            string jmeno2 = textBox3.Text;
            DateTime datum1 =DateTime.Parse(maskedTextBox1.Text);
            DateTime datum2 = DateTime.Parse(maskedTextBox1.Text);
            Clovek osoba1 = new Clovek(jmeno1, datum1);
            osoba1.Vek(datum1);
            osoba1.Plnolety();
            osoba1.ToString();
        }

    }
}
