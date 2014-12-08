using System;

namespace Circuitry.Classes
{
    public class StateSwitchedEventArgs : EventArgs
    {
        public ComponentState State { get; private set; }
        public StateSwitchedEventArgs(ComponentState state)
        {
            State = state;
        }
    }
}
