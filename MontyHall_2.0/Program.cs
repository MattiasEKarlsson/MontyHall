using System;

namespace MontyHall_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = new Door();
            
            door.AssignPrize();
            door.SelectDoor();
            door.RevealDoor();
            door.ShouldSwitch();
            door.SwitchDoor();
            Console.WriteLine(door.PrizeDoor);

        }
    }
}
