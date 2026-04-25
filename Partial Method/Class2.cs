using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Person
{

    partial void PrintAge()
    {
        //this method will be called once it's implemented, if not implemented the compiler will
        //ignore it without errors ;-)

        Console.WriteLine("Current age: {0}",Age);
    }



}

