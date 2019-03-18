using System.Linq;

namespace Adventure_Game
{
    class Room
    {
        private int roomNumber;
        private string roomName;
        private string roomDescription;
        private int toNorth;
        private int toEast;
        private int toSouth;
        private int toWest;
        private int toUp;
        private int toDown;
        private bool visited;
        public List<ItemClass> roomItem = new List<ItemClass>();

        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                this.roomNumber = value;
            }
        }
        public string RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                this.roomName = value;
            }
        }

        public string RoomDescription
        {
            get
            {
                return roomDescription;
            }
            set
            {
                this.roomDescription = value;
            }
        }
        public int ToNorth
        {
            get
            {
                return toNorth;
            }
            set
            {
                this.toNorth = value;
            }
        }
        public int ToEast
        {
            get
            {
                return toEast;
            }
            set
            {
                this.toEast = value;
            }
        }
        public int ToSouth
        {
            get
            {
                return toSouth;
            }
            set
            {
                this.toSouth = value;
            }
        }
        public int ToWest

        {
            get
            {
                return toWest;
            }
            set
            {
                this.toWest = value;
            }
        }
        public int ToUp
        {
            get
            {
                return toUp;
            }
            set
            {
                this.toUp = value;
            }
        }
        public int ToDown
        {
            get
            {
                return toDown;
            }
            set
            {
                this.toDown = value;
            }
        }
        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                this.visited = value;
            }
        }

  

        public Room( int toNorth, int toEast, int toSouth, int toWest, int toUp, int toDown,
            string roomName, string roomDescription)
        {
            this.RoomName = roomName;
            this.RoomDescription = roomDescription;
            this.ToNorth = toNorth;
            this.ToEast = toEast;
            this.ToSouth = toSouth;
            this.ToWest = toWest;
            this.ToUp = toUp;
            this.ToDown = toDown;
            this.Visited = false;
        }

        //public string roomItem()
        //{

        //}
        public string visitRoom()
        {
            string info = roomName;
            if(visited != true)
            {
                visited = true;
                info += " " + roomDescription;
            }
            info += " You See an Exit to the: ";
            if(this.toNorth >= 1)
            {
                info += "N ";
            }
            if (this.toEast >= 1)
            {
                info += "E ";
            }
            if (this.toSouth >= 1)
            {
                info += "S ";
            }
            if (this.toWest >= 1)
            {
                info += "W ";
            }
            if (this.toUp >= 1)
            {
                info += "U ";
            }
            if (this.toDown >= 1)
            {
                info += "D ";
            }

            if(this.roomItem.Count >= 0)
            {
                info += "\n In the room you see:";
                foreach(ItemClass item in roomItem)
                {
                    info += item.ItemName + " ";
                }
            }

            return info;
        }

    }
}
/*using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure
{
    class Room
    {
        private string name;
        private string description;
        private int roomNum;
        private int toNorth;
        private int toSouth;
        private int toWest;
        private int toEast;
        private int toDown;
        private int toUp;
        private bool visited;
        public List<string> roomItems = new List<string>();



        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int RoomNum { get => roomNum; set => roomNum = value; }
        public int ToNorth { get => toNorth; set => toNorth = value; }
        public int ToSouth { get => toSouth; set => toSouth = value; }
        public int ToWest { get => toWest; set => toWest = value; }
        public int ToEast { get => toEast; set => toEast = value; }
        public int ToDown { get => toDown; set => toDown = value; }
        public int ToUp { get => toUp; set => toUp = value; }
        public bool Visited { get => visited; set => visited = value; }

        public Room(string name, string description, int toNorth, int toSouth, int toWest, int toEast, int toDown, int toUp)
        {
            this.Name = name;
            this.Description = description;
            this.ToNorth = toNorth;
            this.ToSouth = toSouth;
            this.ToWest = toWest;
            this.ToEast = toEast;
            this.ToDown = toDown;
            this.ToUp = toUp;
            this.Visited = false;

        }

        public string visitRoom()
        {
            string info = Name;
            if (Visited == false)
            {
                Visited = true;
                info += ": " + Description;
            }

            info += "\nObvious Exits Are: ";
            if (this.toEast >= 0)
                info += " E ";
            if (this.toWest >= 1)
                info += " W ";
            if (this.toNorth >= 1)
                info += " N ";
            if (this.toSouth >= 1)
                info += " S ";
            if (this.toUp >= 1)
                info += " U ";
            if (this.toDown >= 1)
                info += " D ";

            if (this.ToEast <= -10)
                info += "\nTo the east the door looks locked.";
            if (this.ToWest <= -10)
                info += "\nTo the west the door looks locked.";
            if (this.ToNorth <= -10)
                info += "\nTo the north the door looks locked.";
            if (this.ToSouth <= -10)
                info += "\nTo the south the door looks locked.";
            if (this.ToUp <= -10)
                info += "\nLooks like you are able to use this ladder to climb here!";

            if (this.roomItems.Count > 0)
            {
                info += "\nIn the room you see: ";
                foreach (string item in roomItems)
                {
                    info += item + " ";
                }
            }
            return info;
        }
    }
}*/