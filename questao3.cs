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
            Console.WriteLine("Qual sua idade? \n");
            Console.WriteLine("Anos: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());
            int resultado = (idade * 365) + (meses * 30) + dias;
            Console.WriteLine(resultado + " Dias de vida!");
            Console.ReadKey();



        }
    }
}