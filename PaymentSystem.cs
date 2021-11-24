using System.Text;

namespace Inharitance_task_2
{
    public class PaymentSystem : IPaymentSystem
    {
        private readonly IHashRule _hashRule;
        private readonly IOderRule _orderRule;
        private readonly string _link;

        public PaymentSystem(IHashRule hashRule, IOderRule oderRule, string link)
        {
            _hashRule = hashRule;
            _orderRule = oderRule;
            _link = link;
        }

        public string GetPayingLink(Order order)
        {
            string orderData = _orderRule.GetOrderData(order);
            byte[] inputBytes = Encoding.ASCII.GetBytes(orderData);
            byte[] hashBytes = _hashRule.GetHash(inputBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }

            return $"{_link}{stringBuilder}";
        }
    }
}
