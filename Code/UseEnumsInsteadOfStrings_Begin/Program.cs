using UseEnumsInsteadOfStrings_Begin.Logic;

namespace UseEnumsInsteadOfStrings_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nadia", "comanici", "employee");

            DashboardPage page = new DashboardPage();
            page.LogUser(user);
        }
    }
}
