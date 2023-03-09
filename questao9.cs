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
            float nota1, nota2, nota3, resultado;


            Console.WriteLine("Digite a nota 1: ");
            nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Digite a nota 2: ");
            nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Digite a nota 3: ");
            nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


            resultado = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;
            Console.WriteLine("Média Final: {0}", resultado);
            Console.ReadKey();

        }
    }
}