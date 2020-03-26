using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
