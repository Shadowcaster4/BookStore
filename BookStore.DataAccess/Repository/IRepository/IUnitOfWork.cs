using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IProductRepository Product { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IShoppingCartRepository ShoppingCart { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
