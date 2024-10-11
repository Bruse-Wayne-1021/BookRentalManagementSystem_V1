using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        private int bookId {  get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private decimal rentalPrice { get; set; }


        public string Gettitle(string title)
        {
            return title;
        }

        public int GetBookid(int bookId)
        {
            return bookId;
        }


        public string Getauthor(string author)
        {
            return author;
        }
        public  decimal GetRentalPrice(decimal rentalPrice)
        {
            return rentalPrice;
        }


        
        public void SetTitle(string Title)
        {
            title = Title;
        }

        public void SetBookid(int Bookid )
        {
            bookId = Bookid;
        }

        public void SetAuthor(string Author)
        {
            author = Author;
        }

        public void SetRentalPrice(decimal RentalPrice)
        {
            rentalPrice = RentalPrice;
        }





        public Book(int Bookid,string Title,string Author,decimal RentalPrice)
        {
            //bookId= Bookid;
            //title= Title;
            //author= Author;
            //rentalPrice = RentalPrice;
        }
        

        public override string ToString()
        {
            return $"Book id :{bookId}, Book title :{title} , Book Author :{author} , Rental price:{rentalPrice}";
        }
        

        public virtual string DisplayBooksInfo()
        {
            return $"Book id :{bookId}, Book title :{title} , Book Author :{author} , Rental price:{rentalPrice}";
        }

        
        
    }
}
