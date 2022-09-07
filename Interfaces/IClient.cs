using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Do_Nothing_Project.Interfaces
{
    internal interface IClient
    {
        //TODO: Renaming class to better classify it's purpose.
        //TODO: Connect Client to other sources without Creating extra dependencies.
        void SetState(ICommand state);
    }
}
