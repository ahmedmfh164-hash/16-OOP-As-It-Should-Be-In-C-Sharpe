using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting___DownCasting
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi,my name is {Name} and I am {Age} Years old.");

        }
    }

    public class clsEmployee : clsPerson
    {

        public Decimal Salary { get; set; }
        public string Company { get; set; }

        public void Work()
        {
            Console.WriteLine($"I Work at {Company} and earn {Salary:C} per year.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            clsEmployee Employee1 = new clsEmployee { Name="john", Age=30, Company="Acme Inc.", Salary=4000 };
            clsPerson Person1 = Employee1;
            Person1.Greet();//output:"Hi, my Name is John and I am 30 Years old."

            //DownCasting
            clsPerson Person2 = new clsEmployee { Name="jane", Age=25, Company="XYZ Corp.", Salary=6000 };
            clsEmployee Employee2 = (clsEmployee)Person2;
            Employee2.Work();//output:"I Work at XYZ Crop.and earn $60,000.000 per year."

            //Invalid downcasting - throws Invalid at runtime
           // clsPerson Person3 = new clsPerson { Name="Bob", Age=40 };
            //clsEmployee employee3 = (clsEmployee)Person3;//Runtime exception: InvalidCastException

            Console.ReadKey();

        }
    }
}
