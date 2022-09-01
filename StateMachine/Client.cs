using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Do_Nothing_Project.StateMachine
{
    internal class Client
    {
        State currentState;
        public Client()
        {
            if(currentState == null)
            {
                SetState(new ButtonClickIdle());
            }
        }
        public void SetState(State state)
        {
            this.currentState = state;
            this.currentState.SetClient(this);
        }
        public void SetIdle()
        {
            SetState(new ButtonClickIdle());
        }
        public void SetRight()
        {
            SetState(new ButtonClickRight());
        }
        public void SetWrong()
        {
            SetState(new ButtonClickWrong());
        }
        public string OnHit()
        {
            return currentState.OnClick();
        }
    }
}
