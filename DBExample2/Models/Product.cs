using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBExample2.Models
{
    //[Table("ProductTB",Schema ="product")]
    public class Product
    {
        public int Id { get; set; }

        //[Required]
        //[Column("PName")]
        public string Name { get; set; }

        //[Column(TypeName ="decimal(9,2)")]
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public bool IsPublish { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual ProductFeature ProductFeature { get; set; }



    }
}
