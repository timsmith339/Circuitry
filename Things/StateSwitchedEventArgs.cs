using System;

namespace Circuitry.Classes
{
    public delegate void StateSwitchedHandler(object sender, StateSwitchedEventArgs state);

    public class StateSwitchedEventArgs : EventArgs
    {
        public ComponentState State { get; private set; }
        public StateSwitchedEventArgs(ComponentState state)
        {
            State = state;
        }
    }
}
