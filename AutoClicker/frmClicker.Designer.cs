namespace AutoClicker
{
    partial class frmClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClicker));
            this.MouseYLabel = new System.Windows.Forms.Label();
            this.MouseXLabel = new System.Windows.Forms.Label();
            this.txtLocX = new System.Windows.Forms.TextBox();
            this.txtLocY = new System.Windows.Forms.TextBox();
            this.btnLocateFinder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrandomdelay = new System.Windows.Forms.TextBox();
            this.txtdelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MouseYLabel
            // 
            this.MouseYLabel.AutoSize = true;
            this.MouseYLabel.Location = new System.Drawing.Point(12, 38);
            this.MouseYLabel.Name = "MouseYLabel";
            this.MouseYLabel.Size = new System.Drawing.Size(95, 13);
            this.MouseYLabel.TabIndex = 14;
            this.MouseYLabel.Text = "Mouse Y Position: ";
            // 
            // MouseXLabel
            // 
            this.MouseXLabel.AutoSize = true;
            this.MouseXLabel.Location = new System.Drawing.Point(12, 11);
            this.MouseXLabel.Name = "MouseXLabel";
            this.MouseXLabel.Size = new System.Drawing.Size(95, 13);
            this.MouseXLabel.TabIndex = 13;
            this.MouseXLabel.Text = "Mouse X Position: ";
            // 
            // txtLocX
            // 
            this.txtLocX.Location = new System.Drawing.Point(113, 8);
            this.txtLocX.Name = "txtLocX";
            this.txtLocX.Size = new System.Drawing.Size(60, 20);
            this.txtLocX.TabIndex = 15;
            this.txtLocX.Text = "0";
            // 
            // txtLocY
            // 
            this.txtLocY.Location = new System.Drawing.Point(113, 35);
            this.txtLocY.Name = "txtLocY";
            this.txtLocY.Size = new System.Drawing.Size(60, 20);
            this.txtLocY.TabIndex = 16;
            this.txtLocY.Text = "0";
            // 
            // btnLocateFinder
            // 
            this.btnLocateFinder.Location = new System.Drawing.Point(198, 33);
            this.btnLocateFinder.Name = "btnLocateFinder";
            this.btnLocateFinder.Size = new System.Drawing.Size(90, 23);
            this.btnLocateFinder.TabIndex = 17;
            this.btnLocateFinder.Text = "Find Location";
            this.btnLocateFinder.UseVisualStyleBackColor = true;
            this.btnLocateFinder.Click += new System.EventHandler(this.BtnLocateFinder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrandomdelay);
            this.groupBox1.Controls.Add(this.txtdelay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 109);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Click Settings";
            // 
            // txtrandomdelay
            // 
            this.txtrandomdelay.Location = new System.Drawing.Point(113, 59);
            this.txtrandomdelay.Name = "txtrandomdelay";
            this.txtrandomdelay.Size = new System.Drawing.Size(60, 20);
            this.txtrandomdelay.TabIndex = 3;
            this.txtrandomdelay.Text = "0";
            // 
            // txtdelay
            // 
            this.txtdelay.Location = new System.Drawing.Point(113, 33);
            this.txtdelay.Name = "txtdelay";
            this.txtdelay.Size = new System.Drawing.Size(60, 20);
            this.txtdelay.TabIndex = 2;
            this.txtdelay.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Random Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Delay";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Auto Clicker By M.U";
            // 
            // chkTopmost
            // 
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.Location = new System.Drawing.Point(198, 10);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(68, 17);
            this.chkTopmost.TabIndex = 20;
            this.chkTopmost.Text = "TopMost";
            this.chkTopmost.UseVisualStyleBackColor = true;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.ChkTopmost_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Goto Location and Press SPACE";
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRun.Location = new System.Drawing.Point(304, 111);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(68, 55);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "START";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLocateFinder);
            this.Controls.Add(this.txtLocY);
            this.Controls.Add(this.txtLocX);
            this.Controls.Add(this.MouseYLabel);
            this.Controls.Add(this.MouseXLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 260);
            this.Name = "frmClicker";
            this.Text = "Auto Clicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MouseYLabel;
        private System.Windows.Forms.Label MouseXLabel;
        private System.Windows.Forms.TextBox txtLocX;
        private System.Windows.Forms.TextBox txtLocY;
        private System.Windows.Forms.Button btnLocateFinder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox chkTopmost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrandomdelay;
        private System.Windows.Forms.TextBox txtdelay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

