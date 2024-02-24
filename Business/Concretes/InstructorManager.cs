using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class instructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        IMapper _mapper;


        public instructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }

        public async Task<CreatedInstructorResponse> Add(CreatedInstructorResponse createinstructorRequest)
        {
            var createdRequest = _mapper.Map<Instructor>(createinstructorRequest);

            var createdinstructor = await _instructorDal.AddAsync(createdRequest);

            var createdResponse = _mapper.Map<CreatedInstructorResponse>(createdinstructor);

            return createdResponse;
        }

        public async Task<CreatedInstructorResponse> Get(Guid instructorId)
        {
            var getinstructor = await _instructorDal.GetAsync(c => c.Id == instructorId);

            var mappedInstructor = _mapper.Map<CreatedInstructorResponse>(getinstructor);

            return mappedInstructor;
        }

        public async Task<IPaginate<GetListInstructorResponse>> GetListAsync()
        {
            var getListinstructor = await _instructorDal.GetListAsync();

            var mappedListinstructor = _mapper.Map<Paginate<GetListInstructorResponse>>(getListinstructor);

            return mappedListinstructor;
        }

        public async Task Delete(Guid instructorId)
        {
            Instructor instructorToDelete = await _instructorDal.GetAsync(c => c.Id == instructorId);

            await _instructorDal.DeleteAsync(instructorToDelete, true);
        }

        public async Task<CreatedInstructorResponse> Update(Instructor instructor)
        {
            var updatedinstructor = await _instructorDal.UpdateAsync(instructor);

            var mappedinstructor = _mapper.Map<CreatedInstructorResponse>(instructor);

            return mappedinstructor;
        }

    }
}