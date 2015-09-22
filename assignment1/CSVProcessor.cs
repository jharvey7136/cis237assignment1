using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {

        WineItemCollection addingCollection = new WineItemCollection();

        public List<string> fullList = new List<string>();
        public List<string> wineID = new List<string>();
        public List<string> wineDescription = new List<string>();
        public List<string> winePack = new List<string>();

        public string[] fullListArray = new string[4000];
        public string[] wineIDArray = new string[4000];  
        public string[] wineDesArray = new string[4000];
        public string[] winePackArray = new string[4000];




        public CSVProcessor()
        {
            StreamReader wineStream = new StreamReader("WineList.txt");            

            while (!wineStream.EndOfStream)
            {
                var splits = wineStream.ReadLine().Split(',');
                fullList.Add(splits[0].PadRight(10) + splits[1].PadRight(85) + splits[2]);
                wineID.Add(splits[0].ToString().ToUpper());
                wineDescription.Add(splits[1].ToString().ToUpper());
                winePack.Add(splits[2].ToString().ToUpper());                

                fullListArray = fullList.ToArray();
                wineIDArray = wineID.ToArray();
                wineDesArray = wineDescription.ToArray();
                winePackArray = winePack.ToArray();
            }

        }


        public void CsvAddToCollection()
        {            
                WineItem row1 = new WineItem(fullListArray);
                addingCollection.addWine(row1);
        }



        public void PrintFullList()
        {
            WineItem FullListAdd = new WineItem(fullListArray);
            addingCollection.addWine(FullListAdd);
            Console.WriteLine(FullListAdd);
        }


        public void PrintPropertyTest()
        {
            for (int i = 0; i < 4000; i++)
                Console.WriteLine(WineIDProperty[i]);
        }
        

        public string[] WineIDProperty
        {
            get { return this.wineIDArray; }
            set { this.wineIDArray = value; }
        }

        public string[] WineDescriptProperty
        {
            get { return this.wineDesArray; }
            set { this.wineDesArray = value; }
        }

        public string[] WinePackProperty
        {
            get { return this.winePackArray; }
            set { this.winePackArray = value; }
        }
    }
}
