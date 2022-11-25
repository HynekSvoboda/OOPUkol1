using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad2OOP
{
    class Clovek
    {
        string jmeno;
        int vek;
        DateTime narozeni;

        public Clovek()
        {
            jmeno = "Default";
            narozeni = DateTime.Now;
        }
        public Clovek(string jmeno, DateTime vek)
        {
            this.jmeno = jmeno;
            narozeni= vek;
        }
        public void NastavJmeno(string jmeno)
        {
             this.jmeno = jmeno;
        }
        public string VypisJmeno(string jmeno)
        {
            return this.jmeno=jmeno;
        }
        public int Vek(DateTime vek)
        {
            TimeSpan rozdil =  DateTime.Now-narozeni;
            double roky = rozdil.TotalDays;
            roky /= 365.25;
            this.vek=Convert.ToInt32(roky);
            return this.vek;
        }
        public bool Plnolety()
        {
            if (Vek(narozeni)>=18)
            {
                return true;
            }
            else return false;
        }
        public void Starsi(string jmeno2,DateTime datum2)
        {
            TimeSpan rozdil = DateTime.Now - datum2;
            double roky = rozdil.TotalDays;
            roky /= 365.25;
            int staric2 = Convert.ToInt32(roky);
            if(staric2>vek)
            {
                MessageBox.Show( "Starsi je: " + jmeno2);
            }
            else MessageBox.Show( "Starsi je: "+jmeno);
        }
        public override string ToString()
        {
            if (vek > 18)
            {
                MessageBox.Show(jmeno + " a má: " + vek.ToString() + " a je plnoletý/á");
                return jmeno + " a má: " + vek.ToString() + " a je plnoletý/á";
            }
            else
            {
                MessageBox.Show(jmeno + " a má: " + vek.ToString() + " a není plnoletý/á");
                return jmeno + " a má: " + vek.ToString() + " a není plnoletý/á";
            }
        }
    }
}
