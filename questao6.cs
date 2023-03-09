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

            float custo_fabrica, resultado;

            Console.WriteLine("Digite o Custo de Fábrica: ");
            custo_fabrica = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            resultado = custo_fabrica + ((custo_fabrica * 28) / 100) + ((custo_fabrica * 45) / 100);
            Console.WriteLine("Valor Final: R$" + resultado);

            Console.ReadKey();


        }
    }
}