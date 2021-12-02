using System;
using System.IO;

namespace Inhatitance_task_1
{
    public class FileLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public FileLogWritter()
        {
        }

        public FileLogWritter(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            if (_logger == null)
                return;
            _logger.WriteError(message);
        }
    }
}