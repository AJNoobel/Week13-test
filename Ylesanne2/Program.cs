using System;
using System.IO;
namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootDirectory = @"C:\Users\opilane\Samples";

            Console.WriteLine("Enter a folder name");
            string userFolder = Console.ReadLine();
         
            bool Exists = File.Exists($@"{rootDirectory}\\{userFolder}\\stars.txt");
            bool Exists2 = File.Exists($@"{rootDirectory}\\{userFolder}\\planets.txt");
            if (Exists && Exists2)
            {
                Console.WriteLine($"stars.txt and planets.txt already exists!");
            }

            else
            {
                File.Create(@$"{rootDirectory}\\{userFolder}\\stars.txt");
                File.Create(@$"{rootDirectory}\\{userFolder}\\planets.txt");
                string userFileFullPath = $@"stars.txt and planets.txt has been created!";

            }

        }
    }
}
