using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Dto.InstructorDtos;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        Instructor Get(int id);
        void Update(UpdateInstructorDto instructor);
        void Create(CreateInstructorDto instructor);
        void Delete(int id);
    }
}
