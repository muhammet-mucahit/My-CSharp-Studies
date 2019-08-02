using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Encryption
{
    class Program
    {
        static void Encryption()
        {
             int e;
            char f;
            string text;
            string encrypted_text;

            string file_read = "Text.txt";
            FileStream fs_read = new FileStream(file_read, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_read);

            text = sr.ReadLine();

            string file_write = "EncryptedText.txt";
            FileStream fs_write = new FileStream(file_write, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs_write);

            while (text != null)
            {
                encrypted_text = "";
                foreach (char item in text)
                {
                    e = item;
                    e += 3;
                    f = (char)e;
                    encrypted_text += f;
                }

                sw.WriteLine(encrypted_text);

                text = sr.ReadLine();
            }

            sr.Close();
            fs_read.Close();
            sw.Flush();
            sw.Close();
            fs_write.Close();   
        }

        static void Decryption()
        {
            int g;
            char h;
            string encrypted_text;
            string decrypted_text;

            string file_read = "EncryptedText.txt";
            FileStream fs_read = new FileStream(file_read, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_read);

            encrypted_text = sr.ReadLine();

            string file_write = "DecryptedText.txt";
            FileStream fs_write = new FileStream(file_write, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs_write);

            while (encrypted_text != null)
            {
                decrypted_text = "";

                foreach (char item in encrypted_text)
                {
                    g = item;
                    g -= 3;
                    h = (char)g;
                    decrypted_text += h;
                }

                sw.WriteLine(decrypted_text);

                encrypted_text = sr.ReadLine();
            }

            sr.Close();
            fs_read.Close();
            sw.Flush();
            sw.Close();
            fs_write.Close();      
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my friends, \nPlease select the transaction that you want to do:");
            Console.WriteLine("\t1-Encryption\t2-Decryption");

            int transaction = Console.Read();

            if (transaction == '1')
                Encryption();
            else if (transaction == '2')
                Decryption();
            else
                Console.WriteLine("You entered invalid option!");

            Console.WriteLine();
        }
    }
}

