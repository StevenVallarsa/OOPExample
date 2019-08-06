using System;
using OOPExample;

class MainClass
{
    public static void Main(string[] args)
    {
        var comp = new Desktop("Generic Computer", Desktop.CaseType.MiniTower);

        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer = " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
        Console.WriteLine("Computer case - " + comp.caseType);

        comp.TogglePower();
        Console.WriteLine($"The computer is on - {comp.isOn}");

    }
}

