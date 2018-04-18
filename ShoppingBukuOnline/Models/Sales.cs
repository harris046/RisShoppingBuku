using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class Sales
    {
        public string salesID { set; get; }
        public string custID { set; get; }
        public string date { set; get; }
        public double totalPayment { set; get; }
    }
}