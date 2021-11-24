namespace Inharitance_task_2
{
    public class OrderRule2 : IOrderRule
    {
        public string GetOrderData(Order order)
        {
            return $"{order.Id}{order.Amount}";
        }
    }
}
