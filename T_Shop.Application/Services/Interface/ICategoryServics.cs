using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;

namespace T_Shop.Application.Services.Interface
{
    public interface ICategoryServics
    {
        Task<CategoryDto> GetByIdAsync(int id);

        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> CreateAsync(CreateCategoryDto createCategoryDto);
        Task UpdateAsync(UpdateCategoryDto updateCategoryDto);

        Task DeleteAsync(int id);
    }
}
