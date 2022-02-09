/*Desenvolver um algoritmo que efetue a soma de todos os números
ímpares que são múltiplos de três e que se encontram no conjunto dos
números de 1 até 500.
*/


using System;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplos3 = 0;
            for (int i = 0; i < 500; i++)
            {
                if (i % 3 == 0)
                {
                    multiplos3 += i;


                }
            }
            Console.WriteLine(multiplos3);
        }
    }
}
