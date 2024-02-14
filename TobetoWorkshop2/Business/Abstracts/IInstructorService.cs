using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop2.Business.DTOs.Requests.InstructorRequests;
using WorkShop2.Business.DTOs.Responses.InstructorResponses;

namespace WorkShop2.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(CreateInstructorRequest instructor);
        void Delete(DeleteInstructorRequest instructor);
        void Update(UpdateInstructorRequest instructor);
        List<GetAllInstructorResponse> GetAll();
        GetByIdInstructorResponse GetById(int id);
    }
}
