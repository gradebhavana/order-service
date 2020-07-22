
using OrderMicroservice.Models;
using System.Collections.Generic;

namespace OrderMicroservice.Services
{
    public interface IOrderService
    {
        public List<Order> GetAll(int userId);
    }
}
