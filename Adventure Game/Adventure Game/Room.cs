﻿using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            if(this.toNorth >= 1 && this.toNorth <= 100)
            {
                info += "N ";
            }
            if (this.toEast >= 1 && this.toEast <= 100)
            {
                info += "E ";
            }
            if (this.toSouth >= 1 && this.toSouth <= 100)
            {
                info += "S ";
            }
            if (this.toWest >= 1 && this.toWest <= 100)
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

            if(this.roomItem.Count > 0)
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

