using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidCodeDuplication_Start.Logic
{
    public class RegistrationBook
    {
        private int nextId;
        private List<Person> persons;
        
        public RegistrationBook()
        {
            persons = new List<Person>();
            nextId = 0;
        }

        public void RegisterPerson(string firstName, string lastName, Gender gender)
        {
            var person = new Person(nextId++, firstName, lastName, gender);
            persons.Add(person);
        }

        private int CountByGender(Gender gender)
        {
            return persons.Count(p => p.Gender == gender);
        }

        public int CountFemales()
        {
            return CountByGender(Gender.Female);
        }

        public int CountMales()
        {
            return CountByGender(Gender.Male);
        }
    }
}