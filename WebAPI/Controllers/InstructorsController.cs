using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }


        [HttpPost("addinstructor")]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            var result = await _instructorService.Add(createInstructorRequest);
            return Ok(result);
        }

        [HttpGet("getinstructorlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }

        [HttpPost("updateinstructor")]
        public async Task<IActionResult> Update(Instructor instructor)
        {
            var result = await _instructorService.Update(instructor);
            return Ok(result);
        }

        [HttpDelete("deleteinstructor")]
        public async Task<IActionResult> Delete(Guid instructorId)
        {
            await _instructorService.Delete(instructorId);
            return Ok("Delete Successful");
        }

        [HttpGet("getbyinstructorid")]
        public async Task<IActionResult> GetById(Guid instructorId)
        {
            var result = await _instructorService.Get(instructorId);
            return Ok(result);
        }

    }
}
