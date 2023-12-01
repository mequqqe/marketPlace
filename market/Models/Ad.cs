using System.Globalization;

namespace market.Models
{
    public class Ad
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public string Address { get; set; }
        public string Number { get; set; }

        public DateTime DateTime { get; set; }

        public string Photo { get; set; }
    }
}
