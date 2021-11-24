namespace Inharitance_task_2
{
    public class OrderRule1 : IOrderRule
    {
        public string GetOrderData(Order order)
        {
            return $"{order.Id}";
        }
    }
}
