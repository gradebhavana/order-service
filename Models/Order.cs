using System;

namespace OrderMicroservice.Models
{
    public class Order
    {
        public long UserId { get; set; }
        public long OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
