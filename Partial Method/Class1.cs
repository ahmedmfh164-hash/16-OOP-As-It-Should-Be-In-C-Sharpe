using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class Person
{
    public int Age { get; set; }

    partial void PrintAge();

    public void Birthday()
    {
        Age++;
        //if PrintAge is implemented it will be called otherwise it will be ignored
        PrintAge();
    }

}
