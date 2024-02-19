using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentRoll { get; set; }
        public int StudentClass { get; set; }

        public void StudentInfo(Address address)
        {
            Console.WriteLine($"Student's Name: {StudentName}" +
                              $"\nStudent's Roll: {StudentRoll}" +
                              $"\nStudent's Class: {StudentClass}\n");
            address.GetAddress();
        }
    }
}
