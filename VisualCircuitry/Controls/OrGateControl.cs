using Circuitry.Classes;
using System;
using System.Windows.Forms;
using VisualCircuitry.Classes;

namespace VisualCircuitry.Controls
{
    public partial class OrGateControl : UserControl
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

        public OrGate OrGate { get; private set; }

        public OrGateControl()
        {
            InitializeComponent();

            OrGate = new OrGate();
            OrGate.StateSwitched += OrGate_StateSwitched;
        }

        public void SetHeadNode(Node headNode)
        {
            OrGate.SetHeadNode(headNode);
        }

        private void OrGate_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            orGateState.Text = state.State.ToString();
        }

        private void headNode_Click(object sender, EventArgs e)
        {
            Linker.SetSelectedNode(OrGate);
        }

        private void leftNodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(OrGate.TailNode1);
        }

        private void rightNodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(OrGate.TailNode2);
        }
    }
}
