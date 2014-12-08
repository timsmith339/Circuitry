namespace VisualCircuitry.Controls
{
    partial class AndGateControl
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
            this.rightNodeSelector = new System.Windows.Forms.Label();
            this.andGateState = new System.Windows.Forms.Label();
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
            // rightNodeSelector
            // 
            this.rightNodeSelector.AutoSize = true;
            this.rightNodeSelector.BackColor = System.Drawing.Color.White;
            this.rightNodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightNodeSelector.Location = new System.Drawing.Point(97, 4);
            this.rightNodeSelector.Name = "rightNodeSelector";
            this.rightNodeSelector.Size = new System.Drawing.Size(12, 15);
            this.rightNodeSelector.TabIndex = 4;
            this.rightNodeSelector.Text = " ";
            this.rightNodeSelector.Click += new System.EventHandler(this.rightNodeSelector_Click);
            // 
            // andGateState
            // 
            this.andGateState.AutoSize = true;
            this.andGateState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andGateState.Location = new System.Drawing.Point(44, 4);
            this.andGateState.Name = "andGateState";
            this.andGateState.Size = new System.Drawing.Size(23, 15);
            this.andGateState.TabIndex = 3;
            this.andGateState.Text = "Off";
            // 
            // leftNodeSelector
            // 
            this.leftNodeSelector.AutoSize = true;
            this.leftNodeSelector.BackColor = System.Drawing.Color.White;
            this.leftNodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftNodeSelector.Location = new System.Drawing.Point(97, 25);
            this.leftNodeSelector.Name = "leftNodeSelector";
            this.leftNodeSelector.Size = new System.Drawing.Size(12, 15);
            this.leftNodeSelector.TabIndex = 6;
            this.leftNodeSelector.Text = " ";
            this.leftNodeSelector.Click += new System.EventHandler(this.leftNodeSelector_Click);
            // 
            // AndGateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.leftNodeSelector);
            this.Controls.Add(this.headNode);
            this.Controls.Add(this.rightNodeSelector);
            this.Controls.Add(this.andGateState);
            this.Name = "AndGateControl";
            this.Size = new System.Drawing.Size(112, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headNode;
        private System.Windows.Forms.Label rightNodeSelector;
        private System.Windows.Forms.Label andGateState;
        private System.Windows.Forms.Label leftNodeSelector;
    }
}
