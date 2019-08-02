using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_Library
{
    public class SMSGate : IObserver
    {
        private string phone;

        public SMSGate(string phone)
        {
            this.phone = phone;
        }

        public void Send(string text)
        {
            Console.WriteLine("SMS sent to {0}: {1}", phone, text);
        }

        public void Update(Subject subject)
        {
            Send(subject.ToString());
        }
    }
}
