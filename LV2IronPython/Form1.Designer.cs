namespace LV2IronPython
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.X1 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.basicOperationsToolStripMenuItem,
            this.addedOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadExtensionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadExtensionsToolStripMenuItem
            // 
            this.loadExtensionsToolStripMenuItem.Name = "loadExtensionsToolStripMenuItem";
            this.loadExtensionsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadExtensionsToolStripMenuItem.Text = "Load Extensions";
            this.loadExtensionsToolStripMenuItem.Click += new System.EventHandler(this.loadExtensionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // basicOperationsToolStripMenuItem
            // 
            this.basicOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subToolStripMenuItem,
            this.mulToolStripMenuItem,
            this.divToolStripMenuItem});
            this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
            this.basicOperationsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.basicOperationsToolStripMenuItem.Text = "Basic Operations";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subToolStripMenuItem.Text = "Sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // mulToolStripMenuItem
            // 
            this.mulToolStripMenuItem.Name = "mulToolStripMenuItem";
            this.mulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mulToolStripMenuItem.Text = "Mul";
            this.mulToolStripMenuItem.Click += new System.EventHandler(this.mulToolStripMenuItem_Click);
            // 
            // divToolStripMenuItem
            // 
            this.divToolStripMenuItem.Name = "divToolStripMenuItem";
            this.divToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divToolStripMenuItem.Text = "Div";
            this.divToolStripMenuItem.Click += new System.EventHandler(this.divToolStripMenuItem_Click);
            // 
            // addedOperationsToolStripMenuItem
            // 
            this.addedOperationsToolStripMenuItem.Name = "addedOperationsToolStripMenuItem";
            this.addedOperationsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.addedOperationsToolStripMenuItem.Text = "Added Operations";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(112, 88);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(20, 13);
            this.X1.TabIndex = 1;
            this.X1.Text = "X1";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(112, 141);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(20, 13);
            this.X2.TabIndex = 2;
            this.X2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RESULT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(192, 81);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 20);
            this.tbX1.TabIndex = 4;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(192, 134);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 20);
            this.tbX2.TabIndex = 5;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(192, 189);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 449);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CALCULATOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadExtensionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem basicOperationsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mulToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem divToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addedOperationsToolStripMenuItem;
        public System.Windows.Forms.Label X1;
        public System.Windows.Forms.Label X2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbX1;
        public System.Windows.Forms.TextBox tbX2;
        public System.Windows.Forms.TextBox tbResult;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

