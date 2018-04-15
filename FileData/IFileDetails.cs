using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public interface IFileDetails
    {
        string FileVersion(string filePath);

        int FileSize(string fileName);
    }
}
