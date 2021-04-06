using System.ComponentModel.DataAnnotations;

namespace QuoteApp.Models
{
    public class Quote
    {
        
        private decimal total;
        private int discount;
        
        [Display(Name = "Subtotal")]
        [Required(ErrorMessage = "Subtotal is a required field")]
        [Range(1, 1000000000000000000 , ErrorMessage="The Subtotal must be a value greater than 0")]
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }


        
        [Display(Name = "Discount Percent")]
        [Required(ErrorMessage = "Discount Percent is a required")]
        [Range(0, 100)]
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal GetDiscount() => (this.Total * this.Discount) / 100;
        public decimal GetTotal() => Total - GetDiscount();

    }
}