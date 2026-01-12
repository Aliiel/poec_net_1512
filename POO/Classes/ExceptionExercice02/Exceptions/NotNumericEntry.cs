using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice02.Exceptions
{
    internal class NotNumericEntry : Exception
    {
        public NotNumericEntry(string message) : base (message) { }
    }
}
