using System;

namespace Inhatitance_task_1
{
    public class Pathfinder
    {
        private readonly ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Find(string massage)
        {
            _logger.WriteError(massage);
        }
    }
}
