using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class Buku
    {
        public string idBuku { set; get; }
        public string nameBuku { set; get; }
        public string typeBuku { set; get; }
        public double priceBuku { set; get; }
        public int yearBuku { set; get; }
        public int quantityBuku { set; get; }
    }
}