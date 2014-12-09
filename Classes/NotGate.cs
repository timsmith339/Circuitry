using Circuitry.Interfaces;

namespace Circuitry.Classes
{
    public class NotGate : IComponent
    {
        public delegate void StateSwitchedHandler(object sender, StateSwitchedEventArgs state);
        public event Node.StateSwitchedHandler StateSwitched;
        public ComponentState State { get; private set; }
        public Node HeadNode { get; private set; }
        public Node TailNode { get; private set; }

        public NotGate()
        {
            State = ComponentState.On;
            StateSwitched += NotGate_StateSwitched;
            TailNode = new Node();
            TailNode.StateSwitched += TailNode_StateSwitched;
        }

        public void SetHeadNode(Node headNode)
        {
            HeadNode = headNode;
        }

        void TailNode_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            if (State != EvaluateState())
                SwitchStates();
        }

        public ComponentState EvaluateState()
        {
            if (TailNode.State == ComponentState.On)
                return ComponentState.Off;
            return ComponentState.On;
        }

        public void SwitchStates()
        {
            State = State == ComponentState.Off ? ComponentState.On : ComponentState.Off;
            var handler = StateSwitched;
            if (handler != null)
                handler(this, new StateSwitchedEventArgs(State));
        }

        void NotGate_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            if (HeadNode != null)
                HeadNode.SwitchStates();
        }
    }
}
