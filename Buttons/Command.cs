using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Buttons
{
    internal abstract class Command : ICommand
    {
        IClient client;
        public abstract string OnClick();
        public abstract void OnSpecialClick(string path);

        public void SetClient(IClient client)
        {
            this.client = client;
            SetState(this);
        }
        public void SetState(ICommand state)
        {
            client.SetState(state);
        }
    }
}
