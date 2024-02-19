using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Manager
    {
        public string ManagerName { get; set; }

        public void ManagerInfo(Employee employee)
        {
            Console.WriteLine($"Employee Name: {employee.EmployeeName}" +
                              $"\nManager Name: {this.ManagerName}");
        }
    }
}
