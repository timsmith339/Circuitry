using Circuitry.Classes.Abstract;

namespace Circuitry.Classes
{
    public class OrGate : TwoInputGate
    {
        public OrGate()
        {
            SetStateChangeEvalFunc((n1, n2) => (n1.State == ComponentState.On ||
                                                n2.State == ComponentState.On)
                ? ComponentState.On
                : ComponentState.Off);
        }
    }
}

