using System;
using System.Collections.Generic;
using System.Text;

namespace DataIntegrity.Data
{
    class Book
    {
        public string Title { get; set; }

        public static void Check()
        {
            var book = new Book();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }
    }
}
