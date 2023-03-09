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

            int qtd_carros;
            float valor_vendas, salario_fixo, valorpcarro, resultado;


            Console.WriteLine("Digite Quantos Carros Você Vendeu: ");
            qtd_carros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor Total de Vendas: ");
            valor_vendas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Seu Salário: ");
            salario_fixo = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Comissão Por Carro Vendido :");
            valorpcarro = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            resultado = salario_fixo + (valorpcarro * qtd_carros) + ((valor_vendas * 5) / 100);
            Console.WriteLine("Salário Final: R$" + resultado);

            Console.ReadLine();






        }
    }
}