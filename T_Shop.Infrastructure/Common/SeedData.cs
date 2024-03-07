using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Domain.Models;
using T_Shop.Infrastructure.DbContexts;

namespace T_Shop.Infrastructure.Common
{
    public class SeedData
    {
        public static async Task SeedDataAsync(ApplicationDbContext _dbContext)
        {
            if (!_dbContext.Brand.Any())
            {
                await _dbContext.AddRangeAsync(

                    new Brand
                    {
                        Name = "Apple",
                        EstablishedYear = 1956
                    },
                    new Brand
                    {
                        Name = "Samsung",
                        EstablishedYear = 1956
                    },
                    new Brand
                    {
                        Name = "Sony",
                        EstablishedYear = 1956
                    },
                    new Brand
                    {
                        Name = "Hp",
                        EstablishedYear = 1956
                    },
                    new Brand
                    {
                        Name = "Lenovo",
                        EstablishedYear = 1956
                    },
                    new Brand
                    {
                        Name = "Acer",
                        EstablishedYear = 1956
                    });

                await _dbContext.SaveChangesAsync();
            }
        }
        }
}
