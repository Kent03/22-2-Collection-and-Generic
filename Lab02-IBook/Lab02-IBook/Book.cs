using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_IBook
{
    internal class Class1
    {
        // xây dựng lớp book kế thừa từ IBook
        public class Book : IBook, IComparable<Book>
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int Year { get; set; }
            public string ISBN { get; set; }
            public List<string> Chapters { get; set; }

            public Book(string title, string author, string publisher, int year, string isbn, List<string> chapters)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                Year = year;
                ISBN = isbn;
                Chapters = chapters;
            }
            //compare to check chuỗi này đứng trước
            //(bé hơn) hay đứng sau (lớn hơn)
            //với chuỗi khác hay không
            public int CompareTo(Book other)
            {
                int result = Author.CompareTo(other.Author);
                if (result == 0)
                {
                    result = Title.CompareTo(other.Title);
                    if (result == 0)
                    {
                        result = Year.CompareTo(other.Year);
                    }
                }
                return result;
            }
        }
    }

}
