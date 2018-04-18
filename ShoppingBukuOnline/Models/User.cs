using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please Enter Your Email")]
        [StringLength(maximumLength: 100, ErrorMessage = "Email too short/long", MinimumLength = 3)]
        public string email { set; get; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        [StringLength(maximumLength: 100, ErrorMessage = "Password too short/long", MinimumLength = 3)]
        public string password { set; get; }
        public string userType { set; get; }
    }
}