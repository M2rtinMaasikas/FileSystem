using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name:");
            string userFolder = Console.ReadLine();

            string NewDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExist = Directory.Exists(NewDirectoryFullPath);
            if (directoryExist)
            {
                Console.WriteLine($"{userFolder} exist");
                Console.WriteLine("Would you like to crate a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if(userInput == 'y')
                {
                    Console.WriteLine("Enter the file name:");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullpath = $@"{NewDirectoryFullPath}\{userFile}";
                       
                }

            } else
            
            {
                Directory.CreateDirectory(NewDirectoryFullPath);
            }

            Directory.CreateDirectory(NewDirectoryFullPath);
            Console.WriteLine($"Directory {userFolder} has been created.");
        }
    }
}
