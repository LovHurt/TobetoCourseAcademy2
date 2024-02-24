using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesOfInstructorsController : ControllerBase
    {
        ICoursesOfInstructorService _coursesOfInstructorService;

        public CoursesOfInstructorsController(ICoursesOfInstructorService coursesOfInstructorService)
        {
            _coursesOfInstructorService = coursesOfInstructorService;
        }


        [HttpPost("addcoursesOfInstructor")]
        public async Task<IActionResult> Add([FromBody] CreateCoursesOfInstructorRequest createCoursesOfInstructorRequest)
        {
            var result = await _coursesOfInstructorService.Add(createCoursesOfInstructorRequest);
            return Ok(result);
        }

        [HttpGet("getcoursesOfInstructorlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _coursesOfInstructorService.GetListAsync();
            return Ok(result);
        }

        [HttpPost("updatecoursesOfInstructor")]
        public async Task<IActionResult> Update(CoursesOfInstructor coursesOfInstructor)
        {
            var result = await _coursesOfInstructorService.Update(coursesOfInstructor);
            return Ok(result);
        }

        [HttpDelete("deletecoursesOfInstructor")]
        public async Task<IActionResult> Delete(Guid coursesOfInstructorId)
        {
            await _coursesOfInstructorService.Delete(coursesOfInstructorId);
            return Ok("Delete Successful");
        }

        [HttpGet("getbycoursesOfInstructorid")]
        public async Task<IActionResult> GetById(Guid coursesOfInstructorId)
        {
            var result = await _coursesOfInstructorService.Get(coursesOfInstructorId);
            return Ok(result);
        }

    }
}
