
namespace SetRegionalWeaponsControlStatus
{
    partial class Dummy
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
            this.rgnlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRegionalWeaponsControlStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rgnlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rgnlToolStripMenuItem
            // 
            this.rgnlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRegionalWeaponsControlStatusToolStripMenuItem});
            this.rgnlToolStripMenuItem.Name = "rgnlToolStripMenuItem";
            this.rgnlToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.rgnlToolStripMenuItem.Text = "Rgnl";
            // 
            // setRegionalWeaponsControlStatusToolStripMenuItem
            // 
            this.setRegionalWeaponsControlStatusToolStripMenuItem.Name = "setRegionalWeaponsControlStatusToolStripMenuItem";
            this.setRegionalWeaponsControlStatusToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.setRegionalWeaponsControlStatusToolStripMenuItem.Text = "Set RegionalWeapons Control Status";
            this.setRegionalWeaponsControlStatusToolStripMenuItem.Click += new System.EventHandler(this.setRegionalWeaponsControlStatusToolStripMenuItem_Click);
            // 
            // Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 436);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dummy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rgnlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRegionalWeaponsControlStatusToolStripMenuItem;
    }
}