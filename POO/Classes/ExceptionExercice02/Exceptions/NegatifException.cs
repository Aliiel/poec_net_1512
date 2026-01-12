using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice02.Exceptions
{
    internal class NegatifException : Exception
    {
        public NegatifException(string message) : base (message) { }

    }
}
