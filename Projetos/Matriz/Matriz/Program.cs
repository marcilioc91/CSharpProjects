using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e uma matriz de
              ordem N contendo números inteiros. Em seguida, mostrar a diagonal
              principal e a quantidade de valores negativos da matriz.*/
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"Main diagonal:");
            for (int i = 0; i < n; i++)
                Console.Write($"{matriz[i,i]} ");
            Console.WriteLine("\n------------------------");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                        count++;
                }
            }
            Console.Write($"Negative number(s): {count}");
            Console.ReadKey();
        }
    }
}
