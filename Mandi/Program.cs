using System;
using System.IO;

namespace Mandi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string rootPath = @"C:\Users\opilane\samples";
            GetDirectories(rootPath);
            GetFiles(rootPath);
        }

        public static void GetDirectories(string path)
        {
            string[] allDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string filepath = @"C:\Users\opilane\Monday\DirectoryData.txt";

            File.WriteAllLines(filepath, allDirectories);

        }

        public static void GetFiles(string path)
        {
            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string filepath = @"C:\Users\opilane\Monday\fileData.txt";
            File.WriteAllLines(filepath, allFiles);
        }
    }
}
