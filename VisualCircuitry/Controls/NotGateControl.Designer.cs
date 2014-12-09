namespace VisualCircuitry.Controls
{
    partial class NotGateControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headNode = new System.Windows.Forms.Label();
            this.notGateState = new System.Windows.Forms.Label();
            this.leftNodeSelector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headNode
            // 
            this.headNode.AutoSize = true;
            this.headNode.BackColor = System.Drawing.Color.White;
            this.headNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headNode.Location = new System.Drawing.Point(4, 16);
            this.headNode.Name = "headNode";
            this.headNode.Size = new System.Drawing.Size(12, 15);
            this.headNode.TabIndex = 5;
            this.headNode.Text = " ";
            this.headNode.Click += new System.EventHandler(this.headNode_Click);
            // 
            // notGateState
            // 
            this.notGateState.AutoSize = true;
            this.notGateState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notGateState.Location = new System.Drawing.Point(44, 4);
            this.notGateState.Name = "notGateState";
            this.notGateState.Size = new System.Drawing.Size(23, 15);
            this.notGateState.TabIndex = 3;
            this.notGateState.Text = "Off";
            // 
            // leftNodeSelector
            // 
            this.leftNodeSelector.AutoSize = true;
            this.leftNodeSelector.BackColor = System.Drawing.Color.White;
            this.leftNodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftNodeSelector.Location = new System.Drawing.Point(97, 16);
            this.leftNodeSelector.Name = "leftNodeSelector";
            this.leftNodeSelector.Size = new System.Drawing.Size(12, 15);
            this.leftNodeSelector.TabIndex = 6;
            this.leftNodeSelector.Text = " ";
            this.leftNodeSelector.Click += new System.EventHandler(this.tailodeSelector_Click);
            // 
            // NotGateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.leftNodeSelector);
            this.Controls.Add(this.headNode);
            this.Controls.Add(this.notGateState);
            this.Name = "NotGateControl";
            this.Size = new System.Drawing.Size(112, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headNode;
        private System.Windows.Forms.Label notGateState;
        private System.Windows.Forms.Label leftNodeSelector;
    }
}
