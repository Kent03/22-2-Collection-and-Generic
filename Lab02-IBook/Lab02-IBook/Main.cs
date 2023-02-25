using System;
using System.Collections.Generic;
using System.Text;
using static Lab02_IBook.BookListnew;
using static Lab02_IBook.Class1;
using static Lab02_IBook.Interface1;

namespace Lab02_IBook
{
    internal class MainBasic
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách các cuốn sách
            List<Book> books = new List<Book>
    {
        new Book("The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 1925, "9780684830421", new List<string> { "Chapter 1", "Chapter 2", "Chapter 3" }),
        new Book("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", 1960, "9780060935467", new List<string> { "Chapter 1", "Chapter 2", "Chapter 3" }),
      
    };

            // Thêm các cuốn sách vào danh sách
            BookList bookList = new BookList();
            foreach (Book book in books)
            {
                bookList.AddBook(book);
            };

            BookList BookList = new BookList();

            // Thêm các đối tượng Book vào bookList

            AuthorComparer authorComparer = new AuthorComparer();
            bookList.Sort(authorComparer);


            // Xuất danh sách các cuốn sách
            bookList.PrintBooks();

            // Sắp xếp và xuất danh sách các cuốn sách theo tên tác giả, tên sách, năm xuất bản
            bookList.SortByAuthor();
            Console.WriteLine("List of Books sorted by Author:");
            bookList.PrintBooks();

            bookList.SortByTitle();
            Console.WriteLine("List of Books sorted by Title:");
            bookList.PrintBooks();

            bookList.SortByYear();
            Console.WriteLine("List of Books sorted by Year:");
            bookList.PrintBooks();
        }
    
    }
}
