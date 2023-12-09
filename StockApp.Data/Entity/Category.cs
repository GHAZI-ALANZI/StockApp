using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.Data.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
