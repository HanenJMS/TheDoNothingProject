using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Do_Nothing_Project.StateMachine
{
    internal abstract class State
    {
        Client client;
        public void SetClient(Client client)
        {
            this.client = client;
        }
        public abstract string OnClick();
    }
}
