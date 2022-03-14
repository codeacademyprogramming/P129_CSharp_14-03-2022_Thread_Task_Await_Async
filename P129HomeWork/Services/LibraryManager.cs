using P129HomeWork.Enums;
using P129HomeWork.Exceptions;
using P129HomeWork.Interfaces;
using P129HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(b => b.Name.ToLower() == book.Name.ToLower()))
                throw new SameBookalreadyAddedExpection($"{book.Name} adli Kitab Artiq Movcuddur:!!!!");
            _books.Add(book);

        }

        public List<Book> Filter(string authorName, Genre genre)
        {
            return _books.FindAll(b => b.AuthorName == authorName && b.Genre == genre);
        }

        public List<Book> Search(string val)
        {
            return _books.FindAll(b => b.AuthorName.Contains(val) || 
            b.Genre.ToString().Contains(val) ||
            b.Name.Contains(val) || 
            b.PageCount.ToString().Contains(val));
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name.ToLower() == name.ToLower());

            if (book != null)
                return book;
            throw new BookNotFoundException($"{name} adli Kitab Tapilmadi:");
        }
    }
}
