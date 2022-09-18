using System;
namespace MyFirstConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            GlazerApp.RunExample();

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
        private static void GetUserNameAndLocation()
        {
            var person = new Person("", "");
            Console.Write("What is your name? ");

            person.Name = Console.ReadLine();

            Console.Write($"\nHi {person.Name}. Where are you from? ");

            person.Location = Console.ReadLine();

            Console.Write($"\nI have never been to {person.Location}. I bet it is nice.\n");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
        private static void ChristmasCountdown()
        {
            var todaysDate = DateTime.Today;
            var christmasDay = new DateTime(todaysDate.Year, 12, 25);

            var daysUntilChristmas = christmasDay.DayOfYear - todaysDate.DayOfYear;

            Console.WriteLine($"\nToday's date is: {todaysDate.ToString("MM/dd/yyyy")}.");

            Console.Write($"There are {daysUntilChristmas} days until Christmas!");
            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();
        }

    }

}

