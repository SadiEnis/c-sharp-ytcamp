using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        // Interface içinde sadece imzaları bulunmalı.
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
    }
}
