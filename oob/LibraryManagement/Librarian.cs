namespace LibraryManagement
{
    public class Librarian : Account
    {
        public bool AddBookItem(BookItem bookItem)
        {
            Library.AddBook(bookItem);
            return false;
        }

        public bool UpdateBookItem(BookItem bookItem)
        {
            return Library.UpdateBook(bookItem);
        }   
    }
}