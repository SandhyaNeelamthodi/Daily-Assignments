using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (var context = new EFdemoDBEntities())
            {
                var s = new SALES_ORDERS()
                {
                    CLIENTNO = "6"
                    
                };
                context.SALES_ORDER.Add(s);

                context.SaveChanges();
            }
            */
            EmpDBEntities e1 = new EmpDBEntities();

            foreach (var item in e1.DEPARTMENTS)

            {

                Console.WriteLine(item.department_name);

            }

            using (var context = new EmpDBEntities())

            {

                var dept = new DEPARTMENT()

                {

                    department_id = 110,

                    department_name = "IT"

                };

                context.DEPARTMENTS.Add(dept);

                context.SaveChanges();

            }
        }
    }
}
