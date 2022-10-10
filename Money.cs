using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    /// <summary>
    /// A class designed for work with plain cash.
    /// </summary>
    public struct Money : IPaymentMethod
    {
        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                if (value >= 0) _amount = value;
                else throw new ArgumentOutOfRangeException("Amount", $"Amount cannot be less than zero (provided value: {value:N})");
            }
        }

        public string Currency { get; init; }

        public Money(double Amount, string Currency = "EUR")
            : this()    // warning suppression
        {
            this.Amount = Amount;
            this.Currency = Currency;
        }
        public Money()
        {
            _amount = 0;
            Currency = "EUR";
        }

        public override string ToString() => $"{Amount:N} {Currency}";
    }
}
