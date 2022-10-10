using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    /// <summary>
    /// An interface containing basic properties for any mean of payment.
    /// </summary>
    public interface IPaymentMethod
    {
        double Amount { get; set; }
        string Currency { get; init; }
    }
}
