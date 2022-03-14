using P129HomeWork.Enums;
using P129HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string val);
        List<Book> Filter(string authorName, Genre genre);
    }
}
