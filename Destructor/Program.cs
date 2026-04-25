using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class clsPerson
    {

        public clsPerson()
        {
            Console.WriteLine("Constructor called.");
        }

        ~clsPerson()
        {
            Console.WriteLine("Destructor called.");

        }

    }

        internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person = new clsPerson();

            Console.ReadKey();
        }
    }
}
