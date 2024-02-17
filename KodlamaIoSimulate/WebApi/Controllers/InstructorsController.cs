using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Concrete.Dto.InstructorDtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {

        private readonly IInstructorService _ınstructorService;

        public InstructorsController(IInstructorService ınstructorService)
        {
            _ınstructorService = ınstructorService;
        }



        [HttpGet("getAll")]
        public IActionResult GetAll()
        {

            var values = _ınstructorService.GetAll();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var value = _ınstructorService.Get(id);
            return Ok(value);

        }


        [HttpPost("createInstructor")]
        public IActionResult CreateCategory(CreateInstructorDto ınstructorDto)
        {

            _ınstructorService.Create(ınstructorDto);
            return Ok("Instructor Created");

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {

            _ınstructorService.Delete(id);
            return Ok("Instructor Deleted");

        }

        [HttpPut("updateInstructor")]
        public IActionResult UpdateCategory(UpdateInstructorDto ınstructor)
        {

            _ınstructorService.Update(ınstructor);
            return Ok("Instructor Updated");

        }
    }
}
