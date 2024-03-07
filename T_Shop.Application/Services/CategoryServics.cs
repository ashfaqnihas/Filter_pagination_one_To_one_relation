using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.Services.Interface;
using T_Shop.Domain.Contracts;
using T_Shop.Domain.Models;

namespace T_Shop.Application.Services
{
    public class CategoryService : ICategoryServics
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(x => x.Id == id);

            await _categoryRepository.DeleteAsync(category);
        }

        async Task<CategoryDto> ICategoryServics.CreateAsync(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            var createEntity = await _categoryRepository.CreateAsync(category);
            var entity = _mapper.Map<CategoryDto>(createEntity);
            return entity;

        }

        async Task<IEnumerable<CategoryDto>> ICategoryServics.GetAllAsync()
        {
            var category = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(category);
        }

        async Task<CategoryDto> ICategoryServics.GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(x => x.Id == id);

            return _mapper.Map<CategoryDto>(category);
        }

        Task ICategoryServics.UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            var category = _mapper.Map<Category>(updateCategoryDto);
            return _categoryRepository.UpdateAsync(category);
        }
    }
}
