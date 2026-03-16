using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TanulokClassLibrary
{
    public class Tanulo
    {
        public string Nev { get; private set; }
        public int Pontszam { get; private set; }
        public int MaximalisPontszam { get; private set; }

        public Tanulo(string nev, int pontszam, int maxPont)
        {
            this.Nev = nev;
            this.Pontszam = pontszam;
            this.MaximalisPontszam = maxPont;
        }

        
        public double Szazalek()
        {
            return (double)Pontszam / MaximalisPontszam * 100;
        }

        //jegy
        public int Jegy()
        {
            double sz = Szazalek();  

            if (sz >= 90)
            {
                return 5;   // jeles
            }
            else if (sz >= 75)
            {
                return 4;   // jó
            }
            else if (sz >= 60)
            {
                return 3;   // közepes
            }
            else if (sz >= 40)
            {
                return 2;   // elégséges
            }
            else
            {
                return 1;   // elégtelen
            }
        }
    }
}
