using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Cart
    {
        private readonly List<Cell> _cells;
        private readonly Warehouse _warehouse;

        public Cart(Warehouse warehouse)
        {
            _cells = new List<Cell>();
            _warehouse = warehouse;
        }

        public void Add(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            _cells.Add(_warehouse.Give(good, count));
        }

        public IReadOnlyList<IReadOnlyCell> GiveOrder()
        {
            return _cells;
        }
    }
}
