using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice03.Exceptions
{
    internal class OutOfBoundException : Exception
    {
        public OutOfBoundException(string message) : base(message) { }
    }
}
