using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        List<Student> Students { get; set; }

        public Teacher(string name)
        {
            TeacherName = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"{student.StudentName} added to {TeacherName} teacher.");
        }

        public void Display()
        {
            Console.Write($"{TeacherName} has ");
            foreach (var student in Students)
            {
                //Console.Write($"{student}, ");
                Console.Write($"{student.StudentName}, ");
            }
            Console.WriteLine("students.");
        }
    }
}
