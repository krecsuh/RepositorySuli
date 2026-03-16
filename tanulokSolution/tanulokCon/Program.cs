using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanulokClassLibrary;

namespace tanulokCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. A maximális pontszám bekérése
            Console.WriteLine("Kérem adja meg a dolgozat maximális pontszámát:");
            int maxPontSzam = int.Parse(Console.ReadLine());

            List<Tanulo> tanulok = new List<Tanulo>();

            while (true)
            {
                Console.WriteLine("Adja meg a diák nevét (vege = kilépés):");
                string nev = Console.ReadLine();

                if (nev == "vege")
                    break;

                Console.WriteLine("Adja meg az elért pontszámot:");
                int pont = int.Parse(Console.ReadLine());

                Tanulo t = new Tanulo(nev, pont, maxPontSzam);
                tanulok.Add(t);
            }

            Console.WriteLine("Kiírás");

            foreach (var t in tanulok)
            {
                string nev = t.Nev;
                int pont = t.Pontszam;
                int max = t.MaximalisPontszam;
                double szazalek = t.Szazalek();
                int jegy = t.Jegy();


                Console.WriteLine($"{nev}:");
                Console.WriteLine($"Pontszám: {pont} / {max}");
                Console.WriteLine($"Százalék: {szazalek:0}%"); //erre rákerestem hogy miért igy kell, hogy miért kell oda irni a :0-t
                Console.WriteLine($"Jegy: {jegy}");
            }

            Console.WriteLine($"A dolgozat maximális pontszáma: {maxPontSzam}");
        }
        
    }
}
