using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Order
    {
        public Order(List<Cell> cells, string paylink)
        {
            Cells = cells ?? throw new ArgumentNullException(nameof(cells));
            Paylink = paylink ?? throw new ArgumentNullException(nameof(paylink));
        }

        public IReadOnlyList<IReadOnlyCell> Cells { get; private set; }

        public string Paylink { get; private set; }
    }
}
