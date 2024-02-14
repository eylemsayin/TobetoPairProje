using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop2.Business.DTOs.Requests.CourseRequests;
using WorkShop2.Business.DTOs.Responses.CourseResponses;

namespace WorkShop2.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(CreateCourseRequest course);
        void Delete(DeleteCourseRequest course);
        void Update(UpdateCourseRequest course);
        List<GetAllCourseResponse> GetAll();
        GetByIdCourseResponse GetById(int id);
    }
}
