using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class Calculation
    {
        // stores sales price, sets a range, and gives error messages
        [Required(ErrorMessage = "Please enter sales price")]
        [Range(0, double.MaxValue, ErrorMessage = "Sales price must be greater than 0")]
        public decimal Subtotal { get; set; }

        // stores discount percent, sets a range, and gives error messages
        [Required(ErrorMessage = "Please enter a discount percent")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100")]
        public decimal DiscountPercent { get; set; }

        // calculating discount amount
        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);

        // calculating total
        public decimal Total => Subtotal - DiscountPercent;
    }
}
