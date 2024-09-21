using System;
using System.IO;
using System.Text;

namespace _16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path of the first file:");
            string file1_path = Console.ReadLine();//@"D:\Робочий стіл\Hillel\Homeworks\Hillel_HomeWorks\16.1\File 1.txt"; 
            Console.Write("Enter the path of the second file:");
            string file2_path = Console.ReadLine();//@"D:\Робочий стіл\Hillel\Homeworks\Hillel_HomeWorks\16.1\File 2.txt";
            string content;
            using (StreamReader reader = new StreamReader(file1_path, Encoding.UTF8))
            {
                content = reader.ReadToEnd();
                //Console.WriteLine(content);
            }
            using (StreamWriter writer = new StreamWriter(file2_path,false, Encoding.UTF8))
            {
                writer.Write(content);  
            }
            Console.WriteLine("File has been copied successfully.");
        }
    }
}
