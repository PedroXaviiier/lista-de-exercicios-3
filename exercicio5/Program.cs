/*Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
valores do cálculo de A! e o seu resultado.
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
• Pesquise sobre “fatorial”
*/ 


using System;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um numero: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            Console.Write($"{numero}!= ");

            for (; numero > 1; numero--)
            {
                resultado *= numero;
                Console.Write($"{numero}x");
            } 

            Console.WriteLine($"1={resultado}");
        }
    }
}
