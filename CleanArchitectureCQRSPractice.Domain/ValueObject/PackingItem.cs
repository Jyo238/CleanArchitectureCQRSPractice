using CleanArchitectureCQRSPractice.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.ValueObject
{
    public record PackingItem
    {
        public string Name{get;}
        public uint Quantity{get;}
        public bool IsPacked { get; }

        public PackingItem(string name, uint quantity, bool isPacked)
        {
            if (string.IsNullOrEmpty(name)) throw new EmptyPackingItemException();
            Name = name;
            Quantity = quantity;
            IsPacked = isPacked;
        }
    }
}
