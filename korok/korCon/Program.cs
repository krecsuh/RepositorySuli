using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorClassLibrary;

namespace korCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kor ujkor = new Kor(1.4);
            var ujkor2 = new Kor(3.14);
            Console.WriteLine(ujkor.Sugar);
            Console.WriteLine($"A kör K.{ujkor.KorKerulet()}. T: {ujkor.KorTerulet()}");
            Console.WriteLine(Kor.KorokSzama);
            Console.WriteLine(Kor.StaticKorKerulet(9.6));
            Console.ReadKey();
        }
    }
}
