using System.ComponentModel.DataAnnotations;

namespace Order_Service_Web_API.Models
{
    public class Order
    {
        [Key]
        public int OrderID
        { 
            get; 
            set; 
        }

        public string CustomerName {  get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }

        public decimal Price {  get; set; }
        public int Quantity {  get; set; }
        public decimal ToatlPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string Notes {  get; set; }
        public string PaymentMethod { get; set;}
        public string ShippingMethod {  get; set; }
    }
}
