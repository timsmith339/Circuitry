namespace VisualCircuitry.Controls
{
    partial class NodeControl
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
            this.nodeState = new System.Windows.Forms.Label();
            this.nodeSelector = new System.Windows.Forms.Label();
            this.headNode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nodeState
            // 
            this.nodeState.AutoSize = true;
            this.nodeState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeState.Location = new System.Drawing.Point(43, 2);
            this.nodeState.Name = "nodeState";
            this.nodeState.Size = new System.Drawing.Size(23, 15);
            this.nodeState.TabIndex = 0;
            this.nodeState.Text = "Off";
            this.nodeState.Click += new System.EventHandler(this.nodeState_Click);
            // 
            // nodeSelector
            // 
            this.nodeSelector.AutoSize = true;
            this.nodeSelector.BackColor = System.Drawing.Color.White;
            this.nodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeSelector.Location = new System.Drawing.Point(96, 14);
            this.nodeSelector.Name = "nodeSelector";
            this.nodeSelector.Size = new System.Drawing.Size(12, 15);
            this.nodeSelector.TabIndex = 1;
            this.nodeSelector.Text = " ";
            this.nodeSelector.Click += new System.EventHandler(this.nodeSelector_Click);
            // 
            // headNode
            // 
            this.headNode.AutoSize = true;
            this.headNode.BackColor = System.Drawing.Color.White;
            this.headNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headNode.Location = new System.Drawing.Point(3, 14);
            this.headNode.Name = "headNode";
            this.headNode.Size = new System.Drawing.Size(12, 15);
            this.headNode.TabIndex = 2;
            this.headNode.Text = " ";
            this.headNode.Click += new System.EventHandler(this.headNode_Click);
            // 
            // NodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.headNode);
            this.Controls.Add(this.nodeSelector);
            this.Controls.Add(this.nodeState);
            this.Name = "NodeControl";
            this.Size = new System.Drawing.Size(111, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nodeState;
        private System.Windows.Forms.Label nodeSelector;
        private System.Windows.Forms.Label headNode;
    }
}
