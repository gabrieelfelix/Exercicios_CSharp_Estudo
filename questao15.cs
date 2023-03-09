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

            int h1, h2, resultado;

            Console.WriteLine("Hora de inicio: ");
            h1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora de inicio: ");
            h2 = int.Parse(Console.ReadLine());

            

            if ( h2 > h1 )
            {
               resultado = h2 - h1;
                Console.WriteLine( resultado + " Horas");

            }

            else if (h2 == h1)
            {
                Console.WriteLine("24 Horas ");

            }
            else
            {

                resultado = (24 - h1) + h2;
                Console.WriteLine( resultado + " Horas");

            }

            Console.ReadKey();

        }
    }
}