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
            Room[] rooms = new Room[35]; // N, E, S, W, U, D
            //Hidden rooms
            rooms[31] = new Room(0, 10, 0, 0, 0, 0, "Vault", "Walls have china cabinets with jewerly in them." +
                " In the middle of the room sits a desk with a single piece of paper with writing");
            rooms[32] = new Room(1,21,16,1,22,30,"Tunnel","Lets see where this leads");
           // "♐✨🎵🏃", "  👌,🔥,🔫,📺,🍊,🍟,💯,♋,"
            rooms[33] = new Room(16, 16, 16, 16, 16, 16,"       ","                  ");

            //Shown Rooms
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
            rooms[6] = new Room(15, 0, 4, 7, 0, 0, "Lunch Room ", "A small round table sits in the middle of the room with five seats around it.");
            rooms[7] = new Room(14, 6, 2, 8, 0, 0, "Banquet Room ", "You walk in and see a long rectangualar table with at least 10 seats");
            rooms[8] = new Room(13, 7, 1, 9, 0, 0, "Close Hall ", "You are in the hall way");
            rooms[9] = new Room(12, 8, 10, 11, 0, 0, "Office ", "A nice quiet room for working on projects");
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

            int currentRoom = 15;
            string command = "";
            do
            {
                Console.WriteLine(rooms[currentRoom].visitRoom());
                Console.Write("Command (N,E,S,W,U,D,Q): ");
                command = Console.ReadLine().ToUpper();
                if (command == "N" || command == "E" || command == "S" || command == "W" || command == "U" || command == "D")
                {
                    if (command == "N" & rooms[currentRoom].ToNorth != 0)
                    {
                        currentRoom = rooms[currentRoom].ToNorth;
                    }
                    else if (command == "E" & rooms[currentRoom].ToEast != 0)
                    {
                        currentRoom = rooms[currentRoom].ToEast;
                    }
                    else if (command == "S" & rooms[currentRoom].ToSouth != 0)
                    {
                        currentRoom = rooms[currentRoom].ToSouth;
                    }
                    else if (command == "W" & rooms[currentRoom].ToWest != 0)
                    {
                        currentRoom = rooms[currentRoom].ToWest;
                    }
                    else if (command == "U" & rooms[currentRoom].ToUp != 0)
                    {
                        currentRoom = rooms[currentRoom].ToUp;
                    }
                    else if (command == "D" & rooms[currentRoom].ToDown != 0)
                    {
                        currentRoom = rooms[currentRoom].ToDown;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, You can't go that way ");
                    };
                }
            } while (command != "Q");


        }
    }
}
