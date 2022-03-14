using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message) { }
    }
}
