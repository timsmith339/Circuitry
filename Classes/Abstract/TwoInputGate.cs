using System;
using Circuitry.Interfaces;

namespace Circuitry.Classes.Abstract
{
    public abstract class TwoInputGate : IComponent
    {
        public event StateSwitchedHandler StateSwitched;
        public ComponentState State { get; private set; }
        private Func<IComponent, IComponent, ComponentState> StateChangeEvaluationFunc { get; set; }
        private IComponent InputComponentA { get; set; }
        private IComponent InputComponentB { get; set; }

        protected TwoInputGate()
        {
            State = ComponentState.Off;
        }

        public void RegisterListener1(IComponent node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            InputComponentA = node;
            node.StateSwitched += (o, e) => EvaluateState();
            if (InputComponentB != null)
                EvaluateState();
        }

        public void RegisterListener2(IComponent node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            InputComponentB = node;
            node.StateSwitched += (o, e) => EvaluateState();
            if (InputComponentA != null )
                EvaluateState();
        }

        public void SetStateChangeEvalFunc(Func<IComponent, IComponent, ComponentState> func)
        {
            if (func == null)
                throw new ArgumentNullException("func");

            StateChangeEvaluationFunc = func;
        }

        protected void EvaluateState()
        {
            if (StateChangeEvaluationFunc == null)
                throw new StateChangeEvaluationNotDefined();

            if (InputComponentA == null)
                throw new InputComponentsNotDefined("InputComponentA is not defined.");
            if (InputComponentB == null)
                throw new InputComponentsNotDefined("InputComponentB is not defined.");

            if (State != StateChangeEvaluationFunc(InputComponentA, InputComponentB))
                SwitchStates();
        }

        protected void SwitchStates()
        {
            State = State == ComponentState.Off ? ComponentState.On : ComponentState.Off;
            var handler = StateSwitched;
            if (handler != null)
                handler(this, new StateSwitchedEventArgs(State));
        }
    }
}
