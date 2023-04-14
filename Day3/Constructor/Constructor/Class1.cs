using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Emp
    {
        public int EmpId;
        public string Name;
        public decimal Salary;

        public Emp()
        {

        }
        public Emp(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }
    }
}
