using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Text;


namespace FileData
{
    public static class Program
    {
        private static string fileCommand, fileName;

        public static void Main(string[] args)
        {
            IFileDetails fileOps = new FileOperations();

            /*test code - uncomment following two lines of code for test           
                fileCommand = args[0];
                fileName = args[1];*/

            //comment out the following four lines if test code is uncommented 
            Console.WriteLine("Enter functionality command: ");
            fileCommand = Console.ReadLine();

            Console.WriteLine("\r\nEnter the file name or path: ");
            fileName = Console.ReadLine();

            ///<summary>
            ///following block of if-else statements decide which file operation to be performed
            ///based on input provided
            ///</summary>
            if (fileCommand == "-v" || fileCommand == "--v" || fileCommand == "/v" || fileCommand == "--version")
            {
                var fVersion = fileOps.FileVersion(fileCommand);
                Console.WriteLine("\r\nOutput\r\n------\r\n" + fileName + " > version of file: " + fVersion + "\r\n\nPress any key...");
            }
            else if (fileCommand == "-s" || fileCommand == "--s" || fileCommand == "/s" || fileCommand == "--size")
            {
                var fSize = fileOps.FileSize(fileCommand);
                Console.WriteLine("\r\nOutput\r\n------\r\n" + fileName + " > size of file: " + fSize + "\r\n\nPress any key...");
            }
            else
            {
                Console.WriteLine("\r\nOutput\r\n------\r\n'" + fileCommand + "' is an invalid command!\r\n\nPress any key...");
            }

            Console.ReadKey();            
        }        
    }   
}
