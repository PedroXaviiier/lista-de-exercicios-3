/*• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
programa deverá calcular e mostrar:
a. A menor altura do grupo;
b. A maior altura do grupo;
*/

using System;

namespace lista_de_exercicios_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];

            double menor_altura = double.MaxValue;
            double maior_altura = 0;

            
            for (int i = 0; i < altura.Length; i++)
            {
                Console.WriteLine($"Altura da pessoa {i+1}: ");

                altura[i] = Convert.ToDouble(Console.ReadLine());

                if (altura[i] > maior_altura)
                {
                    maior_altura = altura[i];
                }

                if (altura[i] < menor_altura)
                {
                    menor_altura = altura[i];
                }
            }
            Console.WriteLine($"a maior altura é: {maior_altura}");

            Console.WriteLine($"a menor altura é: {menor_altura}");
        }
    }
}
