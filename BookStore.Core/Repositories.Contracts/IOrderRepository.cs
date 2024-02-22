using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories.Contracts
{
    public interface IOrderRepository
    {
        List<OrderToReturnDTO>? GetAllOrdersForAdminRepo();
        Order? GetOrderToUpdateForAdminRepo(int orderId);
        CheckStatusEnum ChangeOrderStatusRepo(Order order, OrderStatusEnum newstatus);
        List<CustomerOrderToReturnDTO>? GetAllCustomerOrdersRepo(int customerId);
        OrderStatusEnum MakeCustomerCancelItsOrderRepo(int orderId);
        OrderStatusEnum CreateOrderRepo(int customerId, List<BookCustomer> cart);
    }
}
