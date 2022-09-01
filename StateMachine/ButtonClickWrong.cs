using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
