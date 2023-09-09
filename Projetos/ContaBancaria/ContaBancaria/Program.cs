using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            double valor;

            if (resposta == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, valor);
            }
            else
                conta = new ContaBancaria(numero, titular);
            Console.WriteLine($"Dados da conta: \n{conta}");
            while (true)
            {
                Console.Write($"Você deseja fazer alguma operação? (s/n): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
                if (resposta == 's')
                {
                    Console.Write("Deseja realizar saque ou depósito? (1/2): ");
                    resposta = char.Parse(Console.ReadLine().ToLower());
                    if (resposta == '1')
                    {
                        Console.Write("Informe o valor para saque: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Saque(valor);
                    }
                    else if (resposta == '2')
                    {
                        Console.Write("Informe o valor para depósito: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Deposito(valor);
                    }
                    else
                        throw new Exception("Responda apenas entre o número 1 ou 2.");
                    Console.WriteLine($"Dados da conta: \n{conta}");
                }
                else if (resposta == 'n')
                    break;
                else
                    throw new Exception("Responda apenas entre o 's' e 'n'.");
            }
        }
    }
}
