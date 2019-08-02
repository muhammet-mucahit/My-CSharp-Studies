using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Inventory
    {
        InventoryComparer com = new InventoryComparer();
        private Dictionary<string, int> inventor = new Dictionary<string, int>();
        public event EventHandler<string> MultipleInsert;

        public void Add(string partNumber, int quantity)
        {
            if(Get(partNumber) == 0)
                inventor.Add(partNumber, quantity);
            else
            {
                inventor[partNumber] = quantity;
                if (this.MultipleInsert != null)
                    this.MultipleInsert.Invoke(this, string.Format("Ooops, {0} partnumber already contains in inventory list", partNumber));        
            }      
        }

        public int Get(string partNumber)
        {
            if (inventor.ContainsKey(partNumber))
                return inventor[partNumber];
            return 0;
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("output.txt", false);
            var list = inventor.ToList<KeyValuePair<string, int>>();

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (com.Compare(list[i], list[i + 1]) == 1) ;
                    else
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }

            list.ForEach(x => writer.WriteLine("Part : {0}, Qty : {1}", x.Key, x.Value));
            writer.Flush();
            writer.Close();
           
            //var list = inventor.ToList<KeyValuePair<string, int>>();

            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    if (com.Compare(list[i], list[i + 1]) == 1) ;
            //    else
            //    {
            //        var temp = list[i];
            //        list[i] = list[i + 1];
            //        list[i + 1] = temp;
            //    }
            //}

            //using (FileStream fs = new FileStream("inventories.txt", FileMode.Create, FileAccess.Write))
            //using (StreamWriter sw = new StreamWriter(fs))
            //{
            //    //foreach (var item in list)
            //    //{
            //    //    sw.WriteLine(item);
            //    //}

            //    foreach (KeyValuePair<string,Int32> item in list)
            //    {
            //        sw.WriteLine(item.Key + " – " + item.Value.ToString());
            //    }
            //}

            //using (FileStream fs = new FileStream("inventory.txt", FileMode.Create, FileAccess.Write))
            //using (StreamWriter sw = new StreamWriter(fs))
            //{       
            //    //foreach (var item in inventor)
            //    //{
            //    //    sw.WriteLine(item);
            //    //}

            //    foreach (KeyValuePair<string,Int32> item in inventor)
            //    {
            //        sw.WriteLine(item.Key + " – " + item.Value.ToString());
            //    }
            //}
        }

        private class InventoryComparer : IComparer<KeyValuePair<string, int>>
        {
            public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
            {
                return x.Value.CompareTo(y.Value);
            }
        }
    }
}

