using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Cart
    {
        private readonly Warehouse _warehouse;
        private readonly List<Cell> _cells;

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
            _cells = new List<Cell>();
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            _cells.Add(_warehouse.Get(good, count));
        }

        public Order Order()
        {
            Order order = new Order(_cells, "store.com/paylink");
            _cells.Clear();

            return order;
        }

        public void Cancel()
        {
            foreach (var cell in _cells)
                _warehouse.Add(cell.Good, cell.Count);

            _cells.Clear();
        }
    }
}
