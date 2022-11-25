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
        DateTime narozen;

        public Clovek()
        {
            this.jmeno = "Default";
            this.narozen = DateTime.Now;
        }
        public Clovek(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = Convert.ToDateTime(narozen);
        }
        public void NastavJmeno(string jmeno)
        {
             this.jmeno = jmeno;
        }
        public string VypisJmeno()
        {
            return jmeno;
        }
        public int Vek()
        {
            TimeSpan rozdil =  DateTime.Now-narozen;
            double roky =(rozdil.TotalDays)/365.25;
            //MessageBox.Show(roky.ToString());
            return Convert.ToInt32(roky);
        }
        public bool Plnolety()
        {
            if (Vek()>=18) return true;
            else return false;
        }
        public string Starsi(Clovek clovek2)
        {
            if (this.Vek() < clovek2.Vek())
            {
                return "Starší je: " + clovek2.VypisJmeno();
            }
            else return "Starší je: " + this.VypisJmeno();
        }
        public override string ToString()
        {
            if(this.Plnolety())
            {
                return this.VypisJmeno() + " má " + this.Vek() + " a je plnoletý/á.";
            }
            else return this.VypisJmeno() + " má " + this.Vek() + " a není plnoletý/á.";
        }
    }
}
