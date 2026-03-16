using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sikidiomokLibrary;
using sikidomokCon;

namespace sikidomokCon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Sikidomok> lista = new List<Sikidomok>();

            try
            {
                lista = Sikidomok.FileBetoltes("sikidomok.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba a fájl beolvasásakor: {ex.Message}");
            }
            Console.WriteLine("\nBeolvasott síkidomok:");
            foreach (var s in lista)
            {
                Console.WriteLine($"{s.Tipus} - Terület: {s.Terulet():F2}, Kerület: {s.Kerulet():F2}");
            }



            Console.ReadKey();
        }
    }
}
