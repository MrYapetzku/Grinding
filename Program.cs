using System;
using System.Security.Cryptography;
using System.Text;

namespace Inharitance_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentSystem paymentSystem1 = new PaymentSystem(new LinkRule1("pay.system1.ru/order?amount=12000RUB&hash="));
            PaymentSystem paymentSystem2 = new PaymentSystem(new LinkRule2("order.system2.ru/pay?hash="));
            PaymentSystem paymentSystem3 = new PaymentSystem(new LinkRule3("system3.com/pay?amount=12000&curency=RUB&hash="));

            Order order = new Order(1367, 12000);

            Console.WriteLine(paymentSystem1.GetPayingLink(order));
            Console.WriteLine(paymentSystem2.GetPayingLink(order));
            Console.WriteLine(paymentSystem3.GetPayingLink(order));

        }
    }

    public class Order
    {
        public readonly int Id;
        public readonly int Amount;

        public Order(int id, int amount) => (Id, Amount) = (id, amount);
    }

    public class LinkRule1 : ILinkRule
    {
        private string _link;

        public LinkRule1(string link)
        {
            _link = link;
        }

        public string GetLink(Order order)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(order.Id.ToString());
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }

            return $"{_link}{stringBuilder}";
        }
    }

    public class LinkRule2 : ILinkRule
    {
        private string _link;

        public LinkRule2(string link)
        {
            _link = link;
        }

        public string GetLink(Order order)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(order.Id.ToString());
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }

            return $"{_link}{stringBuilder}{order.Amount}";
        }
    }

    public class LinkRule3 : ILinkRule
    {
        private string _link;

        public LinkRule3(string link)
        {
            _link = link;
        }

        public string GetLink(Order order)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(order.Id.ToString());
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }

            return $"{_link}{stringBuilder}{order.Id}<секретный ключ>";
        }
    }

    public class PaymentSystem : IPaymentSystem
    {
        private ILinkRule _linkRule;

        public PaymentSystem(ILinkRule linkRule)
        {
            _linkRule = linkRule;
        }

        public string GetPayingLink(Order order)
        {
            return _linkRule.GetLink(order);
        }
    }

    public interface ILinkRule
    {
        public string GetLink(Order order);
    }

    public interface IPaymentSystem
    {
        public string GetPayingLink(Order order);
    }
}
