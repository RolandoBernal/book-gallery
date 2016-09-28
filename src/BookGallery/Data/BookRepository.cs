using BookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookGallery.Data
{
    public class BookRepository
    {
        

        public Book[] GetBooks()
        {
            return Data.Books;
        }

        public Book GetBook(int id)
        {
            Book bookToReturn = null;

            foreach (var book in Data.Books)
            {
                if (book.Id == id)
                {
                    bookToReturn = book;

                    break;
                }

            }

            return bookToReturn;
        }

    }
}