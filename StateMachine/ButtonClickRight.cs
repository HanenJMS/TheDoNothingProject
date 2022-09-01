using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Do_Nothing_Project.StateMachine
{
    internal class ButtonClickRight : State
    {
        public override string OnClick()
        {
            return "Yea ok, but it still does nothing";
        }
    }
}
