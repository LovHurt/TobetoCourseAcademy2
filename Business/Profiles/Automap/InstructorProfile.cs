﻿using AutoMapper;
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
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<CreateInstructorRequest, Instructor>();
            CreateMap<Instructor, CreatedInstructorResponse>();

            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
        }
    }

}
