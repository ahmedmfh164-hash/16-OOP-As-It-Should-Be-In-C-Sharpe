using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{

   public class Person
    {
      
        public virtual void Greet()
        {
            Console.WriteLine("The person says hello");
        }

    }

    public class Employee:Person
    {
     
        public sealed override void Greet()
        {
            Console.WriteLine("The employee greets you");
        }
    }

    public class Manager : Employee
    {
        //this will produce a compile-time error because the Greet method in Employee is sealed
        //public override void Greet()
        //{
        //    Console.WriteLine("The employee greets you");
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //Create object from class
            Person Person1 = new Person();
            Person1.Greet();

            Employee Employee1=new Employee();
            Employee1.Greet();

            Manager Manager1=new Manager();
                        Manager1.Greet();

            Console.ReadKey();
        }
    }

}
