using System.Collections.Generic;

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

        public int CountFemales()
        {
            int count = 0;
            foreach (var person in persons)
            {
                if (person.Gender == Gender.Female)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountMales()
        {
            int count = 0;
            foreach (var person in persons)
            {
                if (person.Gender == Gender.Male)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
