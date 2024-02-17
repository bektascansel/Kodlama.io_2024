using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.CourseDtos
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }

    }
}
