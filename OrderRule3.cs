using System;

namespace Inharitance_task_2
{
    public class OrderRule3 : IOrderRule
    {
        private readonly string _secretKey;

        public OrderRule3(string secretKey)
        {
            _secretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
        }

        public string GetOrderData(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            return $"{order.Amount}{order.Id}{_secretKey}";
        }
    }
}
