namespace PolymorphismOverEnum_End.Logic
{
    public class WeekendStudent : Student
    {
        public WeekendStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override int GetMinimumCreditPointsToPromote()
        {
            // compute and return credits for weekend courses
            return 35;
        }
    }
}
