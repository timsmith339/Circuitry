using Circuitry.Classes.Abstract;

namespace Circuitry.Classes
{
    public class Node : OneInputGate
    {
        public Node()
        {
            SetStateChangeEvalFunc(n => n.State);
        }
    }
}
