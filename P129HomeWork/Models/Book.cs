using P129HomeWork.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Models
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Genre Genre { get; set; }

        public Book(string name, string authorname, int pagecount, Genre genre)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Adi: {Name}\nMuelifi: {AuthorName}\nSehife Sayi: {PageCount}\nJanr: {Genre}";
        }
    }
}
