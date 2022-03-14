using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message){ }
    }
}
