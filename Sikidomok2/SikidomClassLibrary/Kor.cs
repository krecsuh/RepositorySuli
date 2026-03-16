using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomClassLibrary
{
    public class Kor
    {
        public double Sugar {  get; private set; }
        public static List<Kor> KorokListaja =new List<Kor>();

        public static double OsszesKerulet { get; private set; } = 0;
        public static double OsszesTerulet { get; private set; } = 0;
        
        /// <summary>
        /// Kör objektumot hoz létre
        /// Példa:
        /// kör objektum new kor(sugar)
        /// </summary>
        /// <param name="sugar">A kör sugara, double tipusú, pozitív szám</param>
        
        public Kor(double sugar)
        {
            this.Sugar = sugar;
            OsszesKerulet += this.KorKerulet();
            OsszesTerulet += this.KorTerulet();
            KorokListaja.Add(this);
        }


        public double KorKerulet()
        {
            return Math.Round(this.Sugar*2*Math.PI,2);
        }

        public double KorTerulet()
        {
            return Math.Round(this.Sugar*this.Sugar*Math.PI,2);
        }
    }
}
