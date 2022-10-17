using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCheck;

namespace sharp28
{
    internal class InvalidInputSizeException : Exception
    {
        internal InvalidInputSizeException(string msg) : base(msg)
        {

        }
    }
    internal class InvalidInputCharactersException : Exception
    {
        internal InvalidInputCharactersException(string msg) : base(msg)
        {

        }
    }
}
