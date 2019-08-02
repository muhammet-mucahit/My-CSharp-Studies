using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8Library
{
    public class PaymentMonitor
    {
        public void InvoiceIsPaid(object sender, InvoiceEventArgs args)
        {
            Console.WriteLine("Message from Invoice: " + args.Message);
        }
    }
}
