using System;

namespace UseEnumsInsteadOfStrings_Begin.Logic
{
    public class DashboardPage
    {
        public void LogUser(User user)
        {
            if (user.Role == "manager")
            {
                GiveAdminRights();
            }
            else
            {
                if (user.Role == "employee")
                {
                    GiveEditRights();
                }
                else
                {
                    GiveReadOnlyRights();
                }
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
