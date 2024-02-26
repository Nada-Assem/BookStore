using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using BookStore.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class OrderService : OrderRepository, IOrderService
    {
        private IBookService _bookService;
        private ICustomerService _customerService;
        private readonly StoreContext _dbContext;

        public OrderService(StoreContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _bookService = new BooksService(_dbContext);
            _customerService = new CustomerService(_dbContext);
        }
        public List<OrderToReturnDTO>? ReturnOrders()
        {
            List<OrderToReturnDTO>? orders = GetAllOrdersForAdminRepo();
            if (orders is not null)
                return orders;
            return null;
        }
        public CheckStatusEnum UpdateOrderStatus(int orderId, OrderStatusEnum newstatus)
        {
            var order = GetOrderToUpdateForAdminRepo(orderId);
            if (order is not null)
                return ChangeOrderStatusRepo(order, newstatus);
            return CheckStatusEnum.NotSaved;

        }
        public List<CustomerOrderToReturnDTO>? GetAllCustomerOrders(int customerId)
        {
            var Orders = GetAllCustomerOrdersRepo(customerId);
            if (Orders is not null)
                return Orders;
            return null;
        }
        public OrderStatusEnum MakeCustomerCancelItsOrder(int orderId)
        {
            if (MakeCustomerCancelItsOrderRepo(orderId) == OrderStatusEnum.Cancelled)
                return OrderStatusEnum.Cancelled;
            return OrderStatusEnum.NotCancelled;
        }
        public OrderStatusEnum CreateOrder(int customerId)
        {
            var Customer = _customerService.GetCustomerById(customerId);
            if (Customer is not null)
            {
                if (Customer.CustomerBooks.Count()>0)
                {
                    var status = CreateOrderRepo(customerId, Customer.CustomerBooks);
                    return status;
                }
                else
                    return OrderStatusEnum.NoItems;
            }
            return OrderStatusEnum.NotCreated;
        }
    }
}
