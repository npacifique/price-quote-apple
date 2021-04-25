using System.ComponentModel.DataAnnotations;

namespace QuoteApp.Models
{
    public class Quote
    {

       
        private decimal total;
        private int discount; 


        
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        } 


        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal GetDiscount() => (this.Total * this.Discount) / 100;
        public decimal GetTotal() => Total - GetDiscount();


        public Quote()
        {
            this.Total = 0;
            this.Discount = 0;
        }
    }
}