using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApp.DTO;

namespace CalendarApp.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder(OrderDTO orderDTO)
        {
            var db = new CalendarAppDbEntities();
            var order = ConvertToEntity(orderDTO);
            db.Bookings.Add(order);
            db.SaveChanges();
        }

        private static Booking ConvertToEntity(OrderDTO orderDTO)
        {
            var order = new Booking();
            order.Id = orderDTO.Id;
            order.CheckInDay = orderDTO.CheckInDay;
            order.CheckOutDay = orderDTO.CheckOutDay;
            order.StayDuration = orderDTO.StayDuration;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.PostCode = orderDTO.PostCode;
            order.Phone = orderDTO.Phone;

            return order;

        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new CalendarAppDbEntities();
            var orders = db.Bookings.ToList();
            var orderDTO = ConvertToDTO(orders);
            return orderDTO;
        }

        private static List<DTO.OrderDTO> ConvertToDTO(List<Booking> orders)
        {
            var ordersDTO = new List<OrderDTO>();

            foreach (var order  in orders)
            {
                var orderDTO = new OrderDTO();
                orderDTO.CheckInDay = order.CheckInDay;
                orderDTO.CheckOutDay = order.CheckOutDay;

                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }
    }
}
