using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CoursesOfInstructorManager : ICoursesOfInstructorService
    {
        ICoursesOfInstructorDal _CoursesOfInstructorDal;
        IMapper _mapper;


        public CoursesOfInstructorManager(ICoursesOfInstructorDal CoursesOfInstructorDal, IMapper mapper)
        {
            _CoursesOfInstructorDal = CoursesOfInstructorDal;
            _mapper = mapper;
        }

        public async Task<CreatedCoursesOfInstructorResponse> Add(CreateCoursesOfInstructorRequest createCoursesOfInstructorRequest)
        {
            var createdRequest = _mapper.Map<CoursesOfInstructor>(createCoursesOfInstructorRequest);

            var createdCoursesOfInstructor = await _CoursesOfInstructorDal.AddAsync(createdRequest);

            var createdResponse = _mapper.Map<CreatedCoursesOfInstructorResponse>(createdCoursesOfInstructor);

            return createdResponse;
        }

        public async Task<CreatedCoursesOfInstructorResponse> Get(Guid CoursesOfInstructorId)
        {
            var getCoursesOfInstructor = await _CoursesOfInstructorDal.GetAsync(c => c.Id == CoursesOfInstructorId);

            var mappedCoursesOfInstructor = _mapper.Map<CreatedCoursesOfInstructorResponse>(getCoursesOfInstructor);

            return mappedCoursesOfInstructor;
        }

        public async Task<IPaginate<GetListCoursesOfInstructorResponse>> GetListAsync()
        {
            var getListCoursesOfInstructor = await _CoursesOfInstructorDal.GetListAsync();

            var mappedListCoursesOfInstructor = _mapper.Map<Paginate<GetListCoursesOfInstructorResponse>>(getListCoursesOfInstructor);

            return mappedListCoursesOfInstructor;
        }

        public async Task Delete(Guid CoursesOfInstructorId)
        {
            CoursesOfInstructor CoursesOfInstructorToDelete = await _CoursesOfInstructorDal.GetAsync(c => c.Id == CoursesOfInstructorId);

            await _CoursesOfInstructorDal.DeleteAsync(CoursesOfInstructorToDelete, true);
        }

        public async Task<CreatedCoursesOfInstructorResponse> Update(CoursesOfInstructor CoursesOfInstructor)
        {
            var updatedCoursesOfInstructor = await _CoursesOfInstructorDal.UpdateAsync(CoursesOfInstructor);

            var mappedCoursesOfInstructor = _mapper.Map<CreatedCoursesOfInstructorResponse>(CoursesOfInstructor);

            return mappedCoursesOfInstructor;
        }

    }
}