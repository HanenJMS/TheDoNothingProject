using The_Do_Nothing_Project.Buttons;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Control
{
    internal abstract class ClientController
    {
        public ICommand currentState, idle, right, wrong, directoryHandler;
        public IDirectoryButtons directoryButtons;
        public ClientController()
        {
            idle = new ButtonClickIdle();
            right = new ButtonClickRight();
            wrong = new ButtonClickWrong();
            directoryHandler = new DirectoryButton();
            if (currentState == null)
            {
                SetState(idle);
            }
        }
        public void SetState(ICommand state)
        {
            this.currentState = state;
            if(state is DirectoryButton)
            {
                directoryButtons = (IDirectoryButtons)state;
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
    }
}
