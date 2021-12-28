using System;

namespace Grinding
{
    public class OrderForm
    {
        public IPaymentSystem ShowForm()
        {
            Console.WriteLine("Мы принимаем: QIWI, WebMoney, Card");

            // симуляция веб интерфейса
            Console.WriteLine("Какой системой вы хотите совершить оплату?");

            return Console.ReadLine() switch
            {
                "QIWI" => new Qiwi(),
                "WebMoney" => new WebMoney(),
                "Card" => new Card(),
                _ => throw new Exception("Введена некорректная система оплаты."),
            };
        }
    }
}