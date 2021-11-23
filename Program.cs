using System;
using System.Security.Cryptography;
using System.Text;

namespace Inharitance_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentSystem paymentSystem1 = new PaymentSystem(new MD5Rule(), new OrderRule1(), "pay.system1.ru/order?amount=12000RUB&hash=");
            PaymentSystem paymentSystem2 = new PaymentSystem(new MD5Rule(), new OrderRule2(), "order.system2.ru/pay?hash=");
            PaymentSystem paymentSystem3 = new PaymentSystem(new SHA1Rule(), new OrderRule3("SECRETKEY"), "system3.com/pay?amount=12000&curency=RUB&hash=");

            Order order = new Order(1367, 12000);

            LinkViewer linkViewer = new LinkViewer();

            linkViewer.ShowPayingLink(paymentSystem1.GetPayingLink(order));
            linkViewer.ShowPayingLink(paymentSystem2.GetPayingLink(order));
            linkViewer.ShowPayingLink(paymentSystem3.GetPayingLink(order));
        }
    }

    public class Order
    {
        public readonly int Id;
        public readonly int Amount;

        public Order(int id, int amount) => (Id, Amount) = (id, amount);
    }

    public class LinkViewer
    {
        public void ShowPayingLink(string link)
        {
            Console.WriteLine(link);
        }
    }

    public class PaymentSystem : IPaymentSystem
    {
        private IHashRule _hashRule;
        private IOderRule _orderRule;
        private string _link;

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

    public class OrderRule1 : IOderRule
    {
        public string GetOrderData(Order order)
        {
            return $"{order.Id}";
        }
    }

    public class OrderRule2 : IOderRule
    {
        public string GetOrderData(Order order)
        {
            return $"{order.Id}{order.Amount}";
        }
    }

    public class OrderRule3 : IOderRule
    {
        private string _secretKey;

        public OrderRule3(string secretKey)
        {
            _secretKey = secretKey;
        }

        public string GetOrderData(Order order)
        {
            return $"{order.Amount}{order.Id}{_secretKey}";
        }
    }

    public class MD5Rule : IHashRule
    {
        public byte[] GetHash(byte[] input)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(input);
        }
    }

    public class SHA1Rule : IHashRule
    {
        public byte[] GetHash(byte[] input)
        {
            SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(input);
        }
    }    

    public interface IOderRule
    {
        public string GetOrderData(Order order);
    }

    public interface IHashRule
    {
        public byte[] GetHash(byte[] input);
    }

    public interface IPaymentSystem
    {
        public string GetPayingLink(Order order);
    }
}
