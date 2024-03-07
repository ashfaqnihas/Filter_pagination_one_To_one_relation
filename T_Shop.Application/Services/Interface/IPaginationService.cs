using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.InuputModels;
using T_Shop.Application.ViewModels;

namespace T_Shop.Application.Services.Interface
{
    public interface IPaginationService<T,S> where T : class
    {
        PaginationVM<T> GetPagination(List<S> source, PaginationInputModel pagination);
    }
}
