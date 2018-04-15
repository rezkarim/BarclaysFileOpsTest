using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{

    public class FileOperations : IFileDetails
    {
        ThirdPartyTools.FileDetails fileDetails = new ThirdPartyTools.FileDetails();              

        public string FileVersion(string cmdVersion)
        {

            var result = fileDetails.Version(cmdVersion);
            return result;
        }

        public int FileSize(string cmdSize)
        {
            var result = fileDetails.Size(cmdSize);
            return result;
        }

    }

}

