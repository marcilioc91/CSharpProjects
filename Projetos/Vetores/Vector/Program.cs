using System.Globalization;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            var avg = string.Create(CultureInfo.InvariantCulture, $"{sum / n:n2}");
            Console.WriteLine($"AVERAGE HEIGHT = {avg}");
        }

    }
}
