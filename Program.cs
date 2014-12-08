using Circuitry.Classes;

namespace Circuitry
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node();

            var andGate1 = new AndGate();
            andGate1.SetHeadNode(node1);

            var andGate2 = new AndGate();
            andGate2.SetHeadNode(andGate1.TailNode1);

            var andGate3 = new AndGate();
            andGate3.SetHeadNode(andGate1.TailNode2);

            andGate2.TailNode1.SwitchStates();
            andGate3.TailNode1.SwitchStates();
            andGate2.TailNode2.SwitchStates();
            andGate3.TailNode2.SwitchStates();
        }
    }
    
    public enum ComponentState
    {
        Off = 0,
        On = 1
    }


}
