using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger()
        {
            INFO = 3;
            DEBUG = 3;
            ERROR = 3;
            level = 3;
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
