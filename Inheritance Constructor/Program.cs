using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor
{
    public class clsPerson
    {

        public clsPerson(int ID,string FirstName,string LastName,string Title)
        {
            this.Id = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;

        }
                   //Properties
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

        public clsEmployee(int ID, string FirstName, string LastName, string Title
            ,float Salary,string Department):base(ID, FirstName, LastName, Title)
        {
          this.Salary = Salary;
            this.DepartmentName = Department;
        }

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
            clsEmployee Employee1 = new clsEmployee(10,"Ahmed","Mohammed","Eng",5000,"IT");

            Console.WriteLine("Accessing Object 1 (Employee1):\n");

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
