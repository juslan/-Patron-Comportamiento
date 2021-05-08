using PatronComportamiento_Strategy.PaymentMethods;
using System;

namespace PatronComportamiento_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase();
            purchase.Products.Add(new Product("Pañales", 45));
            purchase.Products.Add(new Product("Aceite", 35));
            purchase.Products.Add(new Product("Carne", 95));
            purchase.Products.Add(new Product("Galletas", 25));
            purchase.Products.Add(new Product("Vino", 64));
            purchase.Products.Add(new Product("Pan", 10));
            purchase.SetPaymentStrategy(new CreditCard());
            purchase.TotalToPay();
            purchase.SetPaymentStrategy(new Coupons());
            purchase.TotalToPay();
            purchase.SetPaymentStrategy(new Cash());
            purchase.TotalToPay();    
        }
    }
}
