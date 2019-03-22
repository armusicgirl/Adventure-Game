using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class ItemClass
    {
        private int itemNumber;
        private string itemName;
        private string itemDescription;
        private int itemValue;
        private int itemWearLevel;

        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                this.itemNumber = value; 
            }
        }
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                this.itemName = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                this.itemDescription = value;
            }
        }
        public int ItemValue
        {
            get
            {
                return itemValue;
            }
            set
            {
                this.itemValue = value;
            }
        }
        public int ItemWearLevel
        {
            get
            {
                return itemWearLevel;
            }
            set
            {
                this.itemWearLevel = value;
            }
        }

        public ItemClass(int itemNumber, string itemName, string itemDescription, int itemValue, int itemWhearLevel)
        {
            this.ItemNumber = itemNumber;
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
            this.ItemValue = itemValue;
            this.ItemWearLevel = itemWhearLevel;
        }

        public ItemClass()
        {
            itemNumber = 50;
            itemName = "Paper" ;
            itemDescription = "Thin white sheet, light as a feather";
            itemValue = 0;
            itemWearLevel = 1;
        }
    }
}
