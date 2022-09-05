namespace The_Do_Nothing_Project.StateMachine
{
    internal class Client
    {
        State currentState, idle, right, wrong;
        public Client()
        {
            //caching for memory management. Added after statemachine converted into strategy pattern
            idle = new ButtonClickIdle();
            right = new ButtonClickRight();
            wrong = new ButtonClickWrong();
            if (currentState == null)
            {
                SetState(idle);
            }
        }
        public void SetState(State state)
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
