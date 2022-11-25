using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controller
{
    public class LibraryController
    {
        public static void GetAll()
        {
            var libraries = Add();

            foreach (var library in libraries)
            {
                foreach (var book in library.Books)
                {
                    Console.WriteLine(book.Name);
                }
            }


        }
        public static List<Book> GetAllBooksByLIbrary(Predicate<Book> predicate)
        {
            var result = GetAllBooks();

            return result.FindAll(predicate);
        }


        private static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book()
            {
                Name = "Xosrov",
                Author = "Nizami",
                LibraryId = 1,
            };
            Book book2 = new Book()
            {
                Name = "Sirin",
                Author = "Nizami",
                LibraryId = 2,
            };
            Book book3 = new Book()
            {
                Name = "Sikayetname",
                Author = "Fizuli",
                LibraryId = 2,
            };
            Book book4 = new Book()
            {
                Name = "Dede Qorqud",
                Author = "YYY",
                LibraryId = 2,
            };
            Book book5 = new Book()
            {
                Name = "Yeddi gozel",
                Author = "Nizami",
                LibraryId = 2,
            };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            return books;
        }



        private static List<Library> Add()
        {
            List<Library>libraries= new List<Library>(); 
         
            Book book1 = new Book()
            {
                Name = "Xosrov",
                Author = "Nizami",
                LibraryId= 1,
            };
            Book book2 = new Book()
            {
                Name = "Sirin",
                Author = "Nizami",
                LibraryId = 2,
            };
            Book book3= new Book()
            {
                Name = "Sikayetname",
                Author = "Fizuli",
                LibraryId = 2,
            };
            Book book4 = new Book()
            {
                Name = "Dede Qorqud",
                Author = "YYY",
                LibraryId = 2,
            };
            Book book5 = new Book()
            {
                Name = "Yeddi gozel",
                Author = "Nizami",
                LibraryId = 2,
            };

            List<Book> books1 = new List<Book> { book1, book2, book3, book4 };

            List<Book> books2 = new List<Book> { book3, book4, book5 };

            Library library1 = new Library()
            {
                Id = 1,
                Name = "Axundov",
                Books = books1,

            };
            Library library2 = new Library()
            {
                Id = 2,
                Name = "Baku book center",
                Books = books2,
            };

            libraries.Add(library1);
            libraries.Add(library2);


            return libraries;

        }
    }
}
