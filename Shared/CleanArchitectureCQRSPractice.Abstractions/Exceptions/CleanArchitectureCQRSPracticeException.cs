using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Shared.Abstractions.Exceptions
{
    public abstract class CleanArchitectureCQRSPracticeException : Exception
    {
        protected CleanArchitectureCQRSPracticeException(string message) : base(message)
        {

        }
    }
}
