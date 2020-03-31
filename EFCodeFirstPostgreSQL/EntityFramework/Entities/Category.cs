using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstPostgreSQL.EntityFramework.Entities
{
    public class Category
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
