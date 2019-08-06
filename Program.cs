using System;
using OOPExample;

class MainClass
{
    public static void Main(string[] args)
    {
        var comp = new Computer();

        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer = " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);

    }
}

