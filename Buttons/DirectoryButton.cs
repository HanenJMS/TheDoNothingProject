using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Do_Nothing_Project.FileHandler;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Buttons
{
    internal class DirectoryButton : Command, IDirectoryFileButton
    {
        DirectoryManager fm = new DirectoryManager();

        public void Create(string path)
        {
            fm.Create(path);
        }

        public void Delete(string path)
        {
            fm.Delete(path);
        }

        public void Move(string path, string destination)
        {
            fm.Move(path, destination);
        }

        public override string OnClick()
        {
            return "";
        }
    }
}
