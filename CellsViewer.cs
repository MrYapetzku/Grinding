using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class CellsViewer
    {
        public void ShowCells(IReadOnlyDictionary<Good, int> cells)
        {
            if (cells == null)
                throw new ArgumentNullException(nameof(cells));

            foreach (var cell in cells)
            {
                Console.WriteLine($"Товар: {cell.Key.Name} - {cell.Value} шт.");
            }
        }
    }
}