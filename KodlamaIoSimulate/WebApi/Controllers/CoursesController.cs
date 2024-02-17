using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.CourseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpGet("getAll")]
        public IActionResult GetAll() {
           
            var values=_courseService.GetAll();
            return Ok(values);

        }

        [HttpGet("getCoursesByCategory")]
        public IActionResult GetCoursesByCategory(int id)
        {

            var values = _courseService.GetAllByCategory(id);
            return Ok(values);

        }

        [HttpGet("getCoursesByInstructor")]
        public IActionResult GetCoursesByInstructor(int id)
        {

            var values = _courseService.GetAllByInstructor(id);
            return Ok(values);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var value = _courseService.Get(id);
            return Ok(value);

        }


        [HttpPost("createCourse")]
        public IActionResult CreateCourse(CreateCourseDto courseDto)
        {

            _courseService.Create(courseDto);
            return Ok("Course Created");
     
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {

            _courseService.Delete(id);
            return Ok("Course Deleted");

        }

        [HttpPut("updateCourse")]
        public IActionResult UpdateCourse(UpdateCourseDto course)
        {

            _courseService.Update(course);
            return Ok("Course Updated");

        }





    }
}
