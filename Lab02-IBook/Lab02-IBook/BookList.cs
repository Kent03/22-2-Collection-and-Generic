using System;
using System.Collections.Generic;
using System.Text;
using static Lab02_IBook.BookListnew;
using static Lab02_IBook.Class1;

namespace Lab02_IBook
{
    internal class BookListnew
    {
        // xây dựng lớp BookList để quản lý danh sách các cuốn sách
        public class BookList
        {
            private List<Book> books;

            public BookList()
            {
                books = new List<Book>();
            }

            public void AddBook(Book book)  //thêm sách
            {
                books.Add(book);
            }

            public void RemoveBook(Book book)  //xóa sách
            {
                books.Remove(book);
            }

            public void SortByAuthor()
            {
                books.Sort();
            }
            //sắp xếp chúng theo nhiều tiêu chí 
            public void SortByTitle()  // sxep theo tieu de
            {
                books.Sort((a, b) => a.Title.CompareTo(b.Title));
            }

            public void SortByYear()   //theo năm
            {
                books.Sort((a, b) => a.Year.CompareTo(b.Year));
            }
            public void Sort(IComparer<Book> comparer)
            {
                books.Sort(comparer);
            }

            public void PrintBooks()   //in ra sách
            {
                Console.WriteLine("List of Books:");
                foreach (Book book in books)
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Publisher: {book.Publisher}");
                    Console.WriteLine($"Year: {book.Year}");
                    Console.WriteLine($"ISBN: {book.ISBN}");
                    Console.WriteLine($"Chapters:");
                    foreach (string chapter in book.Chapters)
                    {
                        Console.WriteLine($"- {chapter}");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
    

}

