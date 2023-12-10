using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpPost("addcourse")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            var result = await _courseService.Add(createCourseRequest);
            return Ok(result);
        }

        [HttpGet("getcourselist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        [HttpPost("updatecourse")]
        public async Task<IActionResult> Update(Course course)
        {
            var result = await _courseService.Update(course);
            return Ok(result);
        }

        [HttpDelete("deletecourse")]
        public async Task<IActionResult> Delete(Guid courseId)
        {
            await _courseService.Delete(courseId);
            return Ok("Delete Successful");
        }

        [HttpGet("getbycourseid")]
        public async Task<IActionResult> GetById(Guid courseId)
        {
            var result = await _courseService.Get(courseId);
            return Ok(result);
        }

    }
}

