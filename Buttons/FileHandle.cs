using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Do_Nothing_Project.FileHandler;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Buttons
{
    internal class FileHandle : Command
    {
        FileManager fm = new FileManager();
        public override string OnClick()
        {
            return "";
        }

        public override void OnSpecialClick(string path)
        {
            
        }
    }
}
