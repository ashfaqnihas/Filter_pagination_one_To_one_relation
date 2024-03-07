using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.InuputModels;
using T_Shop.Application.Services.Interface;
using T_Shop.Application.ViewModels;

namespace T_Shop.Application.Services
{
    public class PaginationService<T, S> : IPaginationService<T, S> where T : class
    {
        private readonly IMapper _mapper;

        public PaginationService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PaginationVM<T> GetPagination(List<S> source, PaginationInputModel pagination)
        {
            var currentPage = pagination.PageNumber;

            var pageSize = pagination.PageSize;

            var totalNoRecords = source.Count;

            var totalPage = (int)Math.Ceiling(totalNoRecords / (double)pageSize);

            var result = source
                .Skip((pagination.PageNumber - 1)* (pagination.PageSize))
                .Take(pagination.PageSize)
                .ToList();

            var item = _mapper.Map<List<T>>(result);

            PaginationVM<T> paginationVM = new PaginationVM<T>(currentPage, pageSize, totalPage, totalNoRecords, item);  

            return paginationVM;
        }
    }
}
