using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Application_of_Constructors_and_Static_Methods
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserName {  get; set; }
        public string Password {  get; set; }


        public clsPerson(int id, string name, short Age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = Age;
        }


        public static clsPerson Find(int id)
        {
            //we simulate the result for now,later on we will connect to database and make object

            if (id==10)
                return new clsPerson(10, "Ahmed Mohammed", 19);
            else
                return null;
        }

        public static clsPerson Find(string UserName,string Password)
        {
            //we simulate the result for now,later on we will connect to database and make object

            if (UserName=="user1"&&Password=="1234")
                return new clsPerson(10, "Ahmed Mohammed", 19);
            else
                return null;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
           //clsPerson Person = new clsPerson(10, "Ahmed Mohammed", 19);

            Console.WriteLine("Finding Person1 by ID");

            clsPerson Person1= clsPerson.Find(10);

            if (Person1!=null)
            {
                Console.WriteLine("ID:={0}", Person1.Id);
                Console.WriteLine("Name:={0}", Person1.Name);
                Console.WriteLine("Age:={0}", Person1.Age);
            }
            else
                Console.WriteLine("Could Not find the person by the given ID");


            Console.WriteLine("\nFinding Person2 by userName/password");

            clsPerson Person2 = clsPerson.Find("user1","1234");

            if (Person2!=null)
            {
                Console.WriteLine("ID:={0}", Person2.Id);
                Console.WriteLine("Name:={0}", Person2.Name);
                Console.WriteLine("Age:={0}", Person2.Age);
            }
            else
                Console.WriteLine("Could Not find the person using username/password");


        }
    }
}
