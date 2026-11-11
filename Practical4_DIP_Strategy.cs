// Practical 4: Payment Management
// Objective: Demonstrate Dependency Inversion Principle (DIP) and Strategy Pattern
// Payment Processor depends on IPaymentMethod abstraction, allowing runtime switching.

using System;

namespace SolidAssignments.Practical4
{
    // Payment Interface
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    // Option 1: Card Payment
    public class CardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("[Card Payment] Paid Rs." + amount + " using Credit/Debit Card.");
        }
    }

    // Option 2: UPI Payment
    public class UpiPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("[UPI Payment] Paid Rs." + amount + " using GPay/PhonePe.");
        }
    }

    // Option 3: Wallet Payment
    public class WalletPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("[Wallet Payment] Paid Rs." + amount + " using Digital Wallet.");
        }
    }

    // Main Payment Context (Depends on Abstraction)
    public class PaymentProcessor
    {
        private IPaymentMethod _paymentMethod;

        // Constructor Injection
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        // Change payment option dynamically
        public void ChangePaymentMethod(IPaymentMethod newMethod)
        {
            _paymentMethod = newMethod;
        }

        public void ProcessTransaction(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}