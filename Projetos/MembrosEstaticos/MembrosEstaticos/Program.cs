using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //double circ = Calculadora.Circunferencia(raio);
            //double vol = Calculadora.Volume(raio);

            //Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Informe a cotação do dólar: ");
            double valorCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você deseja comprar? ");
            double qtdeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ValorDolar(valorCotacao, qtdeDolar).ToString("C")}");
        }
    }
}
