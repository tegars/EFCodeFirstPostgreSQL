using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstPostgreSQL.EntityFramework.Entities
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string Colour { set; get; }
        public string Price { set; get; }
        public virtual Category Category { set; get; }
    }
}
