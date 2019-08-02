using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_Library
{
    public class PaymentMonitor : IObserver
    {
        public void Display(Invoice invoice)
        {
            Console.WriteLine("Amount {0} was paid.", invoice.Amount);
        }

        public void Update(Subject subject)
        {
            if (subject is Invoice)
                Display((Invoice)subject);
        }
    }
}
