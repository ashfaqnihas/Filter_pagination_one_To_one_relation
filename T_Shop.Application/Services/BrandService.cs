using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.DTO.Brand;
using T_Shop.Application.Services.Interface;
using T_Shop.Domain.Contracts;
using T_Shop.Domain.Models;

namespace T_Shop.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(x => x.Id == id);

            await _brandRepository.DeleteAsync(brand);
        }

        async Task<BrandDto> IBrandService.CreateAsync(CreateBrandDto createBrandDto)
        {
            var brand = _mapper.Map<Brand>(createBrandDto);
            var createEntity = await _brandRepository.CreateAsync(brand);
            var entity = _mapper.Map<BrandDto>(createEntity);
            return entity;

        }

        async Task<IEnumerable<BrandDto>> IBrandService.GetAllAsync()
        {
            var brand = await _brandRepository.GetAllAsync();
            return _mapper.Map<List<BrandDto>>(brand);
        }

        async Task<BrandDto> IBrandService.GetByIdAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(x => x.Id == id);

            return _mapper.Map<BrandDto>(brand);
        }

        Task IBrandService.UpdateAsync(UpdateBrandDto updateBrandDto)
        {
            var brand = _mapper.Map<Brand>(updateBrandDto);
            return _brandRepository.UpdateAsync(brand);
        }
    }
}
