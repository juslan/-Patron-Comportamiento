using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PatronComportamiento_Strategy.PaymentMethods
{
    class CreditCard : IPayment
    {
        public void TotalToPay(List<Product> products)
        {
            var total = products.Select(p => { return p.Price; });
            decimal res = total.Sum();
            res = res - (res * 0.2m); 
            Console.WriteLine($"Su total a pagar es: {res} se le aplico un 20% de descuento");

        }
    }
}
