namespace LibraryManagement
{
    public class Book
    {
        public string ISBN;
        public string Title;
        public string Subject;
        public string Author;

        public string GetTitle()
        {
            return Title;
        }
    }
}