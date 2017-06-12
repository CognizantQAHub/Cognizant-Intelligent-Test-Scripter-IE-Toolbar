namespace SearchBar
{
    partial class CognizantITSToolbar
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cogToolBarSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.spyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.highlightColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.connectionAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.enableToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cogToolBarSplitButton,
            this.toolStripSplitButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cogToolBarSplitButton
            // 
            this.cogToolBarSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spyToolStripMenuItem});
            this.cogToolBarSplitButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.cogToolBarSplitButton.Image = global::SearchBar.Properties.Resources.logo;
            this.cogToolBarSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cogToolBarSplitButton.Name = "cogToolBarSplitButton";
            this.cogToolBarSplitButton.Size = new System.Drawing.Size(32, 22);
            this.cogToolBarSplitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cogToolBarSplitButton.ToolTipText = "CognizantITS IE Extension  - 1.0";
            this.cogToolBarSplitButton.ButtonClick += new System.EventHandler(this.mainToolBarButton_Click);
            // 
            // spyToolStripMenuItem
            // 
            this.spyToolStripMenuItem.CheckOnClick = true;
            this.spyToolStripMenuItem.Name = "spyToolStripMenuItem";
            this.spyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.spyToolStripMenuItem.Text = "Spy";
            this.spyToolStripMenuItem.Visible = false;
            this.spyToolStripMenuItem.CheckedChanged += new System.EventHandler(this.spyToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highlightColorToolStripMenuItem,
            this.connectionAddressToolStripMenuItem,
            this.enableToolbarToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::SearchBar.Properties.Resources.settings;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            this.toolStripSplitButton2.ToolTipText = "Settings";
            // 
            // highlightColorToolStripMenuItem
            // 
            this.highlightColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTextBox});
            this.highlightColorToolStripMenuItem.Name = "highlightColorToolStripMenuItem";
            this.highlightColorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.highlightColorToolStripMenuItem.Text = "Highlight Color";
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.Color.Blue;
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(100, 23);
            this.colorTextBox.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // connectionAddressToolStripMenuItem
            // 
            this.connectionAddressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressTextBox});
            this.connectionAddressToolStripMenuItem.Name = "connectionAddressToolStripMenuItem";
            this.connectionAddressToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.connectionAddressToolStripMenuItem.Text = "Connection Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 23);
            this.addressTextBox.Text = "wss://localhost:8887";
            // 
            // enableToolbarToolStripMenuItem
            // 
            this.enableToolbarToolStripMenuItem.Name = "enableToolbarToolStripMenuItem";
            this.enableToolbarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.enableToolbarToolStripMenuItem.Text = "Enable Toolbar";
            this.enableToolbarToolStripMenuItem.ToolTipText = "Enable Toolbar on all Windows";
            this.enableToolbarToolStripMenuItem.Click += new System.EventHandler(this.enableToolbarToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SearchBar.Properties.Resources.error;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Launch";
            this.toolStripButton1.ToolTipText = "Connection Status";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // CognizantITSToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CognizantITSToolbar";
            this.Size = new System.Drawing.Size(368, 27);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton cogToolBarSplitButton;
        private System.Windows.Forms.ToolStripMenuItem spyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem highlightColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox colorTextBox;
        private System.Windows.Forms.ToolStripMenuItem connectionAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox addressTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem enableToolbarToolStripMenuItem;
    }
}
