namespace The_Do_Nothing_Project.StateMachine
{
    internal class ButtonClickWrong : State
    {
        public override string OnClick()
        {
            return "Why? I told you it does nothing...";
        }
    }
}
