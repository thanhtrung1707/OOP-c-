using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace LibraryManagement
{
    class Member : Account
    {
        public DateTime DateOfMembership;
        public int TotalBooksCheckout;
        private ISearch _iSearch;
        private LibraryCard _libraryCard;

        public Member(ISearch iSearch)
        {
            _iSearch = iSearch;
            
        }
        
        public List<Book> SearchBookByTitle(string title)
        {
            return _iSearch.SearchByTitle(title);
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            return _iSearch.SearchByTitle(author);
        }

        public bool ReserveBookItem(BookItem bookItem)
        {
            if (bookItem.Status == BookStatus.Availabe)
            {
                bookItem.UpdateStatus(BookStatus.Reserved, Id);
                return true;
            }

            return false;
        }

        public bool CheckOutBookItem(BookItem bookItem)
        {
            if (TotalBooksCheckout >= Constants.MAX_BOOKS_ISSUED_TO_A_USER)
            {
                Console.WriteLine("The user has already check-out maximum number of books: 5");
                return false;
            }

            BookReservation bookReservation = BookReservation.FetchReservationDetails(bookItem.BarCode);
            if (bookReservation != null && bookReservation.MemberId != Id)
            {
                Console.WriteLine("Another user has already reserved this book");
                return false;
            }
            else
            {
                // This book is resereved by the current member, give it to him/her
                bookReservation.UpdateStatus(ReservationStatus.Completed);
            }

            bookItem.UpdateStatus(BookStatus.Loaned, Id);
            TotalBooksCheckout++;
            return true;
        }

        public void CheckFine()
        {
            //todo 
        }

        public void ReturnBookItem(BookItem bookItem)
        {
            bookItem.SetAvailable();
            var bookReservation = BookReservation.FetchReservationDetails(bookItem.BarCode);
            bookReservation.UpdateStatus(ReservationStatus.Completed);
        }
    }
}