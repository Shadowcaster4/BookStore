using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
