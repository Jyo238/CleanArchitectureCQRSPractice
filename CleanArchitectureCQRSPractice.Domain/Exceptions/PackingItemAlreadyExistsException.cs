using CleanArchitectureCQRSPractice.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : CleanArchitectureCQRSPracticeException
    {
        public string ListName{get;}
        public string ItemName { get; }
        public PackingItemAlreadyExistsException(string listName, string itemName) : base($"{listName} packing {itemName} alreadyExists.")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
