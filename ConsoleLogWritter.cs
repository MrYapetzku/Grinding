using System;

namespace Inhatitance_task_1
{
    public class ConsoleLogWritter : ILogger
    {
        private readonly ILogger _logger;

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
}