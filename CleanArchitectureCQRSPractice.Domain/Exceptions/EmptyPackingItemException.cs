using CleanArchitectureCQRSPractice.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.Exceptions
{
    public class EmptyPackingItemException : CleanArchitectureCQRSPracticeException
    {
        public EmptyPackingItemException() : base("packing Item cannot be empty.")
        {
        }
    }
}
