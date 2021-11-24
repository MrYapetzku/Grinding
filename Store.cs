using System;

namespace Grinding_task_2
{
    internal class Store
    {
        private static void Main(string[] args)
        {
            CellsViewer cellsViewer = new CellsViewer();
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Add(iPhone12, 10);
            warehouse.Add(iPhone11, 1);

            cellsViewer.ShowCells(warehouse.Cells);

            Cart cart = shop.Cart();

            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            cellsViewer.ShowCells(cart.Cells);

            Console.WriteLine(cart.Order().Paylink);

            cart.Add(iPhone12, 9);
        }
    }
}