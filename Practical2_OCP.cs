// Practical 2: Discount Management
// Objective: Demonstrate Open/Closed Principle (OCP)
// Base interface lets us add new discounts without changing existing discount code.

using System;

namespace SolidAssignments.Practical2
{
    // Interface for all discounts
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal price);
    }

    // 10% Discount for Regular Customers
    public class RegularCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price - (price * 0.10m);
        }
    }

    // 20% Discount for Premium Customers
    public class PremiumCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price - (price * 0.20m);
        }
    }

    // 30% Discount for Gold Customers
    public class GoldCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price - (price * 0.30m);
        }
    }

    // Calculator class doesn't need to change when a new discount type is added
    public class DiscountCalculator
    {
        public decimal GetFinalBillAmount(decimal amount, IDiscountStrategy discountStrategy)
        {
            return discountStrategy.CalculateDiscount(amount);
        }
    }
}