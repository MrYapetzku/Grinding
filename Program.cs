using System;

namespace Inhatitance_task_1
{
    internal class Program
    {
        private static void Main()
        {
            Pathfinder pathfinder1 = new Pathfinder(new FileLogWritter());
            Pathfinder pathfinder2 = new Pathfinder(new ConsoleLogWritter());
            Pathfinder pathfinder3 = new Pathfinder(new DayOfWeekLogWritter(new FileLogWritter(), DayOfWeek.Friday));
            Pathfinder pathfinder4 = new Pathfinder(new DayOfWeekLogWritter(new ConsoleLogWritter(), DayOfWeek.Friday));
            Pathfinder pathfinder5 = new Pathfinder(new ConsoleLogWritter(new DayOfWeekLogWritter(new FileLogWritter(), DayOfWeek.Friday)));

            pathfinder1.Find("Pathfinder1 massage");
            pathfinder2.Find("Pathfinder2 massage");
            pathfinder3.Find("Pathfinder3 massage");
            pathfinder4.Find("Pathfinder4 massage");
            pathfinder5.Find("Pathfinder5 massage");
        }
    }
}