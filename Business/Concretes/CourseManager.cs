using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        CourseBusinessRules _courseBusinessRules;

        public CourseManager(ICourseDal courseDal, IMapper mapper, CourseBusinessRules courseBusinessRules)
        {
            _courseDal = courseDal;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            var createdRequest = _mapper.Map<Course>(createCourseRequest);
            var createdCourse = await _courseDal.AddAsync(createdRequest);
            var createdResponse = _mapper.Map<CreatedCourseResponse>(createdCourse);

            return createdResponse;
        }

        public async Task Delete(Guid courseId)
        {
            Course courseToDelete = await _courseDal.GetAsync(c => c.Id == courseId);
            await _courseDal.DeleteAsync(courseToDelete, true);
        }

        public async Task<CreatedCourseResponse> Get(Guid courseId)
        {
            var getCourse = await _courseDal.GetAsync(c => c.Id == courseId);
            var mappedCourse = _mapper.Map<CreatedCourseResponse>(getCourse);
            return mappedCourse;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetListAsync()
        {
            var getListCourse = await _courseDal.GetListAsync();

            var mappedListCourse = _mapper.Map<Paginate<GetListCourseResponse>>(getListCourse);

            return mappedListCourse;
        }

        public async Task<CreatedCourseResponse> Update(Course course)
        {
            var updatedCourse = await _courseDal.UpdateAsync(course);
            var mappedCourse = _mapper.Map<CreatedCourseResponse>(updatedCourse);
            return mappedCourse;
        }
    }
}
