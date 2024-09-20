using System;
using System.IO;

namespace _16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1_path = @"D:\Робочий стіл\Hillel\Homeworks\Hillel_HomeWorks\16.1\File 1.txt"; /*"File 1.txt*/
            string file2_path = @"D:\Робочий стіл\Hillel\Homeworks\Hillel_HomeWorks\16.1\File 2.txt"; /*"File 2.txt*/
            string content;
            using (StreamReader reader = new StreamReader(file1_path))
            {
                content = reader.ReadToEnd();
                //Console.WriteLine(content);
            }
            using (StreamWriter writer = new StreamWriter(file2_path))
            {
                writer.Write(content);  
            }
        }
    }
}
