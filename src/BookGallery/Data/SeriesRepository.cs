using BookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookGallery.Data
{
    public class SeriesRepository
    {
        public Series[] GetSeries()
        {
            return Data.Series;
        }

        public Series GetSeriesDetail(int id)
        {
            Series seriesToReturn = null;

            foreach (var series in Data.Series)
            {
                if (series.Id == id)
                {
                    seriesToReturn = series;

                    break;
                }

            }

            if (seriesToReturn != null)
            {
                var books = new Book[0];
                foreach (var book in Data.Books)
                {
                    if (book.Series != null && book.Series.Id == id)
                    {
                        Array.Resize(ref books, books.Length + 1);
                        books[books.Length - 1] = book;
                    }
                }
                seriesToReturn.Issues = books;
            }

            return seriesToReturn;
        }
    }
}