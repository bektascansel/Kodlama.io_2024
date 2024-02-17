using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dto.CourseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Create(CreateCourseDto course)
        {
            Course createCourse=new Course
            {
                CategoryId = course.CategoryId,
                InstructorId = course.InstructorId,
                Name = course.Name,
                
            };

            _courseDal.Create(createCourse);
        }

        public void Delete(int id)
        {
            var course = _courseDal.Get(x => x.Id == id);
            _courseDal.Delete(course);
        }

        public Course Get(int id)
        {
            var course = _courseDal.Get(x => x.Id == id);
            return course;

        }

        public List<Course> GetAll()
        {
            var courses= _courseDal.GetAll();
            return courses;
        }

        public List<Course> GetAllByCategory(int id)
        {
            var courses=_courseDal.GetAll(x=>x.CategoryId == id);
            return courses;
        }

        public List<Course> GetAllByInstructor(int id)
        {
            var courses = _courseDal.GetAll(x => x.InstructorId == id);
            return courses;
        }

        public void Update(UpdateCourseDto course)
        {
            var updatedCourse = _courseDal.Get(x => x.Id == course.Id);
            updatedCourse.Name = course.Name;
            updatedCourse.CategoryId = course.CategoryId;
            updatedCourse.InstructorId = course.InstructorId;
            
            _courseDal.Update(updatedCourse);
        }
    }
}
