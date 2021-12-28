using System;

namespace Grinding
{
    public class PaymentHandler
    {
        public void ShowPaymentResult(IPaymentSystem systemId)
        {
            Console.WriteLine($"Вы оплатили с помощью {systemId.Name}");

            Console.WriteLine(systemId.GetPayingProcess());

            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}