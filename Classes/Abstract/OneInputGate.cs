using System;
using Circuitry.Interfaces;

namespace Circuitry.Classes.Abstract
{
    public abstract class OneInputGate : IComponent
    {
        public event StateSwitchedHandler StateSwitched;
        public ComponentState State { get; private set; }
        private Func<IComponent, ComponentState> StateChangeEvaluationFunc { get; set; }
        private IComponent InputComponent { get; set; }

        protected OneInputGate()
        {
            State = ComponentState.Off;
        }

        public void SetStateChangeEvalFunc(Func<IComponent, ComponentState> func)
        {
            if (func == null)
                throw new ArgumentNullException("func");

            StateChangeEvaluationFunc = func;
        }

        public void RegisterListener(IComponent node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            InputComponent = node;
            node.StateSwitched += (o, e) => SwitchStates();
            EvaluateState();
        }

        protected void EvaluateState()
        {
            if (StateChangeEvaluationFunc == null)
                throw new StateChangeEvaluationNotDefined();

            if (InputComponent == null)
                throw new InputComponentsNotDefined("InputComponent is not defined.");

            if (State != StateChangeEvaluationFunc(InputComponent))
                SwitchStates();
        }

        public void SwitchStates()
        {
            State = State == ComponentState.Off ? ComponentState.On : ComponentState.Off;
            if (StateSwitched != null)
                StateSwitched(this, new StateSwitchedEventArgs(State));
        }
    }
}
