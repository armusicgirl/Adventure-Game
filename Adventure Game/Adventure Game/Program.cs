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
            List<ItemClass> ItemClass = new List<ItemClass>();
            


            Room[] rooms = new Room[35]; // N, E, S, W, U, D
            //Hidden rooms
            rooms[31] = new Room(0, 10, 0, 0, 0, 0, "Vault", "Walls have china cabinets with jewerly in them." +
                " In the middle of the room sits a desk with a single piece of paper with writing");
            rooms[32] = new Room(1,21,16,1,22,30,"Tunnel","Lets see where this leads");
           // "♐✨🎵🏃", "  👌,🔥,🔫,📺,🍊,🍟,💯,♋,"
            rooms[33] = new Room(16, 16, 16, 16, 16, 16,"       ","                  ");

             //Shown Rooms
            rooms[1] = new Room(8, 2, 0, 10, 0, 0, "Entrance", "You Look Around," +
                " the house is a lot nicer on the inside. You turn to the south to go back out the door the house is a lot nicer on the inside. You turn to the south to go back out the door you came in from. That dare was too easy you think... but the door isn't opening: ");
            rooms[2] = new Room(7, 3, 0, 1, 22, 0, "Grand Stair Case", "Looking around there is beautiful artwork " +
                "on the walls, and not to mention the giant spiral staircase in the middle.");
            rooms[3] = new Room(0, 4, 0, 2, 0, 0, "Music Room", "A nice sitting room with an electronic piano playing 80's music");

            rooms[3].roomItem.Add(new ItemClass(1,"Key","A Shiny triangle shaped key",0,10));
            rooms[3].roomItem.Add(new ItemClass(2, "Dimond", "A precious gemstone", 5, 10));
            rooms[3].roomItem.Add(new ItemClass(3, "Shovel", "Useful For Digging", 0, 10));


            rooms[4] = new Room(6, 5, 0, 3, 0, 0, "Kitchen", "With lots of storage space, a huge fridge, and a double oven, this kitchen is definently nice.");	    
            rooms[5] = new Room(0, 0, 0, 4, 0, 0, "Pantry", "A small room with shelves of food");	           
            rooms[6] = new Room(15, 0, 4, 7, 0, 0, "Lunch Room", "A small round table sits in the middle of the room with five seats around it.");
            rooms[7] = new Room(14, 15, 7, 13, 0, 0, "Banquet Room", "You walk in and see a long rectangualar table with at least 10 seats");	   
            rooms[8] = new Room(13, 7, 1, 9, 0, 0, "Close Hall", "You are in the hall way");	          
            rooms[9] = new Room(12, 8, 10, 11, 0, 0, "Office", "A nice quiet room for working on projects");	            
            rooms[10] = new Room(9,1,0,31,0,0,"Library ","Around the room there are tall shelves of books. There is also a table with a game of chess set up in the northeastern corner");
            rooms[11] = new Room(21,9,0,0,0,0,"Sauna ", "A hot and humid room that smells of pine. The stove is in the corner of the wooden room surrounded by rocks. Time to relax!");
            rooms[12] = new Room(0,13,0,0,0,0,"Bathroom ", "Heated floors, jet bathtub, big shower what moer do you need?");
            rooms[13] = new Room(19,14,8,12,0,0,"Mid Hall ","A continuation of the close hall that branches to the side hall");
            rooms[14] = new Room(17,15,7,13,0,0,"Side Hall ","Another Hall way? Cool beans");
            rooms[15] = new Room(16,0,6,14,0,0,"Living Room "," A cosy coutch faces the fire place which on top of is the TV. There is a love seat and two chairs also.");
            rooms[16] = new Room(0,32,15,17,0,33,"Empty Room ","Thats odd. there is the door to the south and west, a photo to the east and an empty wall to the north");
            rooms[17] = new Room(0,16,14,18,0,0,"Play Room ","Kids toys EVERYWHERE");
            rooms[18] = new Room(0,17,0,19,0,0,"Bar ","The kids have a play room in the next room over, This is the adult play room, with games and alcohol");
            rooms[19] = new Room(0,18,13,20,0,0,"Far Hall","Looks like the end of the hall");
            rooms[20] = new Room(0,19,0,21,0,0,"Outdoor Grill","Lots of sitting space around the fire pit. THe grilling area is basically an outdoor kitchen");
            rooms[21] = new Room(0,20,11,0,0,0,"Pool","A long rectangular pool with a water slide and lounge chairs around it");
            rooms[22] = new Room(25,28,0,23,0,2,"UpStairs Landing","A nice open area with art on the walls");
            rooms[23] = new Room(24,22,0,0,0,0,"Twins Room","A set of bunkbeds with girlish beding, two desks, two dressers.");
            rooms[24] = new Room(0,25,23,0,0,0,"Kids Bathroom","Nice Light blue walls, bath, and sink");
            rooms[25] = new Room(0,0,22,24,0,0,"Boy's Room", "A bed, dresser and desk. The room is Fútbol themed");
            rooms[26] = new Room(0,27,28,0,0,0,"Master Bath", "Just as luxurious if not more so than the downstairs bathroom");
            rooms[27] = new Room(0,0,0,26,0,0,"Closet","A huge walk in closet with lots of shoes and clothing");
            rooms[28] = new Room(26,0,0,22,0,0,"Master Bed","A nice sized bedroom with a tv, dresser, bookshelf and two reading seats");

            int currentRoom = 1;
            string command = "";

            List<ItemClass> inventory = new List<ItemClass>();

            string commandString = Console.ReadLine().ToUpper();
            string[] stringSeparators = new string[] {" ",",","."};
            string[] commandWords = commandString.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);


            //Making objects for game
            foreach (string word in commandWords)
            {
                Console.WriteLine(word);
            }
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
                        if (rooms[currentRoom].roomItem.FindIndex(item => item.Name == commandWords[1] >= 0))
                        {
                            inventory.Add(rooms[currentRoom].roomItem.Find(item => item.Name == commandWords[1]));
                            rooms[currentRoom].roomItem.RemoveAt(rooms[currentRoom].roomItem.FindIndex(item => item.Name == commandWords[1]));
                            //inventory.Add(commandWords[1]);
                        }
                        else
                        {
                            Console.WriteLine("I do not see a " + commandWords[1] + " here!");
                        }
                    }
                    if (commandWords[0] == "DROP")
                    {
                        if (inventory.Contains(rooms[currentRoom].roomItem.FindIndex(item => item.Name == commandWords[1] >= 0)))
                        {
                            rooms[currentRoom].roomItem.Add(rooms[currentRoom].roomItem.Find(item => item.Name == commandWords[1]));
                            // rooms[currentRoom].roomItem.Add(commandWords[1]);
                            //inventory.Remove(commandWords[1]);
                            inventory.RemoveAt(rooms[currentRoom].roomItem.FindIndex(item => item.Name == commandWords[1]));
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


/*
       int curRoom = 0;
       List<string> invent = new List<string>();
       string commandString = "";
       char[] charseparators = new char[] { ' ', ',', '.' };
       do
       {
           Console.WriteLine(rooms[curRoom].visitRoom());
           Console.Write("Command (N,S,W,E,D,U,Q and possibly more )");
           commandString = Console.ReadLine().ToUpper();

           string[] commandWords = commandString.Split(charseparators, StringSplitOptions.RemoveEmptyEntries);

           if (commandWords.Length == 1)
           {
               if (commandString == "E" || commandString == "W" || commandString == "N" || commandString == "S" || commandString == "U" || commandString == "D")
               {
                   if (commandWords[0] == "E" && rooms[curRoom].ToEast >= 0)
                       curRoom = rooms[curRoom].ToEast;
                   else if (commandWords[0] == "W" && rooms[curRoom].ToWest >= 0)
                       curRoom = rooms[curRoom].ToWest;
                   else if (commandWords[0] == "N" && rooms[curRoom].ToNorth >= 0)
                       curRoom = rooms[curRoom].ToNorth;
                   else if (commandWords[0] == "S" && rooms[curRoom].ToSouth >= 0)
                       curRoom = rooms[curRoom].ToSouth;
                   else if (commandWords[0] == "U" && rooms[curRoom].ToUp >= 0)
                       curRoom = rooms[curRoom].ToUp;
                   else if (commandWords[0] == "D" && rooms[curRoom].ToDown >= 0)
                       curRoom = rooms[curRoom].ToDown;
                   else
                       Console.WriteLine("No obvious exits to the " + commandWords[0] + ".");
               }
               else if (commandWords[0].Length >= 3 && commandWords[0].Substring(0, 3) == "INV")
               {
                   Console.WriteLine("You are carrying the following items: ");
                   if (invent.Count == 0)
                   {
                       Console.WriteLine("nothing");
                   }
                   else
                   {
                       foreach (string item in invent)
                       {
                           Console.WriteLine(item);
                       }
                   }
               }
           }
           else if (commandWords.Length == 2)
           {
               if (commandWords[0] == "GET")
               {
                   if (rooms[curRoom].roomItems.Contains(commandWords[1]) == true)
                   {
                       rooms[curRoom].roomItems.Remove(commandWords[1]);
                       invent.Add(commandWords[1]);
                   }
                   else
                   {
                       Console.WriteLine("I do not see a " + commandWords[1] + " here!");
                   }
               }
               if (commandWords[0] == "DROP")
               {
                   if (invent.Contains(commandWords[1]) == true)
                   {
                       rooms[curRoom].roomItems.Add(commandWords[1]);
                       invent.Remove(commandWords[1]);
                   }
                   else
                   {
                       Console.WriteLine("I do not find " + commandWords[1] + " in your inventory!");
                   }
               }
           }
           else if (commandWords.Length == 3)
           {
               if (commandWords[0] == "UNLOCK")
               {
                   if (commandWords[1] == "WITH" && commandWords[2] == "KEY")
                   {
                       Console.WriteLine("You start unlocking!");
                       if (rooms[curRoom].ToEast <= 10)
                       {
                           Console.WriteLine("You've opened a door to the east!");
                           rooms[curRoom].ToEast = (rooms[curRoom].ToEast * -1) - 10;
                       }
                       if (rooms[curRoom].ToWest <= 10)
                       {
                           Console.WriteLine("You've opened a door to the West!");
                           rooms[curRoom].ToWest = (rooms[curRoom].ToWest * -1) - 10;
                       }
                       if (rooms[curRoom].ToNorth <= 10)
                       {
                           Console.WriteLine("You've opened a door to the North!");
                           rooms[curRoom].ToNorth = (rooms[curRoom].ToNorth * -1) - 10;
                       }
                       if (rooms[curRoom].ToSouth <= 10)
                       {
                           Console.WriteLine("You've opened a door to the South!");
                           rooms[curRoom].ToSouth = (rooms[curRoom].ToSouth * -1) - 10;
                       }
                   }
                   else
                   {
                       Console.WriteLine("You can not unlock this with " + commandWords[2] + " sorry!");
                   }
               }
               else if (commandWords[0] == "CLIMB")
               {
                   if (commandWords[1] == "WITH" && commandWords[2] == "LADDER")
                   {
                       Console.WriteLine("You start climbing!");
                       if (rooms[curRoom].ToUp <= -10)
                       {
                           Console.WriteLine("You've climbed up!");
                           curRoom = (rooms[curRoom].ToUp * -1) - 10;
                           invent.Remove(commandWords[2]);
                       }
                      if (rooms[curRoom].ToDown <= -10)
                       {
                           Console.WriteLine("You start climbing down!");
                           curRoom = (rooms[curRoom].ToDown * -1) - 10;
                           invent.Remove(commandWords[2]);
                       }
                   }
                   else
                   {
                       Console.WriteLine("You can not climb this with " + commandWords[2] + " sorry!");
                   }
               }
           }
       } while (commandString != "Q");
       Console.ReadKey();
   }
}
}
*/