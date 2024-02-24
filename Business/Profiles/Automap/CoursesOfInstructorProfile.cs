using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Automap
{
    public class CoursesOfInstructorProfile : Profile
    {
        public CoursesOfInstructorProfile()
        {
            CreateMap<CreateCoursesOfInstructorRequest, CoursesOfInstructor>();
            CreateMap<CoursesOfInstructor, CreatedCoursesOfInstructorResponse>();

            CreateMap<CoursesOfInstructor, GetListCoursesOfInstructorResponse>().ReverseMap();
            CreateMap<Paginate<CoursesOfInstructor>, Paginate<GetListCoursesOfInstructorResponse>>().ReverseMap();
        }
    }

}
