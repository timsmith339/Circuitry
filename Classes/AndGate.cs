using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circuitry.Interfaces;

namespace Circuitry.Classes
{
    public class AndGate : IComponent
    {
        public delegate void StateSwitchedHandler(object sender, StateSwitchedEventArgs state);
        public event Node.StateSwitchedHandler StateSwitched;
        public ComponentState State { get; private set; }
        public Node HeadNode { get; private set; }

        public Node TailNode1 { get; private set; }
        public Node TailNode2 { get; private set; }

        public AndGate()
        {
            State = ComponentState.Off;
            StateSwitched += AndGate_StateSwitched;
            TailNode1 = new Node();
            TailNode2 = new Node();
            TailNode1.StateSwitched += TailNode_StateSwitched;
            TailNode2.StateSwitched += TailNode_StateSwitched;
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
            if (TailNode1.State == TailNode2.State &&
                TailNode2.State == ComponentState.On)
                return ComponentState.On;
            return ComponentState.Off;
        }

        public void SwitchStates()
        {
            State = State == ComponentState.Off ? ComponentState.On : ComponentState.Off;
            var handler = StateSwitched;
            if (handler != null)
                handler(this, new StateSwitchedEventArgs(State));
        }

        void AndGate_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            if (HeadNode != null)
                HeadNode.SwitchStates();
        }
    }
}
