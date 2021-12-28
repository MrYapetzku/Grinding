namespace Grinding
{
    public interface IPaymentSystem
    {
        string Name { get; }

        string GetPayingProcess();

        string GetTransferToPayingSystem();
    }
}