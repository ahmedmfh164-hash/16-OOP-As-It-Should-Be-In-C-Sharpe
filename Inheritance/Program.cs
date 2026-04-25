using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class clsPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get
            {
                return FirstName+' '+LastName;
            }


        }
    }

    public class clsEmployee : clsPerson
    {
        public float Salary { get; set; }
        public string DepartmentName { get; set; }

        public void IncreaseSalaryBy(float amount)
        {
            Salary += amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee1 = new clsEmployee();

            Console.WriteLine("Accessing Object 1 (Employee1):\n");

            //the following inherited from base class person
            Employee1.Id = 10;
            Employee1.Title="Mr.";
            Employee1.FirstName="Mohammed";
            Employee1.LastName ="Abu-Hadhoud";

            //the following are from derived class Employee
            Employee1.DepartmentName="IT";
            Employee1.Salary=5000;

            Console.WriteLine("ID:={0}", Employee1.Id);
            Console.WriteLine("Title:={0}", Employee1.Title);
            Console.WriteLine("FullName:={0}", Employee1.FullName);
            Console.WriteLine("Department:={0}", Employee1.DepartmentName);

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase:={0}", Employee1.Salary);

            Console.ReadKey();
        }
    }
}
