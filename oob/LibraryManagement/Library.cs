using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public class Library
    {
        public string Name;
        public string Location;
        public static List<BookItem> BookItems = new List<BookItem>();

        public Library()
        {
            BookItems = new List<BookItem>();
        }

        public static bool AddBook(BookItem bookItem)
        {
            BookItems.Add((bookItem));
            return false;
        }

        public static bool UpdateBook(BookItem bookItem)
        {
            var book = BookItems.SingleOrDefault(b => b.ISBN.Equals((bookItem.ISBN)));
            if (book == null)
            {
                return false;
            }
            book.Title = bookItem.Title;
            book.Status = bookItem.Status;
            book.PlacedAt = bookItem.PlacedAt;
            book.PublicationDate = bookItem.PublicationDate;
              
            return false;
        }
        public static BookItem FindBookByBarcode(string barCode)
        {
            return BookItems.SingleOrDefault(t => t.BarCode.Equals(barCode));
        }
    }
}