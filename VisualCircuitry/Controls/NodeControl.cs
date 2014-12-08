using Circuitry.Classes;
using System;
using System.Windows.Forms;
using VisualCircuitry.Classes;

namespace VisualCircuitry.Controls
{
    public partial class NodeControl : UserControl
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

        public Node Node { get; private set; }

        public NodeControl()
        {
            InitializeComponent();

            Node = new Node();
            Node.StateSwitched += Node_StateSwitched;
        }

        public void SetHeadNode(Node headNode)
        {
            Node.SetHeadNode(headNode);
        }

        private void Node_StateSwitched(object sender, StateSwitchedEventArgs state)
        {
            nodeState.Text = state.State.ToString();
        }

        private void nodeState_Click(object sender, EventArgs e)
        {
            Node.SwitchStates();
        }

        private void nodeSelector_Click(object sender, EventArgs e)
        {
            if (Linker.SelectedNode != null)
                Linker.SelectedNode.SetHeadNode(Node);
        }

        private void headNode_Click(object sender, EventArgs e)
        {
            Linker.SetSelectedComponent(Node);
        }

    }
}
