using System;
using System.Collections.Generic;

namespace ShopClothing.DAL.Models
{
    public partial class Users
    {
        public int UsersId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Rule { get; set; }
        public int? Status { get; set; }
    }
}
