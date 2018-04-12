using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Text;


namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string functionality, sizeOfFile;

            FileDetails fileDetails = new FileDetails();

            Console.WriteLine("Enter the functionaly command to be performed: ");
            functionality = Console.ReadLine();
            Console.WriteLine("Enter the file name/path: ");
            sizeOfFile = Console.ReadLine();

            if (functionality == "-v" || functionality == "--v" || functionality == "/v" || functionality == "version")
            {
                var versionOfFile = fileDetails.Version("C:\test.txt");
                Console.WriteLine("The current version of your file is: " + versionOfFile);
            }
            else if (functionality == "-s" || functionality == "--s" || functionality == "/s" || functionality == "size")
            {
                var fileSize = fileDetails.Size("C:\test.txt");
                Console.WriteLine("Size of your file is: " + fileSize);
            }

            Console.ReadKey();
        }
    }
}
