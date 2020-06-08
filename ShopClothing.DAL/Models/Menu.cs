using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int? Order { get; set; }
        public int? ParentId { get; set; }
    }
}
