using UseEnumsInsteadOfStrings_Demo.Logic;

namespace UseEnumsInsteadOfStrings_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nadia", "comanici", UserRole.Admin);

            DashboardPage page = new DashboardPage();
            page.LogUser(user);
        }
    }
}
