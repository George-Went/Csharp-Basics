namespace Interfaces
{
    // Interfaces 
    // Interfaces are a "contract" for what something can do, not what it is
    // Interfaces allow for multiple inheritance 
    // Interaces can force classes to have certian methods

    // This also demonstraighs polymophism

    // Run program
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog rover = new Dog();
            rover.EatString("steak");
            rover.MakeSound();

            Cat smudge = new Cat();
            smudge.EatString("Fish");
            smudge.MakeSound();

            // Payment 
            // Credit Card
            IPaymentProcessor card_payment   = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(card_payment);
            paymentService.ProcessOrderPayment(100.95m);

            // Cash
            IPaymentProcessor cash_payment = new CashProcessor();
            paymentService = new PaymentService(cash_payment); // payment service is jsut used as get/set for payment objects
            paymentService.ProcessOrderPayment(50.20m);

        }
    }
}
