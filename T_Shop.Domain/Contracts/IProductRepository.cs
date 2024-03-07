using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Domain.Models;

namespace T_Shop.Domain.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProductAsync();

        Task<Product> GetProductDetailAsync(int id);
        Task UpdateAsync(Product product);
    }
}
