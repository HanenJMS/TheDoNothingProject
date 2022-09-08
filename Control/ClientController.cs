using The_Do_Nothing_Project.Buttons;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Control
{
    internal abstract class ClientController
    {
        public ICommand currentState, idle, right, wrong, directoryHandler, fileHandler;
        public IDirectoryFileButton directoryButtons;
        public IFileHandler fileButtons;
        public ClientController()
        {
            idle = new ButtonClickIdle();
            right = new ButtonClickRight();
            wrong = new ButtonClickWrong();
            directoryHandler = new DirectoryButton();
            fileHandler = new FileButton();
            if (currentState == null)
            {
                SetState(idle);
            }
        }
        public void SetState(ICommand state)
        {
            this.currentState = state;
            if(state is DirectoryButton || state is FileButton)
            {
                directoryButtons = (IDirectoryFileButton)state;
            }
            if(state is FileButton)
            {
                fileButtons = (IFileHandler)state;
            }
        }
        public void SetIdle()
        {
            //SetState(new ButtonClickIdle());
            SetState(idle);
        }
        public void SetRight()
        {
            //SetState(new ButtonClickRight());
            SetState(right);
        }
        public void SetWrong()
        {
            //SetState(new ButtonClickWrong());
            SetState(wrong);
        }
        public void SetDirectoryManager()
        {
            SetState(directoryHandler);
        }
        public void SetFileManager()
        {
            SetState(fileHandler);
        }
        public string OnClick()
        {
            return currentState.OnClick();
        }
        public void CreateDirectory(string path)
        {
            directoryButtons.Create(path);
        }
        public void DeleteDirectory(string path)
        {
            directoryButtons.Delete(path);
        }
        public void MoveDirectory(string directory, string destination)
        {
            directoryButtons.Move(directory, destination);
        }
        public void WriteToFile(string path, string content)
        {
            fileButtons.Write(path, content);
        }
        public string ReadFromFile(string path)
        {
            return fileButtons.Read(path);
        }
        public void CopyFileTo(string path, string destination)
        {
            fileButtons.Copy(path, destination);
        }
    }
}
