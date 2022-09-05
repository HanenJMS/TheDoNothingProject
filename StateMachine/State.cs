using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.StateMachine
{
    internal abstract class State : IState
    {
        public abstract string OnClick();
    }
}
