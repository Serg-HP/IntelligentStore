using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Worker:Person
    {
        public Professions Profession { get; set; }
        public Worker(int id, string firstName, string secondName, DateTime birthDate, Professions profession): base(id, firstName, secondName, birthDate)
        {
           Profession = profession;
        }
    }
}
