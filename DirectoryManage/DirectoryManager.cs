using System.IO;
using System.Windows.Forms;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.FileHandler
{
    internal class DirectoryManager : IDirectoryFileButton
    {
        public void Create(string path)
        {

            DirectoryInfo dr = new DirectoryInfo(path);
            if(dr.Exists)
            {
                MessageBox.Show("Directory already exists.");
            }
            else
            {
                dr.Create();
                MessageBox.Show("File has been created");
            }
        }

        public void Delete(string path)
        {
            DirectoryInfo dr = new DirectoryInfo(path);
            if(!dr.Exists)
            {
                MessageBox.Show("Directory does not exist");
            }
            else
            {
                dr.Delete();
                MessageBox.Show("Directory Successfully deleted.");
            }
        }

        public void Move(string path, string dest)
        {
            DirectoryInfo dr = new DirectoryInfo(path);
            if(dr.Exists)
            {
                dr.MoveTo(dest);
                MessageBox.Show("Directory Successfully Moved.");
            }
            else
            {
                MessageBox.Show("Directory does not exist");
            }
        }
    }
}
