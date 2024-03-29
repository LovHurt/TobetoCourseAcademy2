﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICoursesOfInstructorService
    {
        Task<IPaginate<GetListCoursesOfInstructorResponse>> GetListAsync();
        Task<CreatedCoursesOfInstructorResponse> Get(Guid id);
        Task<CreatedCoursesOfInstructorResponse> Add(CreateCoursesOfInstructorRequest createCoursesOfInstructorRequest);
        Task Delete(Guid categoryId);
        Task<CreatedCoursesOfInstructorResponse> Update(CoursesOfInstructor category);
    }

}
