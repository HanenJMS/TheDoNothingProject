using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Do_Nothing_Project.DirectoryManage;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Buttons
{
    internal class FileButton : Command, IDirectoryFileButton, IFileHandler
    {
        FileManager fs = new FileManager();

        public void Copy(string path, string destination)
        {
            fs.Copy(path, destination);
        }

        public void Create(string path)
        {
            fs.Create(path);
        }

        public void Delete(string path)
        {
            fs.Delete(path);
        }

        public void Move(string path, string destination)
        {
            fs.Move(path, destination);
        }

        public override string OnClick()
        {
            return "";
        }

        public string Read(string path)
        {
            return fs.Read(path);
        }

        public void Write(string path, string content)
        {
            fs.Write(path, content);
        }
    }
}
