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
            float salario, ajuste, resultado;

            Console.WriteLine("Digite seu salário: ");
            salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Digite o seu percentual de reajuste: ");
            ajuste = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            resultado = ((salario * ajuste) / 100 + salario);

            Console.WriteLine("\nSeu novo salário: R$" + resultado);

            Console.ReadKey();
        }
    }
}