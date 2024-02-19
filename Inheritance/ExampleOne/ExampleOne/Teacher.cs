using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Teacher : StaffMember
    {
        public int HodID { get; set; }
        public Teacher()
        {

        }

        public void TeacherInfo()
        {
            string str = $"Member ID: {this.MemberID}," +
                         $"\nMember Name: {this.MemberName}," +
                         $"\nDepartment: {this.Department}," +
                         $"\nID of HOD: {this.HodID}";

            Console.WriteLine(str);
        }
    }
}
