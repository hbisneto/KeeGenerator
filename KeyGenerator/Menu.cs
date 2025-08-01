using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGenerator
{
    internal class Menu
    {
        public Menu() 
        {
            Console.WriteLine("[KeyGenerator]: Menu");
        }

        public int Options()
        {
            Console.WriteLine("[1] Create Key");
            Console.WriteLine("[2] Save Key");
            Console.WriteLine("[3] Copy Key to Clipboard");
            Console.WriteLine("[4] List Keys");
            Console.WriteLine("[0] Quit KeyGenerator");

            Console.WriteLine(">> Choose an option: ");

            string userOption = Console.ReadLine();

            int option = Convert.ToInt32(userOption);

            switch (option)
            {
                case 0:
                    Console.WriteLine("Key Generator is quitting...");
                    return 0;
                    break;
                case 1:
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;
            }


            if (option == 0) 
            {
                return 0;
            }

            return 0;
        }


    }
}
