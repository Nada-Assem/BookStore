using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services.Contracts
{
    public interface IOrderService
    {
        List<OrderToReturnDTO>? ReturnOrders();
        CheckStatusEnum UpdateOrderStatus(int orderId, OrderStatusEnum newstatus);
        List<CustomerOrderToReturnDTO>? GetAllCustomerOrders(int customerId);
        OrderStatusEnum MakeCustomerCancelItsOrder(int orderId);
        OrderStatusEnum CreateOrder(int customerId);
    }
}
