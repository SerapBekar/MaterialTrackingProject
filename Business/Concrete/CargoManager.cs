using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CargoManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public CargoManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        
        public void GiveMaterial(Person person) 
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine("Material were given for " + person.FirstName);
            }
        }
    }
}
