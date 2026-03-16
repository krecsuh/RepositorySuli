using System;
using System.Collections.Generic;

namespace konyvClassLibrary
{
    public class konyvClassLibrary
    {
        public string Cim { get; private set; }
        public string Szerzo { get; private set; }
        public int LapokSzama { get; private set; }

        
        public static List<konyvClassLibrary> konyvek = new List<konyvClassLibrary>();
        public static int konyvekSzama { get; private set; } = 0;

        
        public konyvClassLibrary(string cim, string szerzo, int lapokSzama)
        {
            
            this.Cim = cim;
            this.Szerzo = szerzo;
            this.LapokSzama = lapokSzama;                     
           

            konyvek.Add(this);
        }

        //ido
        public int OlvasasiIdo()
        {
            return LapokSzama * 2;
        }
    }
}
