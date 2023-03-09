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

            float horas_trabalhadas, salario_hora, resultado,a;

            Console.WriteLine("Digite o número de horas trabalhadas no mês: ");
            horas_trabalhadas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Digite o Salário por hora:");
            salario_hora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            resultado = horas_trabalhadas * salario_hora;

            if (horas_trabalhadas > 160)
            {
               float aux = 160 - horas_trabalhadas;
                a = aux * salario_hora + ( ( aux * salario_hora )/2);

               Console.WriteLine( "Salário Final: R$" + (160 * salario_hora + a));

            }
            else
            {
                Console.WriteLine("Salário Final: R$" +  resultado);
            }

            Console.ReadKey();
            
        }
    }
}
