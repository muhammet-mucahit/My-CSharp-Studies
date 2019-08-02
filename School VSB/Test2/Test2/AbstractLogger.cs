using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public abstract class AbstractLogger : ChainPatternDemo
    {
        public int INFO { get; set; }
        public int DEBUG { get; set; }
        public int ERROR { get; set; }
        public int level { get; set; }

        AbstractLogger nextLogger;

        public abstract void setNextLogger();
        public abstract void logMessage();
        public abstract void write();

        public void Save()
        {
            using (FileStream fs = new FileStream("abstract.bin", FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(INFO);
                bw.Write(DEBUG);
                bw.Write(ERROR);
                bw.Write(level);
            }
        }

        //public void Load()
        //{
        //    List<AbstractLogger> result = new List<AbstractLogger>();

        //    using (FileStream fs = new FileStream("abstract.bin", FileMode.OpenOrCreate, FileAccess.Read))
        //    using (BinaryReader br = new BinaryReader(fs))
        //    {
        //        while (fs.Position < fs.Length)
        //        {
        //            result.Add(new AbstractLogger()
        //            {
        //                INFO = br.ReadInt32(),
        //                ERROR = br.ReadInt32(),
        //                DEBUG = br.ReadInt32()
        //            });
        //        }
        //    }

        //    return result;
        //}
    }
}
