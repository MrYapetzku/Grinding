using System;

namespace Grinding_task_2
{
    public class Cell : IReadOnlyCell
    {
        public Good Good { get; private set; }
        public int Count { get; private set; }

        public Cell(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Good = good;
            Count = count;
        }

        public void Merge(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }

        public void Decrease(Good good, int count)
        {
            if (good != Good)
                throw new InvalidOperationException();

            if (count > Count)
                throw new ArgumentOutOfRangeException(nameof(count));

            Count -= count;
        }

        public void Show()
        {
            Console.WriteLine($"Товар: {Good.Name} - {Count} шт.");
        }
    }

    public interface IReadOnlyCell
    {
        public Good Good { get; }
        public int Count { get; }

        public void Show();
    }
}
