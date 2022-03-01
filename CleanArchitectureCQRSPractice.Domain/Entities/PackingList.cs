using CleanArchitectureCQRSPractice.Domain.Exceptions;
using CleanArchitectureCQRSPractice.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }
        private PackingListName _name;
        private Localzation _localzation;

        private readonly LinkedList<PackingItem> _items = new();
        internal PackingList(Guid id, PackingListName name, Localzation localzation, LinkedList<PackingItem> items)
        {
            Id = id;
            _name = name;
            _localzation = localzation;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExist = _items.Any(x => x.Name == item.Name);
            if(alreadyExist)
            {
                throw new PackingItemAlreadyExistsException(_name,item.Name);
            }

            _items.AddLast(item);


        }
    }
}
