using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicationService;
        private IPersonCheckService _personCheckService;


        public PttManager(IApplicantService applicationService, IPersonCheckService personCheckService)
        {
            _applicationService = applicationService;
            _personCheckService = personCheckService;
        }

        public void GiveMask(Person person)
        {
         
            if(_personCheckService.CheckIfRealPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");

            }
            else
            {
                Console.WriteLine(person.FirstName + " MASKE VERİLEMEDİ");
            }
        }

    }
}
