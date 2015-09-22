using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class WineItemCollection
    {
        WineItem[] wineItemArray;
        int lengthOfArray;

        //default constructor
        public WineItemCollection()
        {
            wineItemArray = new WineItem[4000];
            lengthOfArray = 0;
        }

        public void addWine(WineItem wine)
        {
            wineItemArray[lengthOfArray] = wine;
            lengthOfArray++;
        }

        public string getWineCollectionToString()
        {
            string fullOutput = "";
            foreach (WineItem wine in wineItemArray)
            {
                if (wine != null)
                {
                    fullOutput += wine.ToString() + Environment.NewLine;
                }
            }

            return fullOutput;
        }
    }
}
