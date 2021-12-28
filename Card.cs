namespace Grinding
{
    public class Card : IPaymentSystem
    {
        public Card()
        {
            Name = "Card";
        }

        public string Name { get; private set; }

        public string GetPayingProcess()
        {
            return "Проверка платежа через Card...";
        }

        public string GetTransferToPayingSystem()
        {
            return "Вызов API банка эмитера карты Card...";
        }
    }
}