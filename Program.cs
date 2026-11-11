// Main Program to execute and test all 5 Practical Assignments

using System;
using System.Collections.Generic;
using SolidAssignments.Practical1;
using SolidAssignments.Practical2;
using SolidAssignments.Practical3;
using SolidAssignments.Practical4;
using SolidAssignments.Practical5;

namespace SolidAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRACTICAL 1: SRP ===");
            Student st = new Student(101, "Vikas Kumar", "vikas@gmail.com");
            StudentDbOperations db = new StudentDbOperations();
            StudentEmailNotifier email = new StudentEmailNotifier();

            db.SaveStudentToDb(st);
            email.SendWelcomeEmail(st);

            Console.WriteLine("\n=== PRACTICAL 2: OCP ===");
            DiscountCalculator calc = new DiscountCalculator();
            decimal itemPrice = 2000m;
            Console.WriteLine("Original Price: Rs." + itemPrice);
            Console.WriteLine("Gold Customer Price (30% Off): Rs." + calc.GetFinalBillAmount(itemPrice, new GoldCustomerDiscount()));

            Console.WriteLine("\n=== PRACTICAL 3: LSP & ISP ===");
            List<IBird> myBirds = new List<IBird>
            {
                new Sparrow(),
                new Penguin(),
                new Ostrich()
            };

            foreach (var b in myBirds)
            {
                b.Eat();
                // Check if bird is a flying bird using pattern matching
                if (b is IFlyingBird flyer)
                {
                    flyer.Fly();
                }
            }

            Console.WriteLine("\n=== PRACTICAL 4: DIP & STRATEGY ===");
            PaymentProcessor payProcessor = new PaymentProcessor(new UpiPayment());
            payProcessor.ProcessTransaction(750.50m);

            // Change strategy at runtime
            payProcessor.ChangePaymentMethod(new CardPayment());
            payProcessor.ProcessTransaction(1500.00m);

            Console.WriteLine("\n=== PRACTICAL 5: FULL SOLID ===");
            List<INotificationChannel> channels = new List<INotificationChannel>
            {
                new EmailNotification(),
                new SmsNotification(),
                new PushNotification(),
                new WhatsAppNotification() // Added without modifying NotificationManager
            };

            NotificationManager manager = new NotificationManager(channels);
            manager.BroadcastMessage("Wipro COE Milestone-1 Assignment Completed!");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}