//Console.WriteLine("Hello, OS");

namespace ExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Tom");
            Student student2 = new Student("Crusie");

            Teacher teacher = new Teacher("Angelina");

            teacher.AddStudent(student1);
            teacher.AddStudent(student2);

            Console.WriteLine();
            teacher.Display();
        }
    }
}

