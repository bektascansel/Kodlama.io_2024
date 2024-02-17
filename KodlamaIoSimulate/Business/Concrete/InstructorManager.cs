using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.InstructorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void Create(CreateInstructorDto instructor)
        {
            Instructor createdInstructor = new Instructor
            {
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Description = instructor.Description,
                
            };

            _ınstructorDal.Create(createdInstructor);
        }

        public void Delete(int id)
        {
           var ınstructor=_ınstructorDal.Get(x=>x.Id == id);
            _ınstructorDal.Delete(ınstructor);
        }

        public Instructor Get(int id)
        {
            var ınstructor = _ınstructorDal.Get(x => x.Id == id);
            return ınstructor;
        }

        public List<Instructor> GetAll()
        {
            var ınstructors = _ınstructorDal.GetAll();
            return ınstructors;
        }

        public void Update(UpdateInstructorDto instructor)
        {
            var updatedInstructor = _ınstructorDal.Get(x => x.Id == instructor.Id);

            updatedInstructor.FirstName = instructor.FirstName;
            updatedInstructor.LastName = instructor.LastName;
            updatedInstructor.Description = instructor.Description;

            _ınstructorDal.Update(updatedInstructor);

            
        }
    }
}
