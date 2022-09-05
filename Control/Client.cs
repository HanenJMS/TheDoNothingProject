using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Control
{
    internal class Client
    {
        IState currentState, idle, right, wrong;
        public Client()
        {
            if (currentState == null)
            {
                SetState(idle);
            }
        }
        public void SetState(IState state)
        {
            this.currentState = state;
            //this.currentState.SetClient(this); statemachine artifact
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
        public string OnClick()
        {
            return currentState.OnClick();
        }
    }
}
