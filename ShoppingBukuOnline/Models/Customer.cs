using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class Customer
    {
        public string id { set; get; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string name { set; get; }
        [Required(ErrorMessage = "Please Enter Your Phone No")]
        public string phone { set; get; }
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string address { set; get; }
        [Required(ErrorMessage = "Please Enter Your City")]
        public string city { set; get; }
        [Required(ErrorMessage = "Please Enter Your State")]
        public string state { set; get; }
        [Required(ErrorMessage = "Please Enter Your Postcode")]
        public string postcode { set; get; }
    }
}