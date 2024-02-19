using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class HOD : StaffMember
    {
        public int CourseCompleted { get; set; }
        public HOD()
        {

        }

        public void HodInfo()
        {
            string str = $"Member ID: {this.MemberID}," +
                         $"\nMember Name: {this.MemberName}," +
                         $"\nDepartment: {this.Department}," +
                         $"\nCompleted Course: {this.CourseCompleted}";
            Console.WriteLine(str);
        }
    }
}
