using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallasLibrary
{
    public class Szallas
    {
        public string _szallasNeve;
        /// <summary>
        /// A szállás nevét tartalmazza
        /// </summary>
        public string SzallasNeve { get;private set; }
        public string SzallasCime { get;private set; }
        public int SzobaSzam { get;private set; }
        public int AgySzam {  get;private set; }
        public string UzemeltetoNeve {  get;private set; }
        public string UzemeltetoCime {  get;private set; }
        public string UzemeltetoTelefonszama {  get;private set; }
        public bool Statusz {  get;private set; }
        public string TevekenysegTipusa { get;private set; }

        public static List<Szallas> SzallasokListaja { get; private set; } = new List<Szallas>();

        public static Dictionary<string, int> TelepulesekDictionary = new Dictionary<string, int>();

        public static int SzallasDarab { get; private set; } = 0;

        public static int AktivSzallasokSzama {  get; private set; }
        
        public static int AktivAgyszam {  get; private set; }

        /// <summary>
        /// A Szallas osztály konstruktora ami egy adatfile
        /// soraiból objektumot készít
        /// </summary>
        /// <param name="sor">A beolvasandó file neve</param>

        public Szallas(string sor)
        {
            string[] db = sor.Split(';');
            this.SzallasNeve = db[0];
            this.SzallasCime = db[1];
            this.SzobaSzam = int.Parse(db[2]);
            this.AgySzam = int.Parse(db[3]);
            this.UzemeltetoNeve = db[4];
            this.UzemeltetoCime = db[5];
            this.UzemeltetoTelefonszama = db[6];
            if (db[7] == "Aktív")
            {
                this.Statusz = true;
            }
            else 
            {
                this.Statusz = false;
            }
            this.TevekenysegTipusa = db[8];
            SzallasDarab++;
            if(this.Statusz) { AktivSzallasokSzama++;
                AktivAgyszam += this.AgySzam;
            }
        }

        /// <summary>
        /// A paraméterben szereplő file soraiból listát készít 
        /// </summary>
        /// <param name="filename">A betöltendő file neve</param>
        /// <returns>A file soraiból készített lista</returns>
        /// <exception cref="Exception">Hiba üzenet, ha a file műveletek elakadnak</exception>
        public static List<Szallas> FileBetoltes(string filename)
        {
            try
            {
                var sr = new StreamReader(filename);
                sr.ReadLine(); // fejléc eldobása

                while (!sr.EndOfStream)
                {
                    var ujObjektum = new Szallas(sr.ReadLine());
                    SzallasokListaja.Add(ujObjektum);
                }

                sr.Close();
            }
            catch (Exception e)
            {               
                throw new Exception("Értesítse a programozót!\n"+
                    "+36301234567 számon\n"+
                    "A hiba a SZALLAS.FILEBETOLTES helyen található.");
            }

            return SzallasokListaja;
        }

        public static Dictionary<string, int> AktivTelepulesValogato(List<Szallas> lista) 
        {
            foreach (var szallas in lista)
            {
                string telepulesNeve = szallas.SzallasCime.Split(' ')[1];
                if (!szallas.Statusz)
                {
                    continue;
                }
                if (TelepulesekDictionary.ContainsKey(telepulesNeve))
                {
                    TelepulesekDictionary[telepulesNeve]++;
                }
                else
                {
                    TelepulesekDictionary.Add(telepulesNeve, 1);
                }
                
            }
            return TelepulesekDictionary;
        }

        




    }
}
