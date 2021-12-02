using System;

namespace Inharitance_task_2
{
    public class OrderRule2 : IOrderRule
    {
        public string GetOrderData(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            return $"{order.Id}{order.Amount}";
        }
    }
}
