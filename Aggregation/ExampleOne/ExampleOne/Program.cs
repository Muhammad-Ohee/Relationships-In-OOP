//Console.WriteLine("Hello, OS");

using ExampleOne;

namespace ExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentName = "OS";
            student.StudentRoll = 4;
            student.StudentClass = 8;

            Address address = new Address();
            address.Street = "13/4";
            address.City = "Bakersfield";
            address.State = "California";
            address.PostalCode = "93306";

            student.StudentInfo(address);
        }
    }
}

