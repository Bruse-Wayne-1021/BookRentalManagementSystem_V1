using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mainmenu();
        }

        public static void Mainmenu()
        {
            var BookManager=new BookManager();
            while (true)
            {
                Console.WriteLine("1 . Add New Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3.Update Books");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an Option");


                var Input=Console.ReadLine();
                switch(Input)
                {
                    case "1":
                        BookManager.CreateNewBook();
                        break;
                    case "2":
                        BookManager.ReadAllbooks(); 
                        break;
                    case "3":
                        BookManager.UpdateBooks();
                        break;

                    case "4":
                        BookManager.DeleteBook();
                        break;
                    case "5":
                        Console.WriteLine("Thank you !!!");
                        return;
                        default:
                        Console.Clear();
                        Mainmenu();
                        break;

                }


            }
        }
    }
}
