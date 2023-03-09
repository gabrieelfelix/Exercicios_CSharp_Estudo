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
            int qtd_macas;
            float resultado;

            Console.WriteLine("Números de maçãs compradas: ");
            qtd_macas = int.Parse(Console.ReadLine());

            if (qtd_macas < 12)
            {
                resultado = qtd_macas * 1.30f;
                Console.WriteLine("Valor Total: R$" + resultado);
            }
            else
            {
                Console.WriteLine("Valor Total: R$" + qtd_macas);
            }

            Console.ReadKey();

        }
    }
}