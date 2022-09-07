using The_Do_Nothing_Project.Buttons;
using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Control
{
    internal abstract class ClientController : IFileManager
    {
        public ICommand currentState, idle, right, wrong, FileHandle;
        public ClientController()
        {
            idle = new ButtonClickIdle();
            right = new ButtonClickRight();
            wrong = new ButtonClickWrong();
            FileHandle = new FileHandle();
            if (currentState == null)
            {
                SetState(idle);
            }
        }
        public void SetState(ICommand state)
        {
            this.currentState = state;
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
        public void SetFileHandle()
        {
            SetState(FileHandle);
        }
        public string OnClick()
        {
            return currentState.OnClick();
        }

        public void Create(string path)
        {
            FileHandle.OnSpecialClick(path);
        }

        public void Delete(string path)
        {
            FileHandle.OnSpecialClick(path);
        }

        public void Move(string path, string destination)
        {
            FileHandle.OnSpecialClick(path);
        }
    }
}
