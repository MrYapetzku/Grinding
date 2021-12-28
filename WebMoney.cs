namespace Grinding
{
    public class WebMoney : IPaymentSystem
    {
        public WebMoney()
        {
            Name = "WebMoney";
        }

        public string Name { get; private set; }

        public string GetPayingProcess()
        {
            return "Проверка платежа через WebMoney...";
        }

        public string GetTransferToPayingSystem()
        {
            return "Вызов API WebMoney...";
        }
    }
}