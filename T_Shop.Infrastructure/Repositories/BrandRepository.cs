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
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository


    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public async Task UpdateAsync(Brand brand)
        {
            _dbcontext.Update(brand);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
