using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
         ICategoryService _categoryService;

         public CategoriesController(ICategoryService categoryService)
         {
             _categoryService = categoryService;
         }

         [HttpPost("addcategory")]
         public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
        {
             var result = await _categoryService.Add(createCategoryRequest);
             return Ok(result);
         }

         [HttpGet("getcategorylist")]
         public async Task<IActionResult> GetList()
         {
             var result = await _categoryService.GetListAsync();
             return Ok(result);
         }

         [HttpPost("updatecategory")]
         public async Task<IActionResult> Update([FromBody] Category category)
         {
             var result = await _categoryService.Update(category);
             return Ok(result);
         }

         [HttpDelete("deletecategory")]
         public async Task<IActionResult> Delete([FromBody] Guid categoryId)
         {
            await _categoryService.Delete(categoryId);

            return Ok("Delete Successful");
         }

         [HttpGet("getbycategoryid")]
         public async Task<IActionResult> GetById(Guid categoryId)
         {
             var result = await _categoryService.Get(categoryId);

             return Ok(result);
         }

    }
}
