using System;

namespace Inhatitance_task_1
{
    public class DayOfWeekLogWritter : ILogger
    {
        private readonly ILogger _logger;
        private readonly DayOfWeek _dayOfWeek;

        public DayOfWeekLogWritter(ILogger logger, DayOfWeek dayOfWeek)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

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
}