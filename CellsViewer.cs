using System;
using System.Collections.Generic;

namespace Grinding_task_2
{
    public class CellsViewer
    {
        public void ShowCells(IReadOnlyList<IReadOnlyCell> cells)
        {
            foreach (var cell in cells)
            {
                Console.WriteLine($"Товар: {cell.Good.Name} - {cell.Count} шт.");
            }
        }
    }
}