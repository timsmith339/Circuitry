using Circuitry.Classes;

namespace Circuitry
{
    class Program
    {
        static void Main(string[] args)
        {
            var notGate = new NotGate();
            var node1 = new Node();

            notGate.RegisterListener(node1);

            var andGate1 = new OrGate();
            var node3 = new Node();
            var node4 = new Node();

            node1.RegisterListener(andGate1);

            node3.SwitchStates();
            node4.SwitchStates();

            andGate1.RegisterListener1(node3);
            andGate1.RegisterListener2(node4);

            node3.SwitchStates();
            node4.SwitchStates();
            node4.SwitchStates();
            node3.SwitchStates();
        }
    }
}
