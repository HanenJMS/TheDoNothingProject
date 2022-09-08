using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Do_Nothing_Project.Interfaces
{
    internal interface IFileHandler
    {
        void Write(string path, string content);
        string Read(string path);
        void Copy(string path, string destination);
    }
}
