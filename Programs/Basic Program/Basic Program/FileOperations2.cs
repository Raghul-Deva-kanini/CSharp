using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class FileOperations2
    {
        private string file_path;
        private string leap_year_file_path;
        private string non_leapyear_file_path;
        public FileOperations2(string file_path, string leap_year_file_path, string non_leapyear_file_path) 
        {
            this.File_path= file_path;
            this.Leap_year_file_path= leap_year_file_path;
            this.Non_leapyear_file_path = non_leapyear_file_path;
        }

        public string File_path { get => file_path; set => file_path = value; }
        public string Leap_year_file_path { get => leap_year_file_path; set => leap_year_file_path = value; }
        public string Non_leapyear_file_path { get => non_leapyear_file_path; set => non_leapyear_file_path = value; }

        public void read_file()
        {
            try
            {
                StreamReader sr = new StreamReader(this.File_path);
                string text = File.ReadAllText(this.File_path);
                Console.WriteLine(text);
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
        }


        public void write_to_leapyear()
        {
            using (StreamReader ReaderObject = new StreamReader(File_path))
            {
                string line;
                while ((line = ReaderObject.ReadLine()) != null)
                {
                    if (DateTime.IsLeapYear(Convert.ToInt32(line)))
                    {
                        //File.AppendAllLines(this.Leap_year_file_path, line);
                        using (StreamWriter leap_year = File.AppendText(this.Leap_year_file_path))
                        {
                            leap_year.WriteLine(line);
                        }
                    }
                }
            }
            Console.WriteLine("Done");
        }

        public void write_to_nonleapyear()
        {
            using (StreamReader ReaderObject1 = new StreamReader(File_path))
            {
                string line;
                while ((line = ReaderObject1.ReadLine()) != null)
                {

                    if (!(DateTime.IsLeapYear(Convert.ToInt32(line))))
                    {
                        using (StreamWriter non_leap_year = File.AppendText(this.Non_leapyear_file_path))
                        {
                            non_leap_year.WriteLine(line);
                        }
                    }
                }
            }
            Console.WriteLine("Done");
        }
    }
}
