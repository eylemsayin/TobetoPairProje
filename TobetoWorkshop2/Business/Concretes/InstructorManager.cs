﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop2.Business.Abstracts;
using WorkShop2.Business.DTOs.Requests.InstructorRequests;
using WorkShop2.Business.DTOs.Responses.InstructorResponses;
using WorkShop2.DataAccess.Abstracts;
using WorkShop2.Entities.Concretes;

namespace WorkShop2.Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(CreateInstructorRequest instructor)
        {
            Instructor instructorToCreate = new();
            instructorToCreate.FirstName = instructor.FirstName;
            instructorToCreate.LastName = instructor.LastName;
            instructorToCreate.Description = instructor.Description;
            instructorToCreate.ImageUrl = instructor.ImageUrl;
            _instructorDal.Add(instructorToCreate);
        }

        public void Delete(DeleteInstructorRequest instructor)
        {
            Instructor instructorToDelete = new();
            instructorToDelete.Id = instructor.Id;
            _instructorDal.Delete(instructorToDelete);
        }

        public List<GetAllInstructorResponse> GetAll()
        {
            List<GetAllInstructorResponse> instructors = new List<GetAllInstructorResponse>();
            foreach (var instructor in _instructorDal.GetAll())
            {
                GetAllInstructorResponse getAllInstructorResponse = new();
                getAllInstructorResponse.Id = instructor.Id;
                getAllInstructorResponse.FirstName = instructor.FirstName;
                getAllInstructorResponse.LastName = instructor.LastName;
                getAllInstructorResponse.Description = instructor.Description;
                getAllInstructorResponse.ImageUrl = instructor.ImageUrl;
                instructors.Add(getAllInstructorResponse);
            }
            return instructors;
        }

        public GetByIdInstructorResponse GetById(int id)
        {
            GetByIdInstructorResponse instructor = new();
            Instructor instructorEntity = _instructorDal.GetById(id);
            instructor.Id = instructorEntity.Id;
            instructor.FirstName = instructorEntity.FirstName;
            instructor.LastName = instructorEntity.LastName;
            instructor.Description = instructorEntity.Description;
            instructor.ImageUrl = instructorEntity.ImageUrl;
            return instructor;
        }

        public void Update(UpdateInstructorRequest instructor)
        {
            Instructor instructorToUpdate = new();
            instructorToUpdate.Id = instructor.Id;
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
            instructorToUpdate.Description = instructor.Description;
            instructorToUpdate.ImageUrl = instructor.ImageUrl;
            _instructorDal.Update(instructorToUpdate);
        }
    }
}
