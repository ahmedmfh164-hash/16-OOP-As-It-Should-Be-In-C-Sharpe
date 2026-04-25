using System;

class clsEmployee
{

    public int ID
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    static void Main(string[] args)
    {

        clsEmployee Employee1 = new clsEmployee();

        Employee1.ID = 7;
        Employee1.Name = "Mohammed Abu-Hadhoud";

        Console.WriteLine("Employee Id:={0}", Employee1.ID);
        Console.WriteLine("Employee Name:={0}", Employee1.Name);
        Console.ReadLine();


    }

}