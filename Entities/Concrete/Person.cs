using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationIdentity { get; set; }
        public int DateOfBirthYear { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int birthYear, long nationalIdentity = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirthYear = birthYear;
            NationIdentity = nationalIdentity;
        }
    }
}
