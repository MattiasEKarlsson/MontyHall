using System;

namespace Shouldswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 10000;
            int shouldSwitchCount = 0;
            var montyHall = new MontyHall();

            for (int i = 0; i < count; i++)
            {
                montyHall.AssignPrize();
                montyHall.SelectedDoor();
                montyHall.RevealDoor();

                if (montyHall.ShouldSwitch())
                {
                    shouldSwitchCount++;
                }
               
            }

            Console.WriteLine(count);
            Console.WriteLine(shouldSwitchCount);
        }

        public class MontyHall 
        {
            private Random _random = new Random();
            public int PrizeDoor { get; set; }
            public int ChosenDoor { get; set; }
            public int RevealdeDoor { get; set; }


            public bool ShouldSwitch() 
            {

                return PrizeDoor != ChosenDoor;
            
            }

            public void RevealDoor() 
            {
                do
                {
                    RevealdeDoor = _random.Next(1, 4);
                } while (RevealdeDoor==ChosenDoor|| RevealdeDoor==PrizeDoor);
            
            }

            public void SelectedDoor() 
            {
                ChosenDoor = _random.Next(1,4);
            
            }
            public void AssignPrize()
            {
                PrizeDoor = _random.Next(1, 4);

            }


        }
    }
}
