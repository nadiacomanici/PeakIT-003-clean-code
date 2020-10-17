using System;
using PolymorphismOverEnum_Begin.Logic;

namespace PolymorphismOverEnum_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Student nadia = new Student("Nadia", "Comanici", AttendanceTypes.Daily);
            Student ionel = new Student("Ionel", "Ionescu", AttendanceTypes.Evening);
            Student maria = new Student("Maria", "Popescu", AttendanceTypes.Weekend);

            Console.WriteLine($"{nadia.FirstName} are nevoie de {nadia.GetMinimumCreditPointsToPromote()} credite.");
            Console.WriteLine($"{ionel.FirstName} are nevoie de {ionel.GetMinimumCreditPointsToPromote()} credite.");
            Console.WriteLine($"{maria.FirstName} are nevoie de {maria.GetMinimumCreditPointsToPromote()} credite.");
        }
    }
}
