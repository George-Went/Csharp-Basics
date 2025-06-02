using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Interface used by two payment methods
    public interface IPaymentProcessor
    {
        void processPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void processPayment(decimal amount) 
        {
            Console.WriteLine($"Process credit card payment of {amount}");
            // credit car logic
        }
    }
    public class CashProcessor : IPaymentProcessor 
    {
        public void processPayment(decimal amount)
        {
            Console.WriteLine($"Process cash payment of {amount}");
            // cash payment method
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService ( IPaymentProcessor processr)
        {
            _processor = processr; // set (no get) for payment value
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.processPayment(amount);
        } 
    }


}
