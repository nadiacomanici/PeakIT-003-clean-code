namespace UseEnumsInsteadOfStrings_Begin.Logic
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Role { get; private set; }

        public User(string firstName, string lastName, string role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
        }
    }
}
