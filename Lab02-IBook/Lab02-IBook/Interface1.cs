using System;
using System.Collections.Generic;
using System.Text;
using static Lab02_IBook.Class1;

namespace Lab02_IBook
{
    internal interface Interface1
    {
        public class AuthorComparer : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                return x.Author.CompareTo(y.Author);
            }
        }

    }
}
