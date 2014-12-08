using Circuitry.Classes;
using System;
using System.Windows.Forms;
using VisualCircuitry.Classes;

namespace VisualCircuitry.Controls
{
    public partial class AndGateControl : UserControl
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

        public AndGate AndGate { get; private set; }

        public AndGateControl()
        {
            InitializeComponent();

            AndGate = new AndGate();
            AndGate.StateSwitched += AndGate_StateSwitched;
        }

        public void SetHeadNode(Node headNode)
        {
            AndGate.SetHeadNode(headNode);
        }

        private void AndGate_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            andGateState.Text = state.State.ToString();
        }

        private void headNode_Click(object sender, EventArgs e)
        {
            Linker.SetSelectedComponent(AndGate);
        }

        private void leftNodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(AndGate.TailNode1);
        }

        private void rightNodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(AndGate.TailNode2);
        }
    }
}
