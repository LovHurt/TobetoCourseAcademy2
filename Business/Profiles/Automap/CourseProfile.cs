using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Business.Profiles.Automap
{
    public class CourseProfile: Profile
    {
        public CourseProfile()
        {
            CreateMap<CreateCourseRequest, Course>();
            CreateMap<Course, CreatedCourseResponse>();

            CreateMap<Course, GetListCourseResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
        }
    }
}
