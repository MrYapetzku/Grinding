using System;
using System.IO;

namespace Inhatitance_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pathfinder pathfinder1 = new Pathfinder(new FileLogWritter());
            Pathfinder pathfinder2 = new Pathfinder(new ConsoleLogWritter());
            Pathfinder pathfinder3 = new Pathfinder(new DayOfWeekLogWritter(new FileLogWritter(), DayOfWeek.Friday));
            Pathfinder pathfinder4 = new Pathfinder(new DayOfWeekLogWritter(new ConsoleLogWritter(), DayOfWeek.Friday));
            Pathfinder pathfinder5 = new Pathfinder(new ConsoleLogWritter(new DayOfWeekLogWritter(new FileLogWritter(), DayOfWeek.Friday)));
        }
    }

    public class ConsoleLogWritter : ILogger
    {
        private ILogger _logger;

        public ConsoleLogWritter()
        {
        }

        public ConsoleLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            Console.WriteLine(message);
            if (_logger == null)
                return;
            _logger.WriteError(message);
        }
    }

    public class FileLogWritter : ILogger
    {
        private ILogger _logger;

        public FileLogWritter()
        {
        }

        public FileLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            if (_logger == null)
                return;
            _logger.WriteError(message);
        }
    }

    public class DayOfWeekLogWritter : ILogger
    {
        private ILogger _logger;
        private DayOfWeek _dayOfWeek;

        public DayOfWeekLogWritter(ILogger logger, DayOfWeek dayOfWeek)
        {
            _logger = logger;
            _dayOfWeek = dayOfWeek;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == _dayOfWeek)
            {
                _logger.WriteError(message);
            }
        }
    }

    public interface ILogger
    {
        public void WriteError(string message);
    }
}