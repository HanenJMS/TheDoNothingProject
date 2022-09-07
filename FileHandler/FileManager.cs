using System.IO;
using System.Windows.Forms;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.FileHandler
{
    internal class FileManager : IFileManager
    {
        public void Create(string path)
        {
            DirectoryInfo dr = new DirectoryInfo(path);
            if (!dr.Exists)
            {
                dr.Create();
                MessageBox.Show("New File was Created");
            }
            else if (dr.Exists)
            {
                MessageBox.Show($"{dr.CreationTime}");
            }
            else
            {
                MessageBox.Show("There was an error. Were you trying to create a directory/folder? FileManager.cs line 23");
            }
        }

        public void Delete(string path)
        {
            throw new System.NotImplementedException();
        }

        public void Move(string path, string dest)
        {
            throw new System.NotImplementedException();
        }
    }
}
