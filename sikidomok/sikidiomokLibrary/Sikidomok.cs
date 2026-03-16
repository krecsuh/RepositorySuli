using System;
using System.Collections.Generic;
using System.IO;

namespace sikidiomokLibrary
{
    public class Sikidomok
    {
        public string Tipus { get; private set; } // "Kor" vagy "Teglalap"
        public double Sugar { get; private set; }
        public double hosszusag { get; private set; }
        public double szelesseg { get; private set; }

        public static List<Sikidomok> SikidomokListaja { get; private set; } = new List<Sikidomok>();

        // Konstruktor stringből (fájlhoz)
        public Sikidomok(string sor)
        {
            string[] db = sor.Split(';');
            if (db.Length == 1)
            {
                Tipus = "Kor";
                Sugar = double.Parse(db[0]);
            }
            else if (db.Length == 2)
            {
                Tipus = "Teglalap";
                hosszusag = double.Parse(db[0]);
                szelesseg = double.Parse(db[1]);
            }
        }

        // Konstruktor közvetlen számokból (interaktív adatbekeréshez)
        public Sikidomok(double sugar)
        {
            Tipus = "Kor";
            Sugar = sugar;
        }

        public Sikidomok(double hosszusag, double szelesseg)
        {
            Tipus = "Teglalap";
            this.hosszusag = hosszusag;
            this.szelesseg = szelesseg;
        }

        public double Terulet()
        {
            if (Tipus == "Kor")
                return Math.PI * Sugar * Sugar;
            else
                return hosszusag * szelesseg;
        }

        public double Kerulet()
        {
            if (Tipus == "Kor")
                return 2 * Math.PI * Sugar;
            else
                return 2 * (hosszusag + szelesseg);
        }

        public static List<Sikidomok> FileBetoltes(string filename)
        {
            try
            {
                var sr = new StreamReader(filename);
                sr.ReadLine(); // első sor eldobása

                while (!sr.EndOfStream)
                {
                    var ujObjektum = new Sikidomok(sr.ReadLine());
                    SikidomokListaja.Add(ujObjektum);
                }

                sr.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return SikidomokListaja;
        }       
    }
}
