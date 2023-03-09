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

            int votos_brancos, votos_nulos, votos_validos, tt_eleitores;
            float pbranco, pnulo, pvalido;

            Console.WriteLine("Digite o total de eleitores: ");
            tt_eleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos brancos: ");
            votos_brancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos nulos: ");
            votos_nulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos válidos: ");
            votos_validos = Convert.ToInt32(Console.ReadLine());

            pbranco = (votos_brancos * 100) / tt_eleitores;
            pnulo = (votos_nulos * 100) / tt_eleitores;
            pvalido = (votos_validos * 100) / tt_eleitores;

            Console.WriteLine("\nPorcentagem: ");
            Console.WriteLine("Votos Brancos: " + pbranco + "%");
            Console.WriteLine("Votos Nulos: " + pnulo + "%");
            Console.WriteLine("Votos Válidos: " + pvalido + "%");
            Console.ReadKey();

        }
    }
}