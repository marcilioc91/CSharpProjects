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

            list.Remove("Alex");

            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'A');
            int pos1 = list.FindIndex(x => x[0] == 'A');
            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine($"First 'A': {s1}");
            Console.WriteLine($"Last 'A': {s2}");
            
            Console.WriteLine($"First pos 'A': {pos1}");
            Console.WriteLine($"Last pos 'A': {pos2}");

            List<string> list2 = list.FindAll(l => l.Length == 5);
            Console.WriteLine("*********************************");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("*********************************");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(s => s[0] == 'M');
            Console.WriteLine("*********************************");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}