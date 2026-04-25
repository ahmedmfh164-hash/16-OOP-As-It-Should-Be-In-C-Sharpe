using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_Constructor
{
    class clsPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson(int id, string name,short Age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = Age;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //clsPerson Person = new clsPerson();
            clsPerson Person = new clsPerson(10, "Ahmed Mohamed", 19);

            Console.WriteLine("ID:= {0}",Person.Id);
            Console.WriteLine("Name:= {0}",Person.Name);
            Console.WriteLine("Age:= {0}",Person.Age);








        }
    }
}
