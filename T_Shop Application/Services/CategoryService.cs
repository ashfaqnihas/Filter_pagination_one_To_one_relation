using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop_Application.DTO.Category;
using T_Shop_Application.Services.Interface;

namespace T_Shop.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
