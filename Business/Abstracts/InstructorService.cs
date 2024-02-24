using Business.Dtos.Requests;
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
    public interface IInstructorService
    {
        Task<IPaginate<GetListInstructorResponse>> GetListAsync();
        Task<CreatedInstructorResponse> Get(Guid id);
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
        Task Delete(Guid categoryId);
        Task<CreatedInstructorResponse> Update(Instructor category);
    }

}
