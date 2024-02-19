using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Employee
    {
        public string EmployeeName { get; set; }

        public void ManagerInfo(Manager manager)
        {
            manager.ManagerInfo(this);
        }
    }
}
