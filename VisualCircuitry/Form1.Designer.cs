namespace VisualCircuitry
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nodeControl7 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl6 = new VisualCircuitry.Controls.NodeControl();
            this.andGateControl2 = new VisualCircuitry.Controls.AndGateControl();
            this.nodeControl5 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl4 = new VisualCircuitry.Controls.NodeControl();
            this.andGateControl1 = new VisualCircuitry.Controls.AndGateControl();
            this.nodeControl3 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl2 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl1 = new VisualCircuitry.Controls.NodeControl();
            this.SuspendLayout();
            // 
            // nodeControl7
            // 
            this.nodeControl7.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl7.Location = new System.Drawing.Point(531, 166);
            this.nodeControl7.Name = "nodeControl7";
            this.nodeControl7.Size = new System.Drawing.Size(111, 32);
            this.nodeControl7.TabIndex = 8;
            // 
            // nodeControl6
            // 
            this.nodeControl6.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl6.Location = new System.Drawing.Point(531, 128);
            this.nodeControl6.Name = "nodeControl6";
            this.nodeControl6.Size = new System.Drawing.Size(111, 32);
            this.nodeControl6.TabIndex = 7;
            // 
            // andGateControl2
            // 
            this.andGateControl2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.andGateControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andGateControl2.Location = new System.Drawing.Point(413, 139);
            this.andGateControl2.Name = "andGateControl2";
            this.andGateControl2.Size = new System.Drawing.Size(112, 43);
            this.andGateControl2.TabIndex = 6;
            // 
            // nodeControl5
            // 
            this.nodeControl5.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl5.Location = new System.Drawing.Point(25, 71);
            this.nodeControl5.Name = "nodeControl5";
            this.nodeControl5.Size = new System.Drawing.Size(111, 32);
            this.nodeControl5.TabIndex = 5;
            // 
            // nodeControl4
            // 
            this.nodeControl4.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl4.Location = new System.Drawing.Point(296, 119);
            this.nodeControl4.Name = "nodeControl4";
            this.nodeControl4.Size = new System.Drawing.Size(111, 32);
            this.nodeControl4.TabIndex = 4;
            // 
            // andGateControl1
            // 
            this.andGateControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.andGateControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andGateControl1.Location = new System.Drawing.Point(162, 64);
            this.andGateControl1.Name = "andGateControl1";
            this.andGateControl1.Size = new System.Drawing.Size(112, 43);
            this.andGateControl1.TabIndex = 3;
            // 
            // nodeControl3
            // 
            this.nodeControl3.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl3.Location = new System.Drawing.Point(530, 35);
            this.nodeControl3.Name = "nodeControl3";
            this.nodeControl3.Size = new System.Drawing.Size(111, 32);
            this.nodeControl3.TabIndex = 2;
            // 
            // nodeControl2
            // 
            this.nodeControl2.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl2.Location = new System.Drawing.Point(413, 35);
            this.nodeControl2.Name = "nodeControl2";
            this.nodeControl2.Size = new System.Drawing.Size(111, 32);
            this.nodeControl2.TabIndex = 1;
            // 
            // nodeControl1
            // 
            this.nodeControl1.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl1.Location = new System.Drawing.Point(296, 35);
            this.nodeControl1.Name = "nodeControl1";
            this.nodeControl1.Size = new System.Drawing.Size(111, 32);
            this.nodeControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 252);
            this.Controls.Add(this.nodeControl7);
            this.Controls.Add(this.nodeControl6);
            this.Controls.Add(this.andGateControl2);
            this.Controls.Add(this.nodeControl5);
            this.Controls.Add(this.nodeControl4);
            this.Controls.Add(this.andGateControl1);
            this.Controls.Add(this.nodeControl3);
            this.Controls.Add(this.nodeControl2);
            this.Controls.Add(this.nodeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NodeControl nodeControl1;
        private Controls.NodeControl nodeControl2;
        private Controls.NodeControl nodeControl3;
        private Controls.AndGateControl andGateControl1;
        private Controls.NodeControl nodeControl4;
        private Controls.NodeControl nodeControl5;
        private Controls.AndGateControl andGateControl2;
        private Controls.NodeControl nodeControl6;
        private Controls.NodeControl nodeControl7;
    }
}

