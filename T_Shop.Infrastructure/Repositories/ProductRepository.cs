using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Domain.Contracts;
using T_Shop.Domain.Models;
using T_Shop.Infrastructure.DbContexts;

namespace T_Shop.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _dbcontext.Product.Include(x => x.Category).Include(x => x.Brand).AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetProductDetailAsync(int id)
        {
            return await _dbcontext.Product.Include(x => x.Category).Include(x => x.Brand).AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task UpdateAsync(Product product)
        {

            _dbcontext.Update(product);
            await _dbcontext.SaveChangesAsync(); 
        }
    
    }
}
