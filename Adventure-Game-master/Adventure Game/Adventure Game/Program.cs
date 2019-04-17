using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{                   
    //ARIA RICHARDS
    //ROOM GAME
    class Program
    {
        static void Main(string[] args)
        {
            List<ItemClass> ItemClass = new List<ItemClass>();

            //MAP
            Room[] rooms = new Room[335]; // N, E, S, W, U, D
            //Hidden rooms
            rooms[31] = new Room(0, 10, 0, 0, 0, 0, "Vault:", "Walls have china cabinets with jewerly in them." +
                " In the middle of the room sits a desk with a single piece of paper, a note, with writing");
                     rooms[31].roomNote.Add(new NoteClass(3, "#3", "F", " I never knew we had all this. So sparkly!"));
            rooms[32] = new Room(1, 21, 16, 1, 22, 30, "Tunnel:", "Lets see where this leads");
            // "♐✨🎵🏃", "  👌,🔥,🔫,📺,🍊,🍟,💯,♋,"
            rooms[33] = new Room(36, 36, 36, 36, 36, 36, " ... ", "  Ginger  ");
            rooms[36] = new Room(0, 232, 15, 17, 0, 33, "Empty Room: ", "Thats odd. Why Lock an Empty Room?");


            //Shown Rooms
            rooms[1] = new Room(8, 2, 0, 10, 0, 0, "Entrance: ", "You Look Around," +
                " the house is a lot nicer on the inside. You turn to the south to go back out the door the house is a lot nicer on the inside. You turn to the south to go back out the door you came in from. That dare was too easy you think... but the door isn't opening: ");
            rooms[2] = new Room(7, 3, 0, 1, 22, 0, "Grand Stair Case: ", "Looking around there is beautiful artwork " +
                "on the walls, and not to mention the giant spiral staircase in the middle.");
            rooms[3] = new Room(0, 4, 0, 2, 0, 0, "Music Room: ", "A nice sitting room with an electronic piano playing 80's music");
                    //items
                    rooms[3].roomItem.Add(new ItemClass(1, "KEY", "A Shiny triangle shaped key", 0, 10));
                    rooms[3].roomItem.Add(new ItemClass(2, "DIAMOND", "A precious gemstone", 5, 10));
                    rooms[3].roomItem.Add(new ItemClass(3, "SHOVEL", "Useful For Digging", 0, 10));
            rooms[4] = new Room(6, 5, 0, 3, 0, 0, "Kitchen: ", "With lots of storage space, a huge fridge, and a double oven, this kitchen is definently nice.");
            rooms[5] = new Room(0, 0, 0, 4, 0, 0, "Pantry: ", "A small room with shelves of food. There is a piece of paper on the cookie jar, a note.");
                    rooms[5].roomNote.Add(new NoteClass(1, "#1", "L", " Darn, Someone ate my oreos! "));
            rooms[6] = new Room(15, 0, 4, 7, 0, 0, "Lunch Room: ", "A small round table sits in the middle of the room with five seats around it.");
            rooms[7] = new Room(14, 15, 7, 13, 0, 0, "Banquet Room: ", "You walk in and see a long rectangualar table with at least 10 seats");
            rooms[8] = new Room(13, 7, 1, 9, 0, 0, "Close Hall: ", "You are in the hall way");
            rooms[9] = new Room(12, 8, 10, 11, 0, 0, "Office: ", "A nice quiet room for working on projects");
            rooms[10] = new Room(9, 1, 0, 131, 0, 0, "Library: ", "Around the room there are tall shelves of books. There is also a table with a game of chess set up in the northeastern corner");
            rooms[11] = new Room(21, 9, 0, 0, 0, 0, "Sauna: ", "A hot and humid room that smells of pine. The stove is in the corner of the wooden room surrounded by rocks. Time to relax!");
            rooms[12] = new Room(0, 13, 0, 0, 0, 0, "Bathroom: ", "Heated floors, jet bathtub, big shower what moer do you need?");
            rooms[13] = new Room(19, 14, 8, 12, 0, 0, "Mid Hall: ", "A continuation of the close hall that branches to the side hall");
            rooms[14] = new Room(17, 15, 7, 13, 0, 0, "Side Hall: ", "Another Hall way? Cool beans");
            rooms[15] = new Room(236, 0, 6, 14, 0, 0, "Living Room: ", " A cosy coutch faces the fire place which on top of is the TV. There is a love seat and two chairs also.");

            rooms[17] = new Room(0, 236, 14, 18, 0, 0, "Play Room: ", "Kids toys EVERYWHERE");
            rooms[18] = new Room(0, 17, 0, 19, 0, 0, "Bar: ", "The kids have a play room in the next room over, This is the adult play room, with games and alcohol");
            rooms[19] = new Room(0, 18, 13, 20, 0, 0, "Far Hall: ", "Looks like the end of the hall");
            rooms[20] = new Room(0, 19, 0, 21, 0, 0, "Outdoor Grill: ", "Lots of sitting space around the fire pit. The grilling area is basically an outdoor kitchen");
            rooms[21] = new Room(0, 20, 11, 0, 0, 0, "Pool: ", "A long rectangular pool with a water slide and lounge chairs around it");
            rooms[22] = new Room(25, 28, 0, 23, 0, 2, "UpStairs Landing: ", "A nice open area with art on the walls");
            rooms[23] = new Room(24, 22, 0, 0, 0, 0, "Twins Room: ", "A set of bunkbeds with girlish beding, two desks, two dressers.");
            rooms[24] = new Room(0, 25, 23, 0, 0, 0, "Kids Bathroom: ", "Nice Light blue walls, bath, and sink. On the mirror is a piece of paper, a note.");
                     rooms[24].roomNote.Add(new NoteClass(2, "#2", "I", " I never knew we had all this. So sparkly!"));
            rooms[25] = new Room(0, 0, 22, 24, 0, 0, "Boy's Room: ", "A bed, dresser and desk. The room is Fútbol themed. On the bed you see a piece of paper, a note.");
                     rooms[25].roomNote.Add(new NoteClass(4, "#4", "E", " Wish you would've let me play soccer with you"));
            rooms[26] = new Room(0, 27, 28, 0, 0, 0, "Master Bath: ", "Just as luxurious if not more so than the downstairs bathroom");
            rooms[27] = new Room(0, 0, 0, 26, 0, 0, "Closet: ", "A huge walk in closet with lots of shoes and clothing, on the door you see a piece of paper, a note.");
                     rooms[24].roomNote.Add(new NoteClass(5, "#5", "S", " Time to play dress up!"));
            rooms[28] = new Room(26, 0, 0, 22, 0, 0, "Master Bed: ", "A nice sized bedroom with a tv, dresser, bookshelf and two reading seats");

            int currentRoom = 1;
            string command = "";

            List<ItemClass> inventory = new List<ItemClass>();

            //string commandString = Console.ReadLine().ToUpper();
            string[] charSeparators = new string[] { " ", ",", "." };



            //Making objects for game
            //foreach (string word in commandWords)
            //{
            //  Console.WriteLine(word);
            //}
            /* Console.WriteLine("The list contains" + ItemClass.Count() + "items.");
             if (ItemClass.Contains("Key") == true)
             {
                 Console.WriteLine("You have a Key!");
             }
             if (ItemClass.Contains("shovel") == true)
             {
                 Console.WriteLine("You have a shovel!");
             }
             if (ItemClass.Contains("dimond") == true)
             {
                 Console.WriteLine("You have a dimond!");
             }*/



            //Game Loop
            do
            {

                Console.WriteLine(rooms[currentRoom].visitRoom());
                Console.Write("Command (N,E,S,W,U,D,Q): ");

                command = Console.ReadLine().ToUpper();
                string[] commandWords = command.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                //Single letter Directrions
                if (commandWords.Length == 1)
                {
                    if (commandWords[0] == "N" || commandWords[0] == "E" || commandWords[0] == "S" || commandWords[0] == "W" || commandWords[0] == "U" || commandWords[0] == "D" ||
                        commandWords[0] == "NORTH" || commandWords[0] == "EAST" || commandWords[0] == "SOUTH" || commandWords[0] == "WEST" ||
                        commandWords[0] == "UP" || commandWords[0] == "Down")
                    {

                        if (commandWords[0] == "N" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100 ||
                            commandWords[0] == "NORTH" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToNorth;
                            Console.WriteLine();
                        }
                        else if (commandWords[0] == "E" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100 ||
                            commandWords[0] == "EAST" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100)
                        {
                            currentRoom = rooms[currentRoom].ToEast;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "S" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100 ||
                            commandWords[0] == "SOUTH" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToSouth;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "W" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100 ||
                            commandWords[0] == "WEST" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100)
                        {
                            currentRoom = rooms[currentRoom].ToWest;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "U" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100 ||
                            commandWords[0] == "UP" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100)
                        {
                            currentRoom = rooms[currentRoom].ToUp;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "D" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100 ||
                            commandWords[0] == "Down" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100)
                        {
                            currentRoom = rooms[currentRoom].ToDown;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, You can't go that way ");
                            Console.WriteLine();
                        }
                    }
                    else if (commandWords[0] == "SEARCH")
                    {
                        //Finds Hidden and Locked Rooms
                        if (rooms[currentRoom].ToNorth >= 100 && rooms[currentRoom].ToNorth <= 200)
                        {
                            Console.WriteLine("You have found a passage to the north, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth * -1;
                        }
                        if (rooms[currentRoom].ToEast >= 100 && rooms[currentRoom].ToEast <= 200)
                        {
                            Console.WriteLine("You have found a passage to the east, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToEast = rooms[currentRoom].ToEast * -1;
                        }
                        if (rooms[currentRoom].ToSouth >= 100 && rooms[currentRoom].ToSouth <= 200)
                        {
                            Console.WriteLine("You have found a passage to the south, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth * -1;
                        }
                        if (rooms[currentRoom].ToWest >= 100 && rooms[currentRoom].ToWest <= 200)
                        {
                            Console.WriteLine("You have found a passage to the west, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToWest = rooms[currentRoom].ToWest * -1;
                        }
                        if (rooms[currentRoom].ToUp >= 100 && rooms[currentRoom].ToUp <= 200)
                        {
                            Console.WriteLine("You have found an Upper passage, but it is locked");
                            Console.WriteLine();
                            Console.WriteLine();
                            rooms[currentRoom].ToUp = rooms[currentRoom].ToUp * -1;
                        }
                        if (rooms[currentRoom].ToDown >= 100 && rooms[currentRoom].ToDown <= 200)
                        {
                            Console.WriteLine("You have found a passage under the floor, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToDown = rooms[currentRoom].ToDown * -1;
                        }

                        //Finds Hidden Rooms
                        if (rooms[currentRoom].ToNorth >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth - 200;
                        }
                        if (rooms[currentRoom].ToEast >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToEast = rooms[currentRoom].ToEast - 200;
                        }
                        if (rooms[currentRoom].ToSouth >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth - 200;
                        }
                        if (rooms[currentRoom].ToWest >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToWest = rooms[currentRoom].ToWest - 200;
                        }
                        if (rooms[currentRoom].ToUp >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToUp = rooms[currentRoom].ToUp - 200;
                        }
                        if (rooms[currentRoom].ToDown >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToDown = rooms[currentRoom].ToDown - 200;
                        }
                    }
                    else if (commandWords[0] == "LOOK")
                    {
                        Console.WriteLine();
                        Console.WriteLine(rooms[currentRoom].RoomDescription);
                        Console.WriteLine();
                    }

                    else if (commandWords[0] == "HELP")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Type N, S, E, W, U, D to move through rooms");
                        Console.WriteLine("Search, Unlock With ____, Get ___, Drop ____, Read Note, Info ____, Dig With ____, inventory, look ");
                        Console.WriteLine();
                    }

                    //Command error catch
                    else if (commandWords[0] == "DIG")
                    {
                        Console.WriteLine();
                        Console.WriteLine("What would you like to dig WITH? ");
                        Console.WriteLine();
                    }

                    else if (commandWords[0] == "Unlock")
                    {
                        Console.WriteLine("What would you like to unlock that WITH? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "Get")
                    {
                        Console.WriteLine("What ITEM would you like to get? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "Drop")
                    {
                        Console.WriteLine("What ITEM would you like to drop? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "READ")
                    {
                        Console.WriteLine("What would you like to read? ");
                        Console.WriteLine();
                    }

                    // commands with at least three words
                    //check to see what you are carrying
                    else if (commandWords[0].Length >= 3 && commandWords[0].Substring(0, 3) == "INV")
                    {
                        Console.WriteLine("You are carrying the following Items: ");
                        Console.WriteLine();

                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Nothing");
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (ItemClass item in inventory)
                            {
                                Console.WriteLine(item.ItemName);
                            }
                            Console.WriteLine();

                        }

                    }
                }


                //Object
                else if (commandWords.Length == 2)
                {
                    if (commandWords[0] == "GET")
                    {
                        if (rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]) != null)
                        {
                            inventory.Add(rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]));
                            rooms[currentRoom].roomItem.Remove(rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]));
                            //inventory.Add(commandWords[1]);
                            Console.WriteLine("You picked up a(n) " + commandWords[1]);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("I do not see a " + commandWords[1] + " here!");
                            Console.WriteLine();
                        }
                    }
                    if (commandWords[0] == "DROP")
                    {
                        if (inventory.FindIndex(item => item.ItemName == commandWords[1]) >= 0)
                        {
                            rooms[currentRoom].roomItem.Add(inventory.Find(item => item.ItemName == commandWords[1]));
                            inventory.Remove(inventory.Find(item => item.ItemName == commandWords[1]));
                            Console.WriteLine("You dropped the " + commandWords[1]);
                        }
                        else
                        {
                            Console.WriteLine("There is not a " + commandWords[1] + "in your inventory!");
                            Console.WriteLine();

                        }
                    }
                    /*else if (commandWords[0] == "DROP")
                     {
                         if (inventory.Find(item => item.ItemName == commandWords[1]) != null)
                         {
                             rooms[currentRoom].roomItem.Add(rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]));
                             // rooms[currentRoom].roomItem.Add(commandWords[1]);
                             //inventory.Remove(commandWords[1]);
                             inventory.RemoveAt(rooms[currentRoom].roomItem.FindIndex(item => item.ItemName == commandWords[1]));
                         }

                         else
                         {
                             Console.WriteLine("I do not find " + commandWords[1] + " in your inventory!");
                             Console.WriteLine();
                         }
                     }*/
                    else if(commandWords[0] == "GO")
                    {
                        if (commandWords[1] == "N" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100 ||
                            commandWords[1] == "NORTH" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToNorth;
                            Console.WriteLine();
                        }
                        else if (commandWords[1] == "E" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100 ||
                            commandWords[1] == "EAST" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100)
                        {
                            currentRoom = rooms[currentRoom].ToEast;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "S" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100 ||
                            commandWords[1] == "SOUTH" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToSouth;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "W" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100 ||
                            commandWords[1] == "WEST" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100)
                        {
                            currentRoom = rooms[currentRoom].ToWest;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "U" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100 ||
                            commandWords[1] == "UP" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100)
                        {
                            currentRoom = rooms[currentRoom].ToUp;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "D" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100 ||
                            commandWords[1] == "Down" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100)
                        {
                            currentRoom = rooms[currentRoom].ToDown;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, You can't go that way ");
                            Console.WriteLine();
                        }
                    
                    }
                    else if (commandWords[0] == "INFO" && commandWords[1] == "SHOVEL")
                    {
                        Console.WriteLine();
                        Console.WriteLine("SHOVEL: Useful For Digging");
                        Console.WriteLine();

                    }

                    else if (commandWords[0] == "INFO" && commandWords[1] == "KEY")
                    {
                        Console.WriteLine();
                        Console.WriteLine("KEY: A Shiny triangle shaped key");
                        Console.WriteLine();

                    }
                    else if (commandWords[0] == "INFO" && commandWords[1] == "DIAMOND")
                    {
                        Console.WriteLine();
                        Console.WriteLine("DIAMOND: A precious gemstone");
                        Console.WriteLine();
                    }

                    else if (commandWords[0] == "READ" && commandWords[1] == "NOTE")
                    {
                        Console.WriteLine(rooms[currentRoom].ReadNote());
                        Console.WriteLine();
                    }
                }
                else if (commandWords.Length == 3)
                {
                    if (commandWords[0] == "UNLOCK")
                    {
                        if (commandWords[1] == "WITH")
                        {
                            if (commandWords[2] == "KEY")
                            {
                                if (inventory.Contains(inventory.Find(item => item.ItemName == "KEY")))
                                {
                                    if (rooms[currentRoom].ToNorth > -200 && rooms[currentRoom].ToNorth < 0 )
                                    {
                                        Console.WriteLine("You Unlock the North door and can go through");
                                        rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth * -1;
                                        rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth -100;
                                        Console.WriteLine();
                                    }
                                    if (rooms[currentRoom].ToEast > -200 && rooms[currentRoom].ToEast < 0 )
                                    {
                                        Console.WriteLine("You Unlock the East door and can go through");
                                        rooms[currentRoom].ToEast = rooms[currentRoom].ToEast * -1;
                                        rooms[currentRoom].ToEast = rooms[currentRoom].ToEast -100;
                                        Console.WriteLine();
                                    }
                                    if (rooms[currentRoom].ToSouth > -200 && rooms[currentRoom].ToSouth < 0 )
                                    {
                                        Console.WriteLine("You Unlock the South door and can go through");
                                        rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth * -1;
                                        rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth -100;
                                        Console.WriteLine();
                                    }
                                    if (rooms[currentRoom].ToWest > -200 && rooms[currentRoom].ToWest < 0)
                                    {
                                        Console.WriteLine("You Unlock the West door and can go through");
                                        rooms[currentRoom].ToWest = rooms[currentRoom].ToWest * -1;
                                        rooms[currentRoom].ToWest = rooms[currentRoom].ToWest -100;
                                        Console.WriteLine();
                                    }
                                    if (rooms[currentRoom].ToUp > -200 && rooms[currentRoom].ToUp < 0)
                                    {
                                        Console.WriteLine("You Unlock an Upper door and can go through");
                                        Console.WriteLine();
                                        rooms[currentRoom].ToUp = rooms[currentRoom].ToUp * -1;
                                        rooms[currentRoom].ToUp = rooms[currentRoom].ToUp - 100;
                                    }
                                    if (rooms[currentRoom].ToDown > -200 && rooms[currentRoom].ToDown < 0)
                                    {
                                        Console.WriteLine("You Unlock a door on the floor and can go through");
                                        Console.WriteLine();
                                        rooms[currentRoom].ToDown = rooms[currentRoom].ToDown * -1;
                                        rooms[currentRoom].ToDown = rooms[currentRoom].ToDown - 100;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You Need to get a Key");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Can only unlock with a Key");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("UNLOCK + WITH + ITEM ");
                            Console.WriteLine();
                        }
                    }
                   else if(commandWords[0] == "DIG")
                    {
                        if (commandWords[1] == "With")
                        {
                            if (commandWords[2] == "SHOVEL")
                            {
                                if (inventory.Contains(inventory.Find(item => item.ItemName == "SHOVEL")))
                                {
                                    Console.WriteLine("You Dig");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("You Need to get a shovel");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Can only DIG with a SHOVEL");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dig + WITH + ITEM ");
                            Console.WriteLine();
                        }
                    }
                }
            } while (command != "Q") ;
                Console.ReadKey();

        }
    }
}
