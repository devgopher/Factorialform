using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialform.Logic
{
    /// <summary>
    /// An exception for Logic class
    /// </summary>
    class LogicException : Exception
    {
        public LogicException( String message ) : base(message)
        {

        }

        public LogicException( String message, Exception inner_exception ) : base( message, inner_exception )
        {

        }
    }
}
