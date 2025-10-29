using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Exception.Helpers.Extections
{
    internal class ExceptionEmail : Exception
    {
        public ExceptionEmail(string message) : base(message) { }
    }
}
