using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    class Catalog : ISearch
    {
        public int TotalBooks
        {
            get
            {
                return BookTitles.Sum(b => b.Value.Count);
            }
            private set
            {
                
            }
        }
        public Dictionary<string, List<Book>> BookTitles;
        public Dictionary<string, List<Book>> BookAuthors;
        public Dictionary<string, List<Book>> BookSubjects;
        public Dictionary<string, List<Book>> BookPublicationDates;

        public override List<Book> SearchByAuthor(string author)
        {
            if (!BookAuthors.ContainsKey(author))
            {
                return null;
            }
            else
            {
                return BookAuthors[author];
            }
        }

        public override List<Book> SearchByPublicationDate(string publicationDate)
        {
            if (!BookPublicationDates.ContainsKey(publicationDate))
            {
                return null;
            }
            else
            {
                return BookPublicationDates[publicationDate];
            }
        }

        public override List<Book> SearchBySubject(string subject)
        {
            if (!BookSubjects.ContainsKey(subject))
            {
                return null;
            }
            else
            {
                return BookTitles[subject];
            }
        }

        public override List<Book> SearchByTitle(string title)
        {
            if (!BookTitles.ContainsKey(title))
            {
                return null;
            }
            else
            {
                return BookTitles[title];
            }
        }

        public bool UpdateCatalog()
        {
            return false;
        }

    }
    
}