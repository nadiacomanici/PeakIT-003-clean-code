namespace UseEnumsInsteadOfStrings_Demo.Logic
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public UserRole Role { get; private set; }

        public User(string firstName, string lastName, UserRole role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
        }
    }
}
