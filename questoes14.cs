using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int v1, v2;

            Console.WriteLine("Digite um valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            v2 = int.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                Console.WriteLine(v1 + " é maior");
            }
            else if (v2 > v1)
            {
                Console.WriteLine(v2 + " é maior");
            }
            else
            {
                Console.WriteLine("Digite valores diferentes!");
            }

            Console.ReadKey();

        }
    }
}
