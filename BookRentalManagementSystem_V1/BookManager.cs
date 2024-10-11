using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        public BookManager()
        {
            booklist=new List<Book>();
        }
        public List<Book> booklist;


        public void CreateNewBook()
        {
            Console.WriteLine("Enter the Book Title");
            var title=Console.ReadLine();
            Console.WriteLine("Enter the Book Auhor");
            var author=Console.ReadLine();
            Console.WriteLine("Enter the Rental Price");
            var RentalPrice=decimal.Parse(Console.ReadLine());

            var newBook = new Book()
            {
                title = title,
                author = author,
                rentalPrice = RentalPrice,
            };

            this.booklist.Add(newBook);
            Console.WriteLine("Book Added successFully");


         
        }

        public void ReadAllbooks()
        {
            if(booklist.Count>0)
            {
                foreach(var book in booklist)
                {
                    Console.WriteLine(book);
                }
            }

            else
            {
                Console.WriteLine("No Books Available");
            }
        }


        public void UpdateBooks()
        {
            Console.WriteLine("Enter the book id");
            var Bookid=int.Parse(Console.ReadLine());
            var FindID=this.booklist.Where(b=>b.bookId==Bookid).FirstOrDefault();
            if (FindID != null)
            {
                this.booklist.Remove(FindID);
                Console.WriteLine("Enter the Book Title");
                var title = Console.ReadLine();
                Console.WriteLine("Enter the Book Auhor");
                var author = Console.ReadLine();
                Console.WriteLine("Enter the Rental Price");
                var RentalPrice = decimal.Parse(Console.ReadLine());


                var newBook = new Book()
                {
                    title = title,
                    author = author,
                    rentalPrice = RentalPrice
                };
                this.booklist.Add(newBook);
                Console.WriteLine("Book updated");



            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
        }


        public void DeleteBook()
        {
            Console.WriteLine("Enter the Book ID");
            var Id=int.Parse(Console.ReadLine());
            var FindID=this.booklist.Where(b=>b.bookId == Id).FirstOrDefault();
            if (FindID != null)
            {
                this.booklist.Remove(FindID);
                Console.WriteLine("Book Success Fully Deleted");
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
        }


    }
}
