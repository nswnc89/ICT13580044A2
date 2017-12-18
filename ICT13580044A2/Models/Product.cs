using System;
using SQLite;
namespace ICT13580044A2.Models
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [NotNull]
		[MaxLength(200)]
        public string Name { get; set; }

        public string Decription { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string Cateory { get; set; }

        public decimal ProductPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Stock { get; set; }
    }
}
