namespace The_Do_Nothing_Project.StateMachine
{
    internal class ButtonClickIdle : State
    {
        public override string OnClick()
        {
            return "Now I'm idle. But let me tell you a story about the time that I pushed a button when I shouldn't have.";
        }
    }
}
