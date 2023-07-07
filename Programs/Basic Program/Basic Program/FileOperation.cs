using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class FileOperation
    {
       public void CreateFile()
       {
            FileInfo fi = new FileInfo("D:\\C# training\\Sample.txt");
            using StreamWriter str = fi.CreateText();


            FileInfo f2 = new FileInfo("D:\\C# training\\Sample2.txt");
            using StreamWriter str2 = f2.CreateText();

            Console.WriteLine("File has been created");

            str.WriteLine("hello");
            str.WriteLine("hi");

            Console.WriteLine("Written");
        }

        public void DeleteFile() 
        {
            FileInfo fi = new FileInfo("D:\\C# training\\Sample.txt");
            fi.Delete();
            Console.WriteLine("Deleted");
        }

        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("D:\\C# training\\Sample.txt");
            
            fi1.CopyTo("D:\\C# training\\Temp\\Sample2.txt");
            fi1.MoveTo("D:\\C# training\\Temp2\\Sample2.txt");
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\C# training\\Sample.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text to write");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("D:\\C# training\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str !=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void FileProperties()
        {
            FileInfo fi = new FileInfo("D:\\C# training\\Sample.txt");
            Console.WriteLine($"File name is {fi.Name}");
            Console.WriteLine($"Creation Time is {fi.CreationTime.ToLongTimeString()}");
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
        }
    }
}
