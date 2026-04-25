using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_less_Constructor
{

    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson()
        {
            Id=-1;
            Name="Empty";
            Age=0;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person = new clsPerson();

            Console.WriteLine("ID:= {0}", person.Id);
            Console.WriteLine("Name:= {0}", person.Name);
            Console.WriteLine("Age:= {0}", person.Age);


        }
    }
}
