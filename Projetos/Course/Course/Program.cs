using System;
using System.Globalization;
using System.Security.Principal;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"Usuário: Josimar");            
            for (int i = 3; i >= 0; i--)
            {
                Console.Write("Insira sua senha: ");
                int senha = int.Parse(Console.ReadLine());

                if (senha != 1234 && i > 0)
                    Console.WriteLine($"Senha inválida! Você tem {i} tentativas. \n");
                else if (senha != 1234 && i == 0)
                {
                    Console.WriteLine("Usuário bloqueado");
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário logado com sucesso!");
                    break;
                }
            }
        }
    }
}
