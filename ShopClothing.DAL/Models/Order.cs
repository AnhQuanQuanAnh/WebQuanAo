using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public double? TotalMoney { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
