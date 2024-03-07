using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.DTO.Product;
using T_Shop.Application.InuputModels;
using T_Shop.Application.ViewModels;

namespace T_Shop.Application.Services.Interface
{
    public interface IProductService
    {
        Task<PaginationVM<ProductDto>> GetPagination(PaginationInputModel pagination);
        Task<ProductDto> GetByIdAsync(int id);

        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<IEnumerable<ProductDto>> GetAllByFilterAsync(int? categoryId, int? brandId);
        Task<ProductDto> CreateAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);

        Task DeleteAsync(int id);
    }
}
