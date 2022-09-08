using System;
using System.IO;
using System.Windows.Forms;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.DirectoryManage
{
    internal class FileManager : IDirectoryFileButton, IFileHandler
    {
        public void Copy(string path, string destination)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(destination);
                MessageBox.Show("File successfully Copied");
            }
            else
            {
                MessageBox.Show("File can not be copied. Either it doesn't exist, or file is hidden from privilege.");
            }
        }

        public void Create(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if(!fileInfo.Exists)
            {
                fileInfo.Create();
                MessageBox.Show("File successfully created");
            }
            else
            {
                MessageBox.Show("File already exists.");
            }
        }

        public void Delete(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                MessageBox.Show("File successfully Deleted");
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }
        }

        public void Move(string path, string destination)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.MoveTo(destination);
                MessageBox.Show("File successfully moved");
            }
            else
            {
                MessageBox.Show("File can not be moved. Either it doesn't exist, or file is hidden from privilege.");
            }
        }

        public string Read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while(!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            return text;
        }

        public void Write(string path, string content)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(content);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
