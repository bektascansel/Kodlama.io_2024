using Entities.Concrete;
using Entities.Concrete.Dto.CourseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {

        List<Course> GetAll();
        List<Course> GetAllByCategory(int id);
        List<Course> GetAllByInstructor(int id);
        Course Get(int id);
        void Update(UpdateCourseDto course);
        void Create(CreateCourseDto course);
        void Delete(int id);


    }
}
