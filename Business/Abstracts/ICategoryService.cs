﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IPaginate<GetListCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Get(Guid id);
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    Task Delete(Guid categoryId);
    Task<CreatedCategoryResponse> Update(Category category);
}
