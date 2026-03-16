using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a karácsonyfa méretét: ");
            int[] tomb = new int[1000];
            for (int i = 0; i < tomb.Length; i++)
            {

                Console.Write("*");
            }
            
            Console.ReadKey();
        }
    }
}
