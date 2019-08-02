using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger()
        {
            INFO = 1;
            DEBUG = 1;
            ERROR = 1;
            level = 1;
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
