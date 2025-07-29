
namespace ComputerSaleSystem
{
    partial class ComputerSaleSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerSaleSystem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuemployeereport = new System.Windows.Forms.ToolStripMenuItem();
            this.customerreport = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.mnuemployeereport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegister,
            this.mnusupplier});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.entryToolStripMenuItem.Text = "&Entry";
            // 
            // mnuRegister
            // 
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(224, 26);
            this.mnuRegister.Text = "Register";
            this.mnuRegister.Click += new System.EventHandler(this.mnuRegister_Click);
            // 
            // mnusupplier
            // 
            this.mnusupplier.Name = "mnusupplier";
            this.mnusupplier.Size = new System.Drawing.Size(224, 26);
            this.mnusupplier.Text = "&Supplier";
            this.mnusupplier.Click += new System.EventHandler(this.mnusupplier_Click);
            // 
            // mnuemployeereport
            // 
            this.mnuemployeereport.AutoToolTip = true;
            this.mnuemployeereport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerreport,
            this.employeeReportToolStripMenuItem});
            this.mnuemployeereport.Name = "mnuemployeereport";
            this.mnuemployeereport.Size = new System.Drawing.Size(68, 24);
            this.mnuemployeereport.Text = "&Report";
            // 
            // customerreport
            // 
            this.customerreport.Name = "customerreport";
            this.customerreport.Size = new System.Drawing.Size(207, 26);
            this.customerreport.Text = "Customer Report";
            this.customerreport.Click += new System.EventHandler(this.customerreport_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ComputerSaleSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ComputerSaleSystem";
            this.Text = "ComputerSaleSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuemployeereport;
        private System.Windows.Forms.ToolStripMenuItem customerreport;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnusupplier;
    }
}