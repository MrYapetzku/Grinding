namespace Inharitance_task_2
{
    internal class Program
    {
        private static void Main()
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
}
