using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.DTO.Product;
using T_Shop.Application.InuputModels;
using T_Shop.Application.Services.Interface;
using T_Shop.Application.ViewModels;
using T_Shop.Domain.Contracts;
using T_Shop.Domain.Models;

namespace T_Shop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IPaginationService<ProductDto, Product> _paginationService;

        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper, IPaginationService<ProductDto, Product> paginationService)
        {
            _productRepository = productRepository;
            _paginationService = paginationService;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(x => x.Id == id);

            await _productRepository.DeleteAsync(product);
        }

        public async Task<IEnumerable<ProductDto>> GetAllByFilterAsync(int? categoryId, int? brandId)
        {
           var data = await _productRepository.GetAllProductAsync();

            IEnumerable<Product> query = data;

            if (categoryId > 0)
            {
                query = query.Where(x=>x.CategoryId == categoryId);
            }

            if(brandId > 0)
            {
                query = query.Where(x=>x.BrandId == brandId);
            }

            var result = _mapper.Map<List<ProductDto>>(query);

            return result;
        }

        public async Task<PaginationVM<ProductDto>> GetPagination(PaginationInputModel pagination)
        {
            var source = await _productRepository.GetAllProductAsync();
            var result = _paginationService.GetPagination(source, pagination);
            return result;  
        }

        async Task<ProductDto> IProductService.CreateAsync(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            var createEntity = await _productRepository.CreateAsync(product);
            var entity = _mapper.Map<ProductDto>(createEntity);
            return entity;

        }

        async Task<IEnumerable<ProductDto>> IProductService.GetAllAsync()
        {
            var product = await _productRepository.GetAllProductAsync();
            return _mapper.Map<List<ProductDto>>(product);
        }

        async Task<ProductDto> IProductService.GetByIdAsync(int id)
        {
            var product = await _productRepository.GetProductDetailAsync(id);

            return _mapper.Map<ProductDto>(product);
        }

        Task IProductService.UpdateAsync(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            return _productRepository.UpdateAsync(product);
        }
    }
}
