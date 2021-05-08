using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComportamiento_Strategy
{
    interface IPayment
    {
        public void TotalToPay(List<Product> products);
    }
}
