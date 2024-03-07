using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Domain.Models;

namespace T_Shop.Domain.Contracts
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Task UpdateAsync(Brand brand);
    }
}
