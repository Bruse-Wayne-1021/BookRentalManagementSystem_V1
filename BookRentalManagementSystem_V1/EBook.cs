using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook : Book
    {
        public EBook() { }
        public int FileSize { get; set; }
        public string Format {  get; set; }


        public EBook(int fileSize, string format)
            :base()
        {
            FileSize = fileSize;
            Format = format;
        }

        //public string DisplayDigitalBookInfo()
        //{
        //    return$"FileSize :{FileSize},Format :{Format}";
        //}


        public override string DisplayBooksInfo()
        {
            return $"{base.DisplayBooksInfo()}, FileSize: {FileSize} ,Format :{Format}";

        }


    }
}
