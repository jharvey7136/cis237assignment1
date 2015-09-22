using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class UserInterface
    {        
        CSVProcessor csvProcessor = new CSVProcessor();
        WineItem wineItem = new WineItem();
        WineItemCollection fullCollection = new WineItemCollection();

        private int menu1Selection;
        private int menu2Selection;        
        private string searchTarget;

        public string[] addedWineArray = new string[5];
        public string[] freshArray = new string[4000];

        public UserInterface()
        {
        }


        public void MainMenu()
        {

            while (menu1Selection != 1 || menu1Selection != 2)
            {
                Console.WriteLine("WINE LIST MAIN MENU\n");
                Console.WriteLine("\t1 - Load Wine List\n");
                Console.WriteLine("\t2 - Exit\n");
                Console.Write("Enter Number: ");
                try
                {
                    menu1Selection = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (menu1Selection == 1)
                    {                        
                        WineListLoaded();
                    }
                    if (menu1Selection == 2)
                        Environment.Exit(0);
                    if (menu1Selection > 2 || menu1Selection < 1)
                        Console.WriteLine("*Input Must Be Integer 1 or 2*\n");
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("*Input Error*\n");
                }
            }
        }


        public void WineListLoaded()
        {
            csvProcessor.CsvAddToCollection();

            while (menu2Selection != 1 || menu2Selection != 2 || menu2Selection != 3 || menu2Selection != 4)
            {
                Console.WriteLine("WINE LIST LOADED\n");
                Console.WriteLine("\t1 – Print Wine List\n");
                Console.WriteLine("\t2 – Search For Item By ID\n");
                Console.WriteLine("\t3 – Add Wine To List\n");
                Console.WriteLine("\t4 – Exit\n");
                Console.Write("Enter Number: ");

                try
                {
                    menu2Selection = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (menu2Selection == 1)
                    {
                        csvProcessor.PrintFullList();
                        Console.WriteLine();
                    }

                    if (menu2Selection == 2)
                    {
                        SearchForMatch();
                    }
                    if (menu2Selection == 3)
                    {

                        AddWine();


                    }
                    if (menu2Selection == 4)
                        Environment.Exit(0);
                    if (menu2Selection > 4 || menu2Selection < 1)
                        Console.WriteLine("*Input Must Be Integer Between 1 - 4*\n");
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("*Input Error*\n");
                }
            }
        }


        public void SearchForMatch()
        {
            Console.WriteLine();
            Console.Write("Enter Wine ID: ");
            searchTarget = Console.ReadLine().ToString().ToUpper();
            Console.WriteLine();

            string subscript;

            subscript = Search(csvProcessor.wineIDArray, searchTarget);
                if (subscript == "No Match")
                    Console.WriteLine("No Match Found\n");
                else
                    Console.WriteLine(subscript);
        }

        public string Search(string[] array, string target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return array[i].PadRight(10) + csvProcessor.wineDesArray[i].PadRight(85) + csvProcessor.winePackArray[i] + Environment.NewLine;
            }
            return "No Match";
        }


        public void AddWine()
        {
            Console.Write("Enter Wine ID: ");
            addedWineArray[0]  = Console.ReadLine().ToString().ToUpper();

            Console.Write("Enter Wine Description: ");
            addedWineArray[1] = Console.ReadLine().ToString();

            Console.Write("Enter Wine Pack: ");
            addedWineArray[2] = Console.ReadLine().ToString();

            int length;
            length = csvProcessor.fullListArray.Length;          

            for (int i = 0; i < length; i++)
            {
                freshArray[i] = csvProcessor.fullListArray[i];
            }

            freshArray[length] = addedWineArray[0].PadRight(10) + addedWineArray[1].PadRight(85) + addedWineArray[2];
            length++;

            int userInput;
            Console.WriteLine();
            Console.WriteLine("Wine Has Been Added to Bottom. \n");
            Console.WriteLine("1: Print Fresh List\n");
            Console.WriteLine("2: Main Wine Menu\n");
            Console.WriteLine("3: Exit\n");
            userInput = int.Parse(Console.ReadLine());
           
            if (userInput == 1)
                
                for (int i = 0; i < freshArray.Length; i++)
                {
                    Console.WriteLine(freshArray[i]);
                }
            if (userInput == 2)
            {                
                WineListLoaded();
            }
            if (userInput == 3)
            {                
                Environment.Exit(0);
            }
        }
    }
}
