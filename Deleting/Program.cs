using System;
using System.IO;

namespace Deleting
{
    class Program
    {
        static void Main(string[] args)
        {
            string roothPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            DeleteAllfilesinFruit();
            DeleteAllfilesinVegetables();
        }

        public static void DeleteAllfilesinFruit()
        {
            string roothPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";
             if (File.Exists(Path.Combine(roothPath, fileName)))
             {
                File.Delete(Path.Combine(roothPath, fileName));
                Console.WriteLine("file deleted.");
            }else
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void DeleteAllfilesinVegetables()
        {
            string roothPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName = "cheese.txt";
            if (File.Exists(Path.Combine(roothPath, fileName)))
            {
                File.Delete(Path.Combine(roothPath, fileName));
                Console.WriteLine("file deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
