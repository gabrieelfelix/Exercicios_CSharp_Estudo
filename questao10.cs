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
            int valor;

            Console.WriteLine("Digite um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 10)
            {
                Console.WriteLine("É maior que 10!");
            }
            else
            {
                Console.WriteLine("É menor que 10!");
            }
            Console.ReadKey();
        }
    }
}
