using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingBukuOnline.Models;

namespace ShoppingBukuOnline.ViewModels
{
    public class UserCustomer
    {
        public User User { set; get; }
        public Customer Customer { set; get; }
    }
}