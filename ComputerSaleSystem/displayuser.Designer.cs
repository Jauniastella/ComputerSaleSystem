
namespace ComputerSaleSystem
{
    partial class displayuser
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
            this.dgvDisplayCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayCustomer
            // 
            this.dgvDisplayCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplayCustomer.Name = "dgvDisplayCustomer";
            this.dgvDisplayCustomer.RowHeadersWidth = 51;
            this.dgvDisplayCustomer.RowTemplate.Height = 24;
            this.dgvDisplayCustomer.Size = new System.Drawing.Size(776, 327);
            this.dgvDisplayCustomer.TabIndex = 0;
            // 
            // displayuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDisplayCustomer);
            this.Name = "displayuser";
            this.Text = "displayuser";
            this.Load += new System.EventHandler(this.displayuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayCustomer;
    }
}