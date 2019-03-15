using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] rooms = new Room[30]; // N, E, S, W, U, D
            rooms[1] = new Room(8, 2, 0, 10, 0, 0, "Entrance", "You Look Around," +
                " the house is a lot nicer on the inside. You turn to the south to go back out the door" +
                " you came in from. That dare was too easy you think... but the door isn't opening: ");
            rooms[2] = new Room(7, 3, 0, 1, 22, 0, "Grand Stair Case", "Looking around there is beautiful artwork " +
                "on the walls, and not to mention the giant spiral staircase in the middle.");
            rooms[3] = new Room(0, 4, 0, 2, 0, 0, "Music Room", "A nice sitting room with" +
                " an electronic piano playing 80's music");
            rooms[4] = new Room(6, 5, 0, 3, 0, 0, "Kitchen", "With lots of storage space, a huge fridge," +
                " and a double oven, this kitchen is definently nice.");
            rooms[5] = new Room(0, 0, 0, 4, 0, 0, "Pantry", "A small room with shelves of food");
            rooms[6] = new Room(15, 0, 4, 7, 0, 0, "Lunch Room", "A small round table sits in the middle of the room with five seats around it.");
            rooms[7] = new Room(14, 15, 7, 13, 0, 0, "Banquet Room", "You walk in and see a long rectangualar table with at least 10 seats");
            rooms[8] = new Room(13, 7, 1, 9, 0, 0, "Close Hall", "You are in the hall way");
            rooms[9] = new Room(12, 8, 10, 11, 0, 0, "Office", "A nice quiet room for working on projects");

            int currentRoom = 1;
            string command = "";

            List<string> inventory = new List<string>();
            string commandString = Console.ReadLine().ToUpper();
            string[] stringSeparators = new string[] {" ",",","."};
            string[] commandWords = commandString.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);


            //Making objects for game
            foreach (string word in commandWords)
            {
                Console.WriteLine(word);
            }
            List<string> items = new List<string>();
            items.Add("Key");
            items.Add("shovel");
            items.Add("dimond");
            Console.WriteLine("The list contains" + items.Count() + "items.");
            if(items.Contains("Key") == true)
            {
                Console.WriteLine("You have a Key!");
            }
            if (items.Contains("shovel") == true)
            {
                Console.WriteLine("You have a shovel!");
            }
            if (items.Contains("dimond") == true)
            {
                Console.WriteLine("You have a dimond!");
            }

            
            //Game Loop
            do
            {
                Console.WriteLine(rooms[currentRoom].visitRoom());
                Console.Write("Command (N,E,S,W,U,D,Q): ");
                command = Console.ReadLine().ToUpper();

                //Single letter Directrions
                if (commandWords.Length == 1 && command == "N" || command == "E" || command == "S" || command == "W" || command == "U" || command == "D")
                {
                    if (commandWords[0] == "N" & rooms[currentRoom].ToNorth != 0)
                    {
                        currentRoom = rooms[currentRoom].ToNorth;
                    }
                    else if (commandWords[0] == "E" & rooms[currentRoom].ToEast != 0)
                    {
                        currentRoom = rooms[currentRoom].ToEast;
                    }
                    else if (commandWords[0] == "S" & rooms[currentRoom].ToSouth != 0)
                    {
                        currentRoom = rooms[currentRoom].ToSouth;
                    }
                    else if (commandWords[0] == "W" & rooms[currentRoom].ToWest != 0)
                    {
                        currentRoom = rooms[currentRoom].ToWest;
                    }
                    else if (commandWords[0] == "U" & rooms[currentRoom].ToUp != 0)
                    {
                        currentRoom = rooms[currentRoom].ToUp;
                    }
                    else if (commandWords[0] == "D" & rooms[currentRoom].ToDown != 0)
                    {
                        currentRoom = rooms[currentRoom].ToDown;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, You can't go that way ");
                    }
                }
                //Move with full words
                else if (commandWords[0].Length == 1 && commandWords[0].Substring(0, 2) == "UP")
                {
                    if (commandWords.Length == 2 && command == "UP")
                    {
                        currentRoom = rooms[currentRoom].ToUp;
                    }
                }
                else if (commandWords[0].Length == 4)
                {
                    if (commandWords[0].Substring(0, 4) == "DOWN")
                    {
                        currentRoom = rooms[currentRoom].ToDown;
                    }
                    if (commandWords[0].Substring(0, 4) == "EAST")
                    {
                        currentRoom = rooms[currentRoom].ToEast;
                    }
                    else if (commandWords[0].Substring(0, 4) == "WEST")
                    {
                        currentRoom = rooms[currentRoom].ToWest;
                    }
                }
                else if (commandWords[0].Length == 5)
                {
                    if (commandWords[0].Substring(0, 5) == "NORTH")
                    {
                        currentRoom = rooms[currentRoom].ToNorth;
                    }
                    else if (commandWords[0].Substring(0, 5) == "SOUTH")
                    {
                        currentRoom = rooms[currentRoom].ToSouth;
                    }
                }

                //Object
                else if (commandWords.Length == 2)
                {
                    if (commandWords[0] == "GET")
                    {
                        if (rooms[currentRoom].roomItem.Contains(commandWords[1]) == true)
                        {
                            rooms[currentRoom].roomItem.Remove(commandWords[1]);
                            inventory.Add(commandWords[1]);
                        }
                        else
                        {
                            Console.WriteLine("I do not see a " + commandWords[1] + " here!");
                        }
                    }
                    if (commandWords[0] == "DROP")
                    {
                        if (inventory.Contains(commandWords[1]) == true)
                        {
                            rooms[currentRoom].roomItem.Add(commandWords[1]);
                            inventory.Remove(commandWords[1]);
                        }
                        else
                        {
                            Console.WriteLine("I do not find " + commandWords[1] + " in your inventory!");
                        }
                    }
                }
                else if(commandWords.Length == 3)
                {
                    if(commandWords[0] == "Unlock")
                    {
                        if(commandWords[1] == "With")
                        {
                            if ( commandWords[2] == "SHOVEL")
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }


                
            } while (command != "Q");

            Console.ReadKey();


        }
    }
}


     