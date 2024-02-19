//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("OS");

            HOD hod = new HOD();
            hod.MemberID = 1;
            hod.MemberName = "foo";
            hod.Department = "CSE";
            hod.CourseCompleted = 40;
            hod.HodInfo();

            Console.WriteLine();

            Teacher teacher = new Teacher();
            teacher.MemberID = 1;
            teacher.MemberName = "foo";
            teacher.Department = "CSE";
            teacher.HodID = 4;
            teacher.TeacherInfo();
        }
    }
}

