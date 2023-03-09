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
            float fah, celsius, formula;

            Console.WriteLine("Fahrenheit: ");
            fah = float.Parse(Console.WriteLine(), CultureInfo.InvariantCulture.NumberFormat);

            formula = ((fah - 32) / 9) * 5;
            Console.WriteLine(formula + "ºC");

            Console.ReadKey();
        }
    }
}
