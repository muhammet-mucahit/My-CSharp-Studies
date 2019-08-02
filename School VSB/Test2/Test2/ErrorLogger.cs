using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger()
        {
            INFO = 2;
            DEBUG = 2;
            ERROR = 2;
            level = 2;
        }

        public override void setNextLogger()
        {
            Console.WriteLine(INFO + " " + DEBUG + " " + ERROR + " " + level);
        }

        public override void logMessage()
        {
            Console.WriteLine(INFO + " " + DEBUG + " " + ERROR + " " + level);
        }

        public override void write()
        {
            Console.WriteLine(INFO + " " + DEBUG + " " + ERROR + " " + level);
        }
    }
}
