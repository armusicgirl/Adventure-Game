using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class NoteClass
    {
        private int noteID;
        private string noteNumber;
        private string noteTitle;
        private string noteMessage;

        public int NoteID
        {
            get
            {
                return noteID;
            }
            set
            {
                this.noteID = value;
            }
        }
        public string NoteNumber
        {
            get
            {
                return noteNumber;
            }
            set
            {
                this.noteNumber = value;
            }
        }
        public string NoteTitle
        {
            get
            {
                return noteTitle;
            }
            set
            {
                this.noteTitle = value;
            }
        }
        public string NoteMessage
        {
            get
            {
                return noteMessage;
            }
            set
            {
                this.noteMessage = value;
            }
        }

        
        public NoteClass(int noteID, string noteNumber, string noteTitle, string noteMessage)
        {
            this.NoteID = noteID;
            this.NoteNumber = noteNumber;
            this.NoteTitle = noteTitle;
            this.NoteMessage = noteMessage;
        }

        public NoteClass()
        {
            noteID = 0;
            noteNumber = "# 0";
            noteTitle = "Life";
            noteMessage = "Like a box of chocolates";
        }

        public override string ToString()
        {
            return noteNumber + "      " + noteTitle + "        " + noteMessage;
        }
    }
}
