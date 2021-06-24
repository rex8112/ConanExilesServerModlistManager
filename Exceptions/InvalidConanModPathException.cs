using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConanExilesModlistManager.Exceptions
{
    class InvalidConanModPathException : Exception
    {
        public InvalidConanModPathException()
        {

        }
        public InvalidConanModPathException(string message)
            : base(message)
        {

        }
        public InvalidConanModPathException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
