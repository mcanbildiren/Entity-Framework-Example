using System;
using System.Collections.Generic;

namespace DBExample2.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public bool IsPublish { get; set; }
    }
}
