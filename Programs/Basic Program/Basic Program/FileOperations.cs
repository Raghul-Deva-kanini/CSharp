using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class FileOperations
    {
        public bool createfile()
        {
            /*FileInfo f1 = new FileInfo("D:\\C# training\\Sample2.txt");
            if (f1.Exists)
            {
                Console.WriteLine("File Exists");
                Console.WriteLine(f1.IsReadOnly);
            }*/

            bool Locked = false;
            try
            {
                FileStream fs = File.Open("D:\\C# training\\Sample2.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                Locked = true;
            }
            finally
            {
                Console.WriteLine("Constraints has been checked");
            }
            return Locked;
        }

        public void writingToFile()
        {
            FileStream fs = new FileStream("D:\\C# training\\Sample2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Input the string to ignore the line");
            string word = Console.ReadLine();
            Console.WriteLine("Input number of lines to write in the file");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {num} strings below :");
            for (int i=0;i<num;i++)
            {
                Console.WriteLine($"Input line {i+1} :");
                string sentence = Console.ReadLine();
                if (!sentence.Contains(word))
                {
                    sw.WriteLine(sentence);
                }
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void readFromFile()
        {
            Console.WriteLine("Enter the line number to read a specific line from the file");
            int l = Convert.ToInt32(Console.ReadLine());
            string[] lines = File.ReadAllLines("D:\\C# training\\Sample2.txt");
            Console.WriteLine(" {0}", lines[l - 1]);
        }
    }
}
