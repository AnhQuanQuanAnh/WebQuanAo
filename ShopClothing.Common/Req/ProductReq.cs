using System;
using System.Collections.Generic;
using System.Text;

namespace ShopClothing.Common.Req
{
    public class ProductReq
    {
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
    }
}
