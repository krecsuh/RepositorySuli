using System;
using konyvClassLibrary;

namespace konyvCon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Adja meg a könyv címét! ( stop)");
                string cim = Console.ReadLine();

                if (cim == "stop")
                {
                    break;
                }
                    

                Console.WriteLine("Adja meg a könyv Szerzőjét:");
                string szerzo = Console.ReadLine();

                Console.WriteLine("Adja meg a lapok Számát:");
                int lapok = int.Parse(Console.ReadLine());

                // objektum 

                var ujObj = new konyvClassLibrary.konyvClassLibrary(cim, szerzo, lapok);

            }

            

            foreach (var k in konyvClassLibrary.konyvClassLibrary.konyvek)
            {
                Console.WriteLine($"Cím: {k.Cim}");
                Console.WriteLine($"Szerző: {k.Szerzo}");
                Console.WriteLine($"Lapok: {k.LapokSzama}");
                Console.WriteLine($"Olvasási idő: {k.OlvasasiIdo()} perc");
                
            }

            Console.WriteLine($"összesen: {konyvClassLibrary.konyvClassLibrary.konyvekSzama}");

            Console.ReadKey();
        }
    }
}
