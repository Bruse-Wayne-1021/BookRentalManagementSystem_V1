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
        public Book() { }
        public int bookId {  get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public decimal rentalPrice { get; set; }


      





        public Book(int Bookid,string Title,string Author,decimal RentalPrice)
        {
            bookId=Bookid;
            title = Title;
            author = Author;
            rentalPrice=RentalPrice;
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
