using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikidomClassLibrary;

namespace SikidomCon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Téglalap vagy Kör?");           
            Console.WriteLine("1. rész: Kör adatok bekérése\n" +
                "Add meg a kör sugarát (üres ENTER=vége)\n");
            while (true)
            {
                Console.Write("--> ");
                string input= Console.ReadLine();
                if (input == "") { break; }
                try
                {
                    double sugar = double.Parse(input);
                    if (sugar > 0)
                    {
                        //Példányosítás
                        var ujObj= new Kor(sugar);
                    }
                    else { continue; }
                }
                catch
                {
                    Console.WriteLine("Helyes adatokat kérek!");
                }



                Console.WriteLine("\nKörök adatinak listázása\n");
                foreach (var kor in Kor.KorokListaja)
                {
                    Console.WriteLine($"A(z) {kor.Sugar} sugarú kör Kerülete: {kor.KorKerulet()} Területe: {kor.KorTerulet()}");
                }
                Console.WriteLine($"Összes kerület: {Kor.OsszesKerulet}\n" +
                    $"Összes Terület: {Kor.OsszesTerulet}");
                Console.ReadKey();
            }





            Console.WriteLine("2. rész: Téglalap adatok bekérése\n" +
                    "Add meg a téglalap hosszúságát," +
                    "és a szélességét" +
                    "(üres ENTER=vége)\n");
            while (true)
            {
                Console.Write("Hosszúság--> ");
                string hosszusagStr = Console.ReadLine();
                Console.Write("Szélesség-->");
                string szelessegStr = Console.ReadLine();
                if (hosszusagStr == "") { break; }
                if (szelessegStr == "") { break; }
                try
                {
                    double hosszusag = double.Parse(hosszusagStr);
                    double szelesseg = double.Parse(szelessegStr);
                    if (hosszusag > 0 && szelesseg>0)
                    {
                        var ujObj = new Teglalap(szelesseg, hosszusag);
                    }
                    else 
                    {
                        continue; 
                    }
                }
                catch
                {
                    Console.WriteLine("Helyes adatokat írj!");
                }


                Console.WriteLine("\nTeglalap adatinak listázása\n");

                foreach (var Teglalap in Teglalap.teglalapListaja)
                {
                    Console.WriteLine($"Szélesség: {Teglalap.szelesseg}, Hosszúság: {Teglalap.hosszusag}, " +
                                      $"Kerület: {Teglalap.TeglalapKerulete()}, Terület: {Teglalap.TeglalapTerülete()}");
                }
                Console.ReadKey();
            }

        }
    }
}
