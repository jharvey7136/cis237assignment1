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

        List<string> column1 = new List<string>();
        //List<string> column2 = new List<string>();
        //List<string> column3 = new List<string>();

        //string[] row1 = new string[4000];
        //string[] row2 = new string[4000];
        //string[] row3 = new string[4000];

        public CSVProcessor()
        {

            //StreamReader wineStream = new StreamReader("WineList.txt");

            //var column1 = new List<string>();
            //var column2 = new List<string>();
            //var column3 = new List<string>();
            

            //while (wineStream.Peek() != 1)
            //{
            //    var splits = new wineStream.ReadLine().Split(',');
            //    column1.Add(splits[0]);
            //    column2.Add(splits[1]);
            //    column3.Add(splits[2]);              
            //}


        }

        


        public void ReadDataToList()
        {

            StreamReader wineStream = new StreamReader("WineList.txt");

            //var column1 = new List<string>();
            //var column2 = new List<string>();
            //var column3 = new List<string>();

            //string[] wineID = new string[n];
            //string[] wineBrand = new string[n];
            //string[] wineSize = new string[n];            

            //StreamReader wineStream = new StreamReader("WineList.txt");


            while (!wineStream.EndOfStream)
            {
                var splits = wineStream.ReadLine().Split(',');
                column1.Add(splits[0].PadRight(10) + splits[1].PadRight(85) + splits[2]);
                //column2.Add(splits[1]);
                //column3.Add(splits[2]);

            }

            //while (!wineStream.EndOfStream)
            //{
            //    var splits = wineStream.ReadLine().Split(',');
            //    column1.Add(splits[0]);
            //    column2.Add(splits[1]);
            //    column3.Add(splits[2]);



            //    wineID = wineStream.ReadLine().Split(',');
            //    wineBrand = wineStream.ReadLine().Split(',');
            //    wineSize = wineStream.ReadLine().Split(',');
            //}


            //foreach (var element in column1)
            //    row1 = column1.ToArray();

            //foreach (var element in column2)
            //    row2 = column2.ToArray();
            
            //foreach (var element in column3)
            //    Console.WriteLine(element);


        }

        public void printList()
        {
            //StreamReader wineStream = new StreamReader("WineList.txt");


            //while (!wineStream.EndOfStream)
            //{
            //    var splits = wineStream.ReadLine().Split(',');
            //    column1.Add(splits[0]);
            //    column2.Add(splits[1]);
            //    column3.Add(splits[2]);

            //}
            



            Console.WriteLine("Column 1:");
            foreach (var element in column1)
                Console.WriteLine(element);
            //Console.WriteLine("Column 2:");
            //foreach (var element in column2)
            //    Console.WriteLine(element);
            //Console.WriteLine("Column 2:");
            //foreach (var element in column3)
            //    Console.WriteLine(element);
        }         



    }
}
