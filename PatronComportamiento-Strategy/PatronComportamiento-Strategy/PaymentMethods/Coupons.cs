using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronComportamiento_Strategy.PaymentMethods
{
    class Coupons : IPayment
    {
        public void TotalToPay(List<Product> products)
        {
            var total = products.Select(p => { return p.Price; });
            decimal res = total.Sum();
            res = res - (res * 0.15m);
            Console.WriteLine($"Su total a pagar es: {res} se le aplico un 15% de descuento");
        }
    }
}
