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
            this.nodeControl5 = new VisualCircuitry.Controls.NodeControl();
            this.notGateControl3 = new VisualCircuitry.Controls.NotGateControl();
            this.notGateControl2 = new VisualCircuitry.Controls.NotGateControl();
            this.notGateControl1 = new VisualCircuitry.Controls.NotGateControl();
            this.nodeControl3 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl4 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl2 = new VisualCircuitry.Controls.NodeControl();
            this.nodeControl1 = new VisualCircuitry.Controls.NodeControl();
            this.andGateControl1 = new VisualCircuitry.Controls.AndGateControl();
            this.SuspendLayout();
            // 
            // nodeControl5
            // 
            this.nodeControl5.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl5.Location = new System.Drawing.Point(25, 143);
            this.nodeControl5.Name = "nodeControl5";
            this.nodeControl5.Size = new System.Drawing.Size(111, 32);
            this.nodeControl5.TabIndex = 10;
            // 
            // notGateControl3
            // 
            this.notGateControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notGateControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notGateControl3.Location = new System.Drawing.Point(158, 143);
            this.notGateControl3.Name = "notGateControl3";
            this.notGateControl3.Size = new System.Drawing.Size(112, 34);
            this.notGateControl3.TabIndex = 9;
            // 
            // notGateControl2
            // 
            this.notGateControl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notGateControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notGateControl2.Location = new System.Drawing.Point(420, 233);
            this.notGateControl2.Name = "notGateControl2";
            this.notGateControl2.Size = new System.Drawing.Size(112, 34);
            this.notGateControl2.TabIndex = 7;
            // 
            // notGateControl1
            // 
            this.notGateControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notGateControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notGateControl1.Location = new System.Drawing.Point(420, 73);
            this.notGateControl1.Name = "notGateControl1";
            this.notGateControl1.Size = new System.Drawing.Size(112, 34);
            this.notGateControl1.TabIndex = 6;
            // 
            // nodeControl3
            // 
            this.nodeControl3.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl3.Location = new System.Drawing.Point(678, 261);
            this.nodeControl3.Name = "nodeControl3";
            this.nodeControl3.Size = new System.Drawing.Size(111, 32);
            this.nodeControl3.TabIndex = 3;
            // 
            // nodeControl4
            // 
            this.nodeControl4.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl4.Location = new System.Drawing.Point(678, 223);
            this.nodeControl4.Name = "nodeControl4";
            this.nodeControl4.Size = new System.Drawing.Size(111, 32);
            this.nodeControl4.TabIndex = 2;
            // 
            // nodeControl2
            // 
            this.nodeControl2.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl2.Location = new System.Drawing.Point(678, 98);
            this.nodeControl2.Name = "nodeControl2";
            this.nodeControl2.Size = new System.Drawing.Size(111, 32);
            this.nodeControl2.TabIndex = 1;
            // 
            // nodeControl1
            // 
            this.nodeControl1.BackColor = System.Drawing.Color.LemonChiffon;
            this.nodeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeControl1.Location = new System.Drawing.Point(678, 60);
            this.nodeControl1.Name = "nodeControl1";
            this.nodeControl1.Size = new System.Drawing.Size(111, 32);
            this.nodeControl1.TabIndex = 0;
            // 
            // andGateControl1
            // 
            this.andGateControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.andGateControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andGateControl1.Location = new System.Drawing.Point(301, 99);
            this.andGateControl1.Name = "andGateControl1";
            this.andGateControl1.Size = new System.Drawing.Size(68, 30);
            this.andGateControl1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 475);
            this.Controls.Add(this.andGateControl1);
            this.Controls.Add(this.nodeControl5);
            this.Controls.Add(this.notGateControl3);
            this.Controls.Add(this.notGateControl2);
            this.Controls.Add(this.notGateControl1);
            this.Controls.Add(this.nodeControl3);
            this.Controls.Add(this.nodeControl4);
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
        private Controls.NodeControl nodeControl4;
        private Controls.NotGateControl notGateControl1;
        private Controls.NotGateControl notGateControl2;
        private Controls.NotGateControl notGateControl3;
        private Controls.NodeControl nodeControl5;
        private Controls.AndGateControl andGateControl1;

    }
}

