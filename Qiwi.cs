namespace Grinding
{
    public class Qiwi : IPaymentSystem
    {
        public Qiwi()
        {
            Name = "QIWI";
        }

        public string Name { get; private set; }

        public string GetPayingProcess()
        {
            return "Проверка платежа через QIWI...";
        }

        public string GetTransferToPayingSystem()
        {
            return "Перевод на страницу QIWI...";
        }
    }
}