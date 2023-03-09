using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int antecessor = Convert.ToInt32(Console.ReadLine());
            antecessor--;
            Console.WriteLine("Antecessor: " + antecessor);
            Console.ReadKey();


        }
    }
}