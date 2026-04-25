using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class clsA
    {
        public virtual void print()
            {
            Console.WriteLine("Hi,I'm the print method from the base class A");
        }


    }

    public class clsB:clsA
    {
        public override void print()
        {
            Console.WriteLine("Hi,I'm the print method from the derived class B");
            base.print();
        }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
