namespace PolymorphismOverEnum_End.Logic
{
    public class DailyStudent : Student
    {
        public DailyStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override int GetMinimumCreditPointsToPromote()
        {
            // compute and return credits for daily courses
            return 100;
        }
    }
}
