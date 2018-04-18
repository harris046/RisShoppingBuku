using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingBukuOnline.Models;

namespace ShoppingBukuOnline.ViewModels
{
    public class UserAdmin
    {
        public User User { set; get; }
        public Admin Admin { set; get; }
    }
}