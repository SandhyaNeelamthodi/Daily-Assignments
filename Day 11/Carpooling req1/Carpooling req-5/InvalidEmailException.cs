using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpooling_req_5
{
    class InvalidEmailException : Exception
    {
        string email;

        public InvalidEmailException()
        {

        }
        public InvalidEmailException(string email)
        {
            this.email = email;
        }
        public void inform()
        {
            Console.WriteLine("Inavalid email id for the user");


        }
    }
}
