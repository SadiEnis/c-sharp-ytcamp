using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PTTManager : ISupplierService 
    {
        private IApplicantService _service;

        // Tasarım Deseni -> new'lemek yerine field oluşturduk.
        public PTTManager(IApplicantService service)
        {
            _service = service;
        }

        public void GiveMask(Person person)
        {
            if (_service.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine("Maske verilemedi.");
            }
        }
    }
}
