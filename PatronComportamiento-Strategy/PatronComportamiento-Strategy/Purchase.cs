using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComportamiento_Strategy
{
    class Purchase
    {
        public IPayment PaymentStrategy { get; set; }
        public List<Product> Products { get; set; }
        public Purchase()
        {
            Products = new List<Product>();
        }
        public void SetPaymentStrategy(IPayment strategy)
        {
            PaymentStrategy = strategy;
        }
        public void TotalToPay()
        {
            PaymentStrategy.TotalToPay(Products);
        }

    }
}
