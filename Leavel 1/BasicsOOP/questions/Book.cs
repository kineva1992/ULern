using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
    class Book : IComparable
    {
        public string Title;
        public int Theme;

        public int CompareTo(object obj)
        {
            Book book = obj as Book;

            if (Theme > book.Theme)
            {
                return 1;
            }

            else if (Theme == book.Theme)
            {
                return Title.CompareTo(book.Title);
            }

            else return -1;
        }

    }
}
