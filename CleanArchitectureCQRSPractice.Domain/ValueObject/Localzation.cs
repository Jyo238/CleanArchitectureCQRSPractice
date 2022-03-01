using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRSPractice.Domain.ValueObject
{
    public record Localzation(string City,string Country)
    {
        public static Localzation Create(string value)
        {
            var splitLocalzation = value?.Split(',');
            return new Localzation(splitLocalzation.First(), splitLocalzation.Last());
        }
        public override string ToString()
        {
            return $"{City},{Country}";
        }
    }
}
