namespace Inhatitance_task_1
{
    public class Pathfinder
    {
        private ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Find(string massage)
        {
            _logger.WriteError(massage);
        }
    }
}
