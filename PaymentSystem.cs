using System;
using System.Text;

namespace Inharitance_task_2
{
    public class PaymentSystem : IPaymentSystem
    {
        private readonly IHashRule _hashRule;
        private readonly IOrderRule _orderRule;
        private readonly string _link;

        public PaymentSystem(IHashRule hashRule, IOrderRule orderRule, string link)
        {
            _hashRule = hashRule ?? throw new ArgumentNullException(nameof(hashRule));
            _orderRule = orderRule ?? throw new ArgumentNullException(nameof(orderRule));
            _link = link ?? throw new ArgumentNullException(nameof(link));
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
