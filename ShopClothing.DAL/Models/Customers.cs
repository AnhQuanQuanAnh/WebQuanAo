using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Order = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Province { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
