using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test2
{
    class Program
    {
        public delegate void MyDelegate(AbstractLogger item);

        static void print(AbstractLogger item)
        {
            item.write();
        }

        static void LoadConfiguration()
        {
            //using (XmlTextReader xmlReader = new XmlTextReader("App.config"))
            //{
            //    xmlReader.ReadToFollowing("configuration");
            //    xmlReader.ReadToFollowing("startup");
            //    this.logtype = xmlReader.ReadElementContentAsString();
            //}
        }

        public static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(getConfigFilePath());
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        

        static void Main(string[] args)
        {
            FileLogger a = new FileLogger();
            ErrorLogger b = new ErrorLogger();
            ConsoleLogger c = new ConsoleLogger();
            
            //print(b);

            MyDelegate delege = new MyDelegate(print);
            //delege(a);


        }
    }
}
