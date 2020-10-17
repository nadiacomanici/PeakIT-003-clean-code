using System;

namespace UseEnumsInsteadOfStrings_End.Logic
{
    public class DashboardPage
    {
        public void LogUser(User user)
        {
            switch (user.Role)
            {
                case UserRoles.Manager:
                    GiveAdminRights();
                    break;
                case UserRoles.Employee:
                    GiveEditRights();
                    break;
                default:
                    GiveReadOnlyRights();
                    break;
            }
        }

        private void GiveReadOnlyRights()
        {
            Console.WriteLine("Has ReadOnly Rights");
        }

        private void GiveEditRights()
        {
            Console.WriteLine("Has Edit Rights");
        }

        private void GiveAdminRights()
        {
            Console.WriteLine("Has Admin Rights");
        }
    }
}
