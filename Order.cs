using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Order
    {
        private readonly Dictionary<Good, int> _cells;
        private readonly string _payLink = "store.com/paylink";

        public Order(IReadOnlyDictionary<Good, int> cells)
        {
            Cells = cells ?? throw new ArgumentNullException(nameof(cells));
            _cells = new Dictionary<Good, int>();
            foreach (var cell in cells)
                _cells.Add(cell.Key, cell.Value);
        }

        public IReadOnlyDictionary<Good, int> Cells { get; private set; }

        public string Paylink => _payLink;
    }
}
