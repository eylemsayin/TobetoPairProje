using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop2.Business.DTOs.Requests.CategoryRequests;
using WorkShop2.Business.DTOs.Responses.CategoryResponses;

namespace WorkShop2.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest category);
        void Delete(DeleteCategoryRequest category);
        void Update(UpdateCategoryRequest category);
        List<GetAllCategoryResponse> GetAll();
        GetByIdCategoryResponse GetById(int id);
    }
}
