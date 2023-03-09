using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{

    internal class Program
    {
        static void Main(string[] args)
        {

            int v1, v2, v3;

            Console.WriteLine("Digite um valor: ");
            v1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            v3 = Convert.ToInt32(Console.ReadLine());

            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine(v1 + " é maior!");
            }
            else if (v2 > v1 && v2 > v3)
            {
                Console.WriteLine(v2 + " é maior!");
            }
            else if (v3 > v1 && v3 > v2)
            {
                Console.WriteLine(v3 + " é maior!");
            }
            if (v1 == v2 || v2 == v3 || v3 == v1)
            {
                Console.WriteLine("Valores iguais, tente novamente!");
            }
           
            Console.ReadKey();

        }

            
    }
}