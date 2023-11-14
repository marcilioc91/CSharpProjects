namespace CalculatorSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 2, 5 );
            int s2 = Calculator.Sum( 2, 5, 3, 9);

            int t1 = 5;
            Calculator.Triple(ref t1);

            int t2 = 10;
            Calculator.Triple(t2, out int triple);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(t1);
            Console.WriteLine(triple);
        }
    }
}