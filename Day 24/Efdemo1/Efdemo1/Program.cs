using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efdemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* using (var context = new DEPEntities())

            {

                var std = new Dept()

                {
                    DeptName="SRE",
                    DeptId = 4,

                };

                context.Depts.Add(std);

                context.SaveChanges();

            }

            DEPEntities e = new DEPEntities();

            foreach (var i in e.Depts)

            {

                Console.WriteLine(i.DeptId);

            }*/
            using (var context = new DEPEntities())

            {

                var dept = context.Depts.First<Dept>();

                dept.DeptName = "CLOUD";

                context.SaveChanges();

            }
            DEPEntities e = new DEPEntities();

            foreach (var i in e.Depts)

            {

                Console.WriteLine(i.DeptName);

            }
            
        }
    }
}
