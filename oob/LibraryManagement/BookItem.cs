using System;
using System.Net;

namespace LibraryManagement
{
    public class BookItem : Book
    {
        public string BarCode;
        public DateTime PublicationDate;
        public BookStatus Status;
        public DateTime BorrowedDate;
        public DateTime DueDate;
        public Rack PlacedAt;
        public string MemberId;

        public void UpdateStatus(BookStatus status, string memberId)
        {
            Status = status;
            MemberId = memberId;        
        }

        public void SetAvailable()
        {
            Status = BookStatus.Availabe;
            MemberId = null;

        }
    }
}