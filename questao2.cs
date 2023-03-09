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

            string b, h;
            float basee, altura;


            Console.WriteLine("Digite o valor da base: ");
            b = Console.ReadLine();
            basee = float.Parse(b, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("\nDigite o valor da altura: ");
            h = Console.ReadLine();
            altura = float.Parse(h, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("\nResultado = " + basee * altura);
            Console.ReadKey();




        }
    }
}