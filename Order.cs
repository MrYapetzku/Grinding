using System.Collections.Generic;

namespace Grinding_task_2
{
    public class Order
    {
        public IReadOnlyList<IReadOnlyCell> Cells;
        public string Paylink { get; private set; }

        public Order(List<Cell> cells, string paylink)
        {
            Cells = cells;
            Paylink = paylink;
        }
    }
}
