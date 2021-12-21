using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Warehouse
    {
        private readonly Dictionary<Good, int> _cells;

        public Warehouse()
        {
            _cells = new Dictionary<Good, int>();
        }

        public IReadOnlyDictionary<Good, int> Cells => _cells;

        public virtual void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_cells.ContainsKey(good))
                _cells[good] += count;
            else
                _cells.Add(good, count);
        }

        public void Remove(Good good, int count)
        {
            if (_cells.ContainsKey(good) == false)
                throw new ArgumentException(nameof(good));

            if (count < 0 || count > _cells[good])
                throw new ArgumentOutOfRangeException(nameof(count));

            _cells[good] -= count;
        }
    }
}
