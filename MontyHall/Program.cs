using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int prizedoor = random.Next(1, 4);        // Prizedoor is randomized.
            int playerdoor = 0;
            top:
            try
            {   zzz:
                Console.Write("Choose door [1], door [2] or door [3]: ");    // Player choose a door.
                playerdoor = Convert.ToInt32(Console.ReadLine());
                if (playerdoor>=4)
                {
                    goto zzz;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto top;
            }
           

            one:
            try
            {
                if (playerdoor == 1 && prizedoor == 1)
                {
                    int openrandom = random.Next(2, 4);
                    Console.WriteLine($"Door {openrandom} opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        if (openrandom == 2)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }
                        else if (openrandom == 3)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }

                    }
                    else
                        Console.WriteLine("You WON!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto one;
            }

            two:
            try
            {
            
                if (playerdoor == 1 && prizedoor == 2)
                {

                    Console.WriteLine($"Door 3 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto two;
            }

            tree:
            try
            {
                if (playerdoor == 1 && prizedoor == 3)
                {

                    Console.WriteLine($"Door 2 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                goto tree;
            }

            four:
            try
            {
                if (playerdoor == 2 && prizedoor == 1)
                {

                    Console.WriteLine($"Door 3 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto four;
            }

            five:
            try
            {
                if (playerdoor == 2 && prizedoor == 3)
                {

                    Console.WriteLine($"Door 1 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto five;
            }

            six:
            try
            {
                if (playerdoor == 2 && prizedoor == 2)
                {
                    int openrandom = random.Next(1, 4);
                xxx:
                    if (openrandom == 2)
                    {
                        goto xxx;
                    }
                    Console.WriteLine($"Door {openrandom} opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        if (openrandom == 1)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }
                        else if (openrandom == 3)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }

                    }
                    else
                        Console.WriteLine("You WON!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto six;
               
            }

            seven:
            try
            {
                if (playerdoor == 3 && prizedoor == 3)
                {
                    int openrandom = random.Next(1, 4);
                xxx:
                    if (openrandom == 3)
                    {
                        goto xxx;
                    }
                    Console.WriteLine($"Door {openrandom} opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        if (openrandom == 1)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }
                        else if (openrandom == 2)
                        {
                            Console.WriteLine("Its empty, you LOSE!!");
                        }

                    }
                    else
                        Console.WriteLine("You WON!!!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                goto seven;
            }

            eight:
            try
            {
                if (playerdoor == 3 && prizedoor == 1)
                {

                    Console.WriteLine($"Door 2 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto eight;
            }

            nine:
            try
            {
                if (playerdoor == 3 && prizedoor == 2)
                {

                    Console.WriteLine($"Door 1 opens, it empty.");
                    Console.WriteLine();
                    Console.Write("Do u want to swith door?[y/n): ");
                    string open2door = Console.ReadLine();
                    if (open2door == "y")
                    {
                        Console.WriteLine("You WON!!");

                    }
                    else
                        Console.WriteLine("You LOSE!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto nine;
            }
            

            
        }
        
    }
}
