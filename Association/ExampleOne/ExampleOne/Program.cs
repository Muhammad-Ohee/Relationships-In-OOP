//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeName = "Tom";

            Manager manager = new Manager();
            manager.ManagerName = "Angelina";

            employee.ManagerInfo(manager);
        }
    }
}