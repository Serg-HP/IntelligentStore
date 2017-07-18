using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person() { }
        public Person(int id, string firstName, string secondName, DateTime birthDate)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            BirthDate = birthDate;
        }
    }
}
