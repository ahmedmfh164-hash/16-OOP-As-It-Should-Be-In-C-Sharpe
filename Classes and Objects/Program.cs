using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class clsPerson
    {
        //Fieldes
        public string FirstName;
        public string LastName;

        //Method
        public string FullName()
        {
            return FirstName+' '+LastName;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();

            Console.WriteLine("Accessing object 1 (person1):");
            person1.FirstName="Ahmed";
            person1.LastName="Mohamed";
           Console.WriteLine (person1.FullName());

            clsPerson person2 = new clsPerson();

            Console.WriteLine("Accessing object 2 (person2):");
            person2.FirstName="Mohamed";
            person2.LastName="Abu-Hadhoud";
            Console.WriteLine(person2.FullName());

        }
    }
}
