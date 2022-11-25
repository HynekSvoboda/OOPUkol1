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
            try
            {
                DateTime datum1 = Convert.ToDateTime(maskedTextBox1.Text);
                DateTime datum2 = Convert.ToDateTime(maskedTextBox2.Text);
                Clovek clovek1 = new Clovek(jmeno1, datum1);
                Clovek clovek2 = new Clovek(jmeno2, datum2);
                label5.Text = clovek1.ToString();
                label6.Text = clovek2.ToString();
                label7.Text = clovek2.Starsi(clovek1);
            }
            catch
            {
                MessageBox.Show("Na něco jsi zapomněl");
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte program, který bude mít 4 TextBoxy. Do kterých bude zadávat jméno a\r\ndatum narození dvou lidí. Vytvořte třídu Clovek, soukromý atribut jméno, narozen,\r\nkonstruktor bude nastavovat jméno a datum narození. Vytvořte metodu NastavJmeno a\r\nVypisJmeno. Vytvořte metodu Vek, která bude vracet věk člověka, metodu Plnolety, která\r\nbude vracet bool a metodu Starsi, kde parametrem bude druhý člověk a metoda bude vracet\r\nstring, kdo je starší. Dále bude obsahovat přetíženou metodu ToString, která vrátí větu např:\r\n„Petr má 10 let a není plnoletý“. Založte dvě instance třídy a vypište. Změňte jméno druhého\r\nčlověka a vypište jeho jméno. Zjistěte, kdo je starší.");
        }
    }
}
