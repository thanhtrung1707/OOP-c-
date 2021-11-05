using System;

namespace LibraryManagement
{
    class BookReservation
    {
        public DateTime CreatedDate;
        public ReservationStatus Status;
        public string MemberId;
        public string BookItemBarCode;

        public ReservationStatus GetStatus()
        {
            return Status;
        }

        public static BookReservation FetchReservationDetails(string bookItemBarCode)
        {
            var book = Library.FindBookByBarcode(bookItemBarCode);
            if (book == null)
            {
                return null;
            }
            // return BookReservation if it exists
            return new BookReservation
            {
                CreatedDate = DateTime.Now,
                Status = ReservationStatus.Pending,
                MemberId = book.MemberId,
                BookItemBarCode = book.BarCode
            };
        }

        public void UpdateStatus(ReservationStatus status)
        {
            Status = status;
        }
    }
}