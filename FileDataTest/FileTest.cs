using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDataTest
{
    [TestClass]
    public class FileTest
    {
        
        [TestMethod]
        public void testVersion()
        {
            Random _random = new Random();

            string cmd = "-v";

            FileData.FileOperations fileOps = new FileData.FileOperations();            

            var outCmd = fileOps.FileVersion(cmd);

            var random = string.Format("{0}.{1}.{2}", _random.Next(5), _random.Next(8), _random.Next(22));

            Assert.AreEqual<string>(random, outCmd);                      
        }

        [TestMethod]
        public void testSize()
        {
            Random _random = new Random();

            string cmd = "-s";

            FileData.FileOperations fileOps = new FileData.FileOperations();

            var outCmd = fileOps.FileSize(cmd);

            var random = _random.Next(100000) + 100000;

            Assert.AreEqual<int>(random, outCmd);
        }
    }
}
