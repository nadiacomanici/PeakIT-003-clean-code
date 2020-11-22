using System;

namespace UseEnumsInsteadOfStrings_Demo.Logic
{
    public enum UserRole
    {
        SuperAdmin,
        Admin,
        Employee,
        Other
    }

    public class DashboardPage
    {
        public void LogUser(User user)
        {
            switch(user.Role)
            {
                case UserRole.SuperAdmin:
                    GiveSuperAdminRights();
                    break;
                case UserRole.Admin:
                    GiveAdminRights();
                    break;
                case UserRole.Employee:
                    GiveEditRights();
                    break;
                default:
                    GiveReadOnlyRights();
                    break;
            }
        }

        private void GiveSuperAdminRights()
        {
            throw new NotImplementedException();
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
