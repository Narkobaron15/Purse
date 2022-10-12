using System;

namespace Purse
{
    internal class Program
    {
        private static void Main()
        {
            IPaymentMethod money = new Money(6.25d, "UAH");
            Console.WriteLine(money);

            // hint: credit card may have negative balance

            IPaymentMethod creditCard = new CreditCard(0, "UAH");
            Console.WriteLine(creditCard);
        }
    }
}