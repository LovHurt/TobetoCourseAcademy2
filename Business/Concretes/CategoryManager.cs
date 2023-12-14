using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;


    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        var createdRequest = _mapper.Map<Category>(createCategoryRequest);

        var createdCategory = await _categoryDal.AddAsync(createdRequest);

        var createdResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);

        return createdResponse;
    }

    public async Task<CreatedCategoryResponse> Get(Guid categoryId)
    {
        var getCategory = await _categoryDal.GetAsync(c => c.Id == categoryId);

        var mappedCategory = _mapper.Map<CreatedCategoryResponse>(getCategory);

        return mappedCategory;
    }

    public async Task<IPaginate<GetListCategoryResponse>> GetListAsync()
    {
        var getListCategory = await _categoryDal.GetListAsync();

        var mappedListCategory = _mapper.Map<Paginate<GetListCategoryResponse>>(getListCategory);

        return mappedListCategory;
    }

    public async Task Delete(Guid categoryId)
    {
        Category categoryToDelete = await _categoryDal.GetAsync(c => c.Id == categoryId);
        
        await _categoryDal.DeleteAsync(categoryToDelete, true);
    }

    public async Task<CreatedCategoryResponse> Update(Category category)
    {
        var updatedCategory = await _categoryDal.UpdateAsync(category);

        var mappedCategory = _mapper.Map<CreatedCategoryResponse>(category);

        return mappedCategory;
    }

}
