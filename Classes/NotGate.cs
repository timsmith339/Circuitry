using Circuitry.Classes.Abstract;

namespace Circuitry.Classes
{
    public class NotGate : OneInputGate
    {
        public NotGate()
        {
            SetStateChangeEvalFunc(n => n.State == ComponentState.Off ? ComponentState.On : ComponentState.Off);
        }
    }
}
