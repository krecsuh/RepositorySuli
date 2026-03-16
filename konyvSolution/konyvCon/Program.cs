using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonyvClassLibrary;

namespace konyvCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem Adja meg a könyv Címét:" +
                "a Szerzőt: " +
                "az oldalSzámot: ");
            while (true) 
            {
                string cim = Console.ReadLine();
                string szerzo = Console.ReadLine();
                string lapokSzama = Console.ReadLine();
                if (cim == ""& cim =="stop")
                {
                    break;
                }
                if (szerzo == "")
                {
                    break;
                }
                if(lapokSzama == "")
                {
                    break;
                }
                else
                {
                    continue;
                }
                
            }

            Console.ReadKey();
        }
    }
}
