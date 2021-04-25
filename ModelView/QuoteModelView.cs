using System;
using System.ComponentModel.DataAnnotations;
using QuoteApp.Models;

namespace QuoteApp.ModelView
{
    public class QuoteModelView
    {
        public Quote Quote { get; set; }

        [Display(Name = "Subtotal")]
        [Required(ErrorMessage = "Please enter a price")]
        [Range(1, 1000000000000000000, ErrorMessage = "The Subtotal must be a value greater than 0")]
        public decimal? Total { get; set; }


        [Display(Name = "Discount Percent")]
        [Required(ErrorMessage = "Please enter a Percent discount")]
        [Range(0, 100)]
        public int? Discount { get; set; }

        public QuoteModelView() {
            Quote = new Quote();
        }
        

    }
}
