using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApp.DTO;

namespace CalendarApp.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(OrderDTO orderDTO)
        {
            orderDTO.Id = Guid.NewGuid();
            Persistence.OrderRepository.CreateOrder(orderDTO);
        }

        public static List<OrderDTO> GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();
        }
    }
}
