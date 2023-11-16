namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hou many people will be registered? ");
            int register = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= register; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));

                Console.WriteLine("**********************");
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idV = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idV);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
                Console.WriteLine("This Id doesn't exist! Please check again.");
            Console.WriteLine("**********************");

            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in employees)
                Console.WriteLine(obj);
        }
    }
}