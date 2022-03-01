using CleanArchitectureCQRSPractice.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.Exceptions
{
    public class EmptyPackingListNameException : CleanArchitectureCQRSPracticeException
    {
        public EmptyPackingListNameException() : base(message:"packing list is empty")
        {

        }
    }
}
