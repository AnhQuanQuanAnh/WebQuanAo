using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
