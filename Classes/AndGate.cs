using Circuitry.Classes.Abstract;

namespace Circuitry.Classes
{
    public class AndGate : TwoInputGate
    {
        public AndGate()
        {
            SetStateChangeEvalFunc((n1, n2) => (n1.State == n2.State &&
                                                n1.State == ComponentState.On)
                ? ComponentState.On
                : ComponentState.Off);
        }
    }
}
