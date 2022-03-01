using CleanArchitectureCQRSPractice.Domain.Exceptions;

namespace CleanArchitectureCQRSPractice.Domain.ValueObject
{
    public record PackingListName
    {
        public string Value { get; }
        public PackingListName(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new EmptyPackingListNameException();
            }

            Value = value;
        }
        public static implicit operator string (PackingListName name) => name.Value;
        public static implicit operator PackingListName(string name) => new(name);
    }
}
