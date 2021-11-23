using System;
using System.Collections.Generic;
using System.Linq;

namespace Grinding_task_2
{
    public class Warehouse
    {
        private readonly List<Cell> _cells;

        public Warehouse()
        {
            _cells = new List<Cell>();
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public void Add(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            var newCell = new Cell(good, count);

            Cell cell = _cells.FirstOrDefault(cell => cell.Good == good);

            if (cell == null)
                _cells.Add(newCell);
            else
                cell.Merge(newCell);
        }

        public Cell Get(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Cell cell = _cells.FirstOrDefault(cell => cell.Good == good);

            if (cell == null)
            {
                throw new ArgumentException(nameof(good));
            }
            else
            {
                cell.Decrease(good, count);
                return new Cell(good, count);
            }
        }
    }
}
