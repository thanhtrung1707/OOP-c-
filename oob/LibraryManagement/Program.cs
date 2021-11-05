using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();
            var member = new Member(catalog);
            member.SearchBookByAuthor("123");
            member.SearchBookByTitle("222");
        }
    }


}