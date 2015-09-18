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

        private int menu1Selection;
        private int menu2Selection;


        CSVProcessor csvProcessor = new CSVProcessor();
        

        public UserInterface()
        {
        }


        //public int Menu1Selection
        //{
        //    get { return menu1Selection; }
        //    set { menu1Selection = value; }
        //}

        //public int Menu2Selection
        //{
        //    get { return menu2Selection; }
        //    set { menu2Selection = value; }
        //}


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
                    if (menu1Selection != 1 || menu1Selection != 2)
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

            csvProcessor.ReadDataToList();

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
                        csvProcessor.printList();
                    }
                        
                    if (menu2Selection == 2)
                        Console.WriteLine("2 Selected");
                    if (menu2Selection == 3)
                        Console.WriteLine("3 Selected");
                    if (menu2Selection == 4)
                        Environment.Exit(0);
                    //if (menu2Selection != 1 || menu2Selection != 2 || menu2Selection != 3 || menu2Selection != 4)
                    //    Console.WriteLine("*Input Must Be Integer Between 1 - 4*\n");
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("*Input Must Be Integer Between 1 - 4*\n");
                }
            }
        }
    }
}
