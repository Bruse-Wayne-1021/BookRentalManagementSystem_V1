using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook : Book
    {

        public PrintedBook() { }
        public int isbn {  get; set; }
        public int NumberOfPages { get; set; }

        public PrintedBook( int isbn, int numberOfPages)
        {
            this.isbn = isbn;
          this.  NumberOfPages = numberOfPages;
        }

        public string DisplayPrintedBookInfo()
        {
            return $" isbn : {isbn},NUmberOfPAges{NumberOfPages}";
        }


        public override string DisplayBooksInfo()
        {
            return $"{base.DisplayBooksInfo()},isbn : {isbn}, number of Pages :{NumberOfPages}";
        }
    }
}
