using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.DTO.Brand;

namespace T_Shop.Application.Services.Interface
{
    public interface IBrandService
    {
        Task<BrandDto> GetByIdAsync(int id);

        Task<IEnumerable<BrandDto>> GetAllAsync();
        Task<BrandDto> CreateAsync(CreateBrandDto createBrandDto);
        Task UpdateAsync(UpdateBrandDto updateBrandDto);

        Task DeleteAsync(int id);
    }
}
