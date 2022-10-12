using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    public class CreditCard : IPaymentMethod
    {
        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                if (value <= 0) _amount = value;
                else throw new ArgumentOutOfRangeException("Amount", $"Credit card amount cannot be more than zero (provided value: {value:N})");
            }
        }

        public string Currency { get; init; }

        public CreditCard(double Amount, string Currency = "EUR")
            : this()
        {
            this.Amount = Amount;
            this.Currency = Currency;
        }
        public CreditCard()
        {
            _amount = 0;
            Currency = "EUR";
        }

        public override string ToString() => $"{Amount:N} {Currency}";
    }
}
