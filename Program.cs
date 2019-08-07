using System;
using OOPExample;

class MainClass
{
    public static void Main(string[] args)
    {
        var comp = new Desktop("Great Computer", Desktop.CaseType.MiniTower);
        //var comp = new Laptop("Generic Laptop", 1024, 768);
        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer = " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
        //Console.WriteLine("Computer case - " + comp.caseType);

        comp.TogglePower();
        Console.WriteLine($"CLICK! The computer is now {(comp.isOn == true ? "on" : "off")}");

        var sleepingComp = comp as ISleep;

        if(sleepingComp != null)
        {
            sleepingComp.ToggleSleep();
            Console.WriteLine($"The computer is {(sleepingComp.isSleeping == true ? "sleeping" : "awake")}");

            comp.TogglePower();
            Console.WriteLine($"CLICK! The computer is now {(comp.isOn == true ? "on" : "off")}");

        }


        //comp.ToggleSleep();
        //Console.WriteLine($"The computer is {(comp.isSleeping == true ? "sleeping" : "awake")}");

        //comp.TogglePower();
        //Console.WriteLine($"CLICK! The computer is now {(comp.isOn == true ? "on" : "off")}");



    }
}

