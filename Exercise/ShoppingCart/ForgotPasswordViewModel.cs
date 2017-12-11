using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        public string EmailId { get; set; }
    }
}