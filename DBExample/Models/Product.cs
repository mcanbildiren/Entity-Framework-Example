using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public bool IsPublish { get; set; }

        public override string ToString()
        {
            return $" {Id} - {Name} - {Price} - {Stock}";
        }
    }
}
