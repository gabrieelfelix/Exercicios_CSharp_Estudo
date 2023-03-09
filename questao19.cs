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

            int[] val = new int[3];
            int aux = 0, aux2 = 0, aux3 = 0;

            for (int i = 0; i < 3; i++)
            { 
                Console.WriteLine("Digite um valor inteiro: ");
                val[i] = int.Parse(Console.ReadLine());
            }
            
            while (aux < 3)
            {

                if (aux == 0)
                {
                    aux2 = 1;
                    aux3 = 2;
                }
                else if (aux == 1)
                {
                    aux2 = 0;
                    aux3 = 2;
                }
                else if (aux == 2)
                {
                    aux2 = 1;
                    aux3 = 0;
                }

                if (val[aux2] > val[aux3])
                {
                    Console.WriteLine(val[aux] + " " + val[aux2] + " " + val[aux3]);
                }
                else
                {
                    Console.WriteLine(val[aux] + " " + val[aux3] + " " + val[aux2]);
                }

                aux++;
            }
            Console.ReadKey();
        }
            
    }
}
