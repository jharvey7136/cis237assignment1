using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class WineItem
    {

        //class variables
        private string[] wineID;
        private string[] wineDescription;
        private string[] winePack;
        private string[] rows;
        private string[] AddedWineID2;
        private string[] AddedWineDescript2;
        private string[] AddedWinePack2;
        

        //default constructor
        public WineItem()
        {
        }

        public WineItem(string[] rows)
        {
            this.Rows = rows;            
        }


        //3 parameter constructor
        public WineItem(string[] wItem, string[] wDescription, string[] wPack)
        {
            this.Wine = wItem;
            this.Description = wDescription;
            this.Pack = wPack;
        }



        public override string ToString()
        {
            return string.Join(Environment.NewLine, rows);
        }


        public void PrintFullList()
        {
            CSVProcessor csvProcessor = new CSVProcessor();
            for (int i = 0; i < 4000; i++)
                Console.WriteLine(csvProcessor.fullListArray[i]);
        }
        

        //properties
        public string[] Wine
        {
            get {  return this.wineID; }
            set { this.wineID = value; }
        }

        public string[] Description
        {
            get { return this.wineDescription; }
            set { this.wineDescription = value; }
        }
        public string[] Pack
        {
            get { return this.winePack; }
            set { this.winePack = value; }
        }

        public string[] Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }
        
        //added wine properties
        public string[] AddedWineID
        {
            get { return this.AddedWineID2; }
            set { this.AddedWineID2 = value; }
        }

        public string[] AddedWineDescript
        {
            get { return this.AddedWineDescript2; }
            set { this.AddedWineDescript2 = value; }
        }

        public string[] AddedWinePack
        {
            get { return this.AddedWinePack2; }
            set { this.AddedWinePack2 = value; }
        }
    }
}
