using Circuitry.Classes;
using System;
using System.Windows.Forms;
using VisualCircuitry.Classes;

namespace VisualCircuitry.Controls
{
    public partial class NotGateControl : UserControl
    {
        private NodeLinker _linker;
        private NodeLinker Linker
        {
            get
            {
                if (_linker == null)
                    _linker = NodeLinker.GetInstance();
                return _linker;
            }
        }  

        public NotGate NotGate { get; private set; }

        public NotGateControl()
        {
            InitializeComponent();

            notGateState.Text = "On";
            NotGate = new NotGate();
            NotGate.StateSwitched += NotGate_StateSwitched;
        }

        public void SetHeadNode(Node headNode)
        {
            NotGate.SetHeadNode(headNode);
        }

        private void NotGate_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            notGateState.Text = state.State.ToString();
        }

        private void headNode_Click(object sender, EventArgs e)
        {
            Linker.SetSelectedComponent(NotGate);
        }

        private void tailodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(NotGate.TailNode);
        }
    }
}
