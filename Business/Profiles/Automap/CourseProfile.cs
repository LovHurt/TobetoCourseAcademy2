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
            CreateMap<IPaginate<Course>, IPaginate<GetListCourseResponse>>().ReverseMap();

            CreateMap<Course, CreateCourseRequest>().ReverseMap();
            CreateMap<Course, DeleteCourseRequest>().ReverseMap();
            CreateMap<Course, UpdateCourseRequest>().ReverseMap();

            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
        }
    }
}
