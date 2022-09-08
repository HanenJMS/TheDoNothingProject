using The_Do_Nothing_Project.Interfaces;

namespace The_Do_Nothing_Project.Buttons
{
    internal abstract class Command : ICommand
    {
        public abstract string OnClick();
    }
}
