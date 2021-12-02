using System;

namespace Grinding_task_2
{
    public class Good
    {
        public Good(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; private set; }
    }
}
