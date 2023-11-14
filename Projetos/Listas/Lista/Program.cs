using System.Collections.Generic;
namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(1, "Lucca");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine(list.Count);
        }
    }
}