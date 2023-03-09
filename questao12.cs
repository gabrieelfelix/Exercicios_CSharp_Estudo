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
            float n1, n2, resultado;

            Console.WriteLine("Digite sua primeira nota: ");
            n1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Digite sua segunda nota: ");
            n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            resultado = ( n1 + n2 ) / 2;

            if ( resultado >= 6 )
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!" + resultado);
            }

            Console.ReadKey();

        }
    }
}



