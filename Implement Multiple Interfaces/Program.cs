using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Multiple_Interfaces
{

    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void Introduce();

        void Print();

        string To_string();
    }

    public interface ICommunicate
    {
        void CallPhone();

        void SendEmail(string Title,string Body);

        void SendSMS(string Title, string Body);

        void SendFax(string Title, string Body);
    }

    public abstract class Person : IPerson ,ICommunicate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Introduce();

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        public void Print()
        {
            Console.WriteLine("Hi I'm print method");
        }

        public string To_string()
        {
            return "Hi this is the complete string....";
        }

        public void CallPhone()
        {
            Console.WriteLine("sdfsf");
        }

        public void SendEmail(string Title, string Body)
        {
            Console.WriteLine("Email Sent :-)");

        }

        public void SendSMS(string Title, string Body)
        {
            Console.WriteLine("SMS Sent :-)");

        }

        public void SendFax(string Title, string Body)
        {
            Console.WriteLine("Fax Sent :-)");

        }

    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //You cannot create an object of an Interface, you can only Implement it.
            //IPerson Person1 = new IPerson();

            Employee employee = new Employee();
            employee.FirstName = "Mohammed";
            employee.LastName = "Abu-Hadhoud";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"
            employee.Print();
            employee.SendEmail("hi","body");
            employee.SendSMS("hi", "body");
            employee.SendFax("hi", "body");
            employee.CallPhone();
            Console.ReadKey();

        }
    }
}
