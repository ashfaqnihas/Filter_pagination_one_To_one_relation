using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop_Application.DTO.Category;

namespace T_Shop_Application.Services.Interface
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetByIdAsync(int id);

        Task<IEnumerable<CategoryDTO>> GetAllAsync();

        Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO);

        Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO);

        Task DeleteAsync(int id);


    }
}
