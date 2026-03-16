using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomClassLibrary
{
    public class Teglalap
    {
        public double szelesseg {  get; private set; }
        public double hosszusag { get; private set; }

        public static double OsszesKerulet { get; private set; } = 0;

        public static double OsszesTerulet { get; private set; } = 0;

        public static List<Teglalap> teglalapListaja = new List<Teglalap>();

        public Teglalap(double szelesseg, double hosszusag)
        {
            OsszesKerulet += this.szelesseg = szelesseg;
            OsszesTerulet += this.hosszusag = hosszusag;
            teglalapListaja.Add(this);
        }


        public double TeglalapKerulete()
        {
            return 2*(this.szelesseg+this.hosszusag);
        }

        public double TeglalapTerülete()
        {
            return this.szelesseg*this.hosszusag;
        }
    }
}
