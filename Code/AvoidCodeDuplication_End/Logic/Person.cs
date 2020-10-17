namespace AvoidCodeDuplication_Start.Logic
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Gender Gender { get; private set; }

        public Person(int id, string firstName, string lastName, Gender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}
