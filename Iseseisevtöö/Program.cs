using System;
using System.IO;

namespace Iseseisevtöö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the fail that you want move to fruit:");
            string UserInput = Console.ReadLine();
            MoveToFruit(UserInput);
            Console.WriteLine("enter the fail that you want move to vegetables:");
            string UserInput2 = Console.ReadLine();
            MovetoVegetables(UserInput2);
        }
        public static void MoveToFruit(string fileName)
        {
            string roothPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fullFileName = $"{fileName}.txt";
            string fullFolderPath = Path.Combine(roothPath, fullFileName);
            File.Create(Path.Combine(roothPath, fullFileName));
            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The File already exists.");
            }
            else
            {
                File.Move(Path.Combine(roothPath, fullFileName), Path.Combine(destinationPath, fullFileName));
            }

        }

        public static void MovetoVegetables(string fileName)
        {
            string roothPath1 = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath1 = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fullFileName1 = $"{ fileName}.txt";
            string fullFolderPath1 = Path.Combine(roothPath1, fullFileName1);
            File.Create(Path.Combine(roothPath1, fullFileName1));
            if (Directory.Exists(fullFolderPath1))
            {
                Console.WriteLine("The File already exists.");
            }
            else
            {
                File.Move(Path.Combine(roothPath1, fullFileName1), Path.Combine(destinationPath1, fullFileName1));
            }
        }
    }
}
