using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class GroupProduct
    {
        public GroupProduct()
        {
            Products = new HashSet<Products>();
        }

        public int GroupProductId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
        public int? Order { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
