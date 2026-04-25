using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Constructors_using_overloading
{
    class clsPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public clsPerson()
        {
            this.Id = -1;
            this.Name = "Empty";
            this.Age = 0;
        }

        public clsPerson(int id, string name, short Age)
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

                clsPerson Person1 = new clsPerson();

                clsPerson Person2 = new clsPerson(10, "Ahmed Mohamed", 19);

            Console.WriteLine("Calling Parameterless Constructor");
                Console.WriteLine("ID:= {0}", Person1.Id);
                Console.WriteLine("Name:= {0}", Person1.Name);
                Console.WriteLine("Age:= {0}", Person1.Age);

            Console.WriteLine("\nCalling Parameterized Constructor");
            Console.WriteLine("ID:= {0}", Person2.Id);
            Console.WriteLine("Name:= {0}", Person2.Name);
            Console.WriteLine("Age:= {0}", Person2.Age);


        }
        }
}
