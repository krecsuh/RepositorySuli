using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibraryATudasFaja
{
    public class ATudasFaja
    {
        public string Kerdes { get; private set; }
        public string Helyes { get; private set; }
        public string Valasz1 { get; private set; }
        public string Valasz2 { get; private set; }
        public string Valasz3 { get; private set; }
        public string Valasz4 { get; private set; }
        public string Magyarazat { get; private set; }

        public ATudasFaja(string sor)
        {
            string[] db = sor.Split(';');

            Kerdes = db[0];
            Helyes = db[1];
            Valasz1 = db[2];
            Valasz2 = db[3];
            Valasz3 = db[4];
            Valasz4 = db[5];
            Magyarazat = db[6];
        }

        public static List<ATudasFaja> FileBeolvasas(string filename)
        {
            List<ATudasFaja> lista = new List<ATudasFaja>();

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string sor = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {                       
                        
                            ATudasFaja obj = new ATudasFaja(sr.ReadLine());
                            lista.Add(obj);
                        
                    }
                }
            }
            catch
            {
                throw new Exception("Hiba a file megnyitása során!");
            }

            return lista;
        }
    }
}