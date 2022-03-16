namespace Inharitance_task_2
{
    public class Order
    {
        public Order(int id, int amount) => (Id, Amount) = (id, amount);

        public int Id { get; private set; }

        public int Amount { get; private set; }
    }
}
