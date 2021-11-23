using System;
using System.IO;
namespace week13_testfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";

            Console.WriteLine("Enter Directory Name:");
            string userFolder = Console.ReadLine();
            string newDirectoryFullPath = $"{rootDirectory}\\{userFolder}";

            bool DirectoryExists = Directory.Exists(newDirectoryFullPath);
            if (DirectoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
            }

            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"directory {userFolder} has been created.");
                string userFileFullPath = $@"{newDirectoryFullPath}";
               
            }
        }
     }
}
