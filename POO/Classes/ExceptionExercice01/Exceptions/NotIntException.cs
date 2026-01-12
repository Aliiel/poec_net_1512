using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice01.Exceptions
{
    internal class NotIntException : Exception
    {
        public NotIntException(string message) : base(message) { }
    }   
}
