using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public double? PriceNew { get; set; }
        public DateTime? Date { get; set; }
        public int? Order { get; set; }
        public int? Status { get; set; }
        public int? GroupProductId { get; set; }

        public virtual GroupProduct GroupProduct { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
