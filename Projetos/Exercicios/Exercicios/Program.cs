using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retangulo retangulo = new Retangulo();

            //Console.Write("Informe a largura do retângulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine());

            //Console.Write("Informe a altura do retângulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine());

            //Console.WriteLine($"AREA = {retangulo.Area()}");
            //Console.WriteLine($"PERIMETRO = {retangulo.Perimetro()}");
            //Console.WriteLine($"DIAGONAL = {retangulo.Diagonal()}");

            //Funcionario funcionario = new Funcionario();

            //Console.Write("Informe o nome do cidadão dos céus: ");
            //funcionario.Nome = Console.ReadLine();

            //Console.Write("Informe o salário bruto do cidadão dos céus: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            //Console.Write("Informe o imposto para foder o cidadão dos céus: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Funcionário: {funcionario} \n");

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double percentual = double.Parse(Console.ReadLine());
            //funcionario.AumentarSalario(percentual);

            //Console.WriteLine($"Dados atualizados: {funcionario}");

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaA = int.Parse(Console.ReadLine());
            aluno.NotaB = int.Parse(Console.ReadLine());
            aluno.NotaC = int.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL: {aluno.NotaTotal()}");
            if (aluno.Aprovado())
                Console.WriteLine("APROVADO!");
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante()} PONTOS!");
            }

            Console.ReadKey();
        }
    }
}
