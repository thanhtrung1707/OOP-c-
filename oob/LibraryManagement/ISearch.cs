using System.Collections.Generic;

namespace LibraryManagement
{
    public abstract class ISearch
    {
        public abstract List<Book> SearchByTitle(string title);
        public abstract List<Book> SearchByAuthor(string author);
        public abstract List<Book> SearchByPublicationDate(string publicationDate);
        public abstract List<Book> SearchBySubject(string subject);
    }
}