using Circuitry.Interfaces;

namespace Circuitry.Classes
{
    public class Node : IComponent
    {
        public static int Counter = 0;
        public int Count;

        public delegate void StateSwitchedHandler(object sender, StateSwitchedEventArgs state);
        public event StateSwitchedHandler StateSwitched;
        public ComponentState State { get; private set; }
        public Node HeadNode { get; private set; }

        public Node()
        {
            Count = Counter++;
            State = ComponentState.Off;
            StateSwitched += Node_StateSwitched;
        }

        public void SetHeadNode(Node head)
        {
            HeadNode = head;
        }

        public void SwitchStates()
        {
            State = State == ComponentState.Off ? ComponentState.On : ComponentState.Off;
            var handler = StateSwitched;
            if (handler != null)
                handler(this, new StateSwitchedEventArgs(State));
        }

        private void Node_StateSwitched(object sender, StateSwitchedEventArgs e)
        {
            if (HeadNode != null)
                HeadNode.SwitchStates();
        }
    }
}
