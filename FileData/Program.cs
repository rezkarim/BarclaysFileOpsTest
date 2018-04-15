using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Text;


namespace FileData
{
    public static class Program
    {
        private static string cmd, fileName;

        public static void Main(string[] args)
        {
            IFileDetails fileOps = new FileOperations();

            /*uncomment this block of code for test
             
            foreach (string arg in args)
            {
                cmd = arg;
            }*/

            //comment out the following two lines if previous block of code is uncommented 
            Console.WriteLine("Enter functionality command: ");
            cmd = Console.ReadLine();

            Console.WriteLine("\r\nEnter the file name or path: ");
            fileName = Console.ReadLine();

            if (cmd == "-v" || cmd == "--v" || cmd == "/v" || cmd == "--version")
            {
                var version = fileOps.FileVersion(cmd);
                Console.WriteLine("\r\n" + fileName + " - file version: " + version);
            }
            else if (cmd == "-s" || cmd == "--s" || cmd == "/s" || cmd == "--size")
            {
                var size = fileOps.FileSize(cmd);
                Console.WriteLine("\r\n" + fileName + " - file size: " + size);
            }
            else
            {
                Console.WriteLine("\r\n'" + cmd + "' is an invalid command!\r\n\nPress any key to quit...");
            }

            Console.ReadKey();            
        }        
    }   
}
