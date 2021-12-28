using System;

namespace Grinding
{
    internal class Program
    {
        private static void Main()
        {
            var orderForm = new OrderForm();
            var paymentHandler = new PaymentHandler();

            IPaymentSystem systemId = orderForm.ShowForm();

            Console.WriteLine(systemId.GetTransferToPayingSystem());

            paymentHandler.ShowPaymentResult(systemId);
        }
    }
}