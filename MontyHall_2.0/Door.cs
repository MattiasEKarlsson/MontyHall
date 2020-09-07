using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHall_2._0
{
    class Door
    {
        private Random _random = new Random();
        public int PrizeDoor { get; set; }
        public int RevealedDoor { get; set; }
        public int ChosenDoor = 0;
        string wantToSwitch = "";

        public void SelectDoor()
        {
            Console.Write("Chose your door: [1],[2] or [3]: ");
            ChosenDoor = Convert.ToInt32(Console.ReadLine());
        }

        public void AssignPrize()
        {
            PrizeDoor = _random.Next(1, 4);
        }

        public void ShouldSwitch()
        {
            Console.WriteLine("Do you want to switch door?[Y]es or [N]o?: ");
            wantToSwitch = (Console.ReadLine()).ToLower();
            

        }

        public void RevealDoor()
        {
            do
            {
                RevealedDoor = _random.Next(1, 4);
            } while (RevealedDoor == ChosenDoor || RevealedDoor == PrizeDoor);
            Console.WriteLine($"Door number {RevealedDoor} opens..... Its empty.");

        }

        public void SwitchDoor() 
        {
            switch (wantToSwitch)
            {
                case "y":
                    if (ChosenDoor == PrizeDoor)
                    {
                        Console.WriteLine("The door opens.....Its EMPTY!! You LOSE!!");
                    }
                    else
                    {
                        Console.WriteLine("The door opens..... You WON!!!");
                    }

                    break;

                case "n":
                    if (ChosenDoor==PrizeDoor)
                    {
                        Console.WriteLine("The door opens..... You WON!!!");
                    }

                    break;



            }

        }

    }
}
