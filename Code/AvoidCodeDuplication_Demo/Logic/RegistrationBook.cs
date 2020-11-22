using System.Collections.Generic;
using System.Linq;

namespace AvoidCodeDuplication_Demo.Logic
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
            return persons.Where(p => p.Gender == gender).Count();

            //int count = 0;
            //foreach (var person in persons)
            //{
            //    if (person.Gender == gender)
            //    {
            //        count++;
            //    }
            //}
            //return count;
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
