
namespace ComputerSaleSystem
{
    partial class viewadmin
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
            this.dgvDisplayEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayEmployee
            // 
            this.dgvDisplayEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplayEmployee.Name = "dgvDisplayEmployee";
            this.dgvDisplayEmployee.RowHeadersWidth = 51;
            this.dgvDisplayEmployee.RowTemplate.Height = 24;
            this.dgvDisplayEmployee.Size = new System.Drawing.Size(776, 371);
            this.dgvDisplayEmployee.TabIndex = 0;
            // 
            // viewadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDisplayEmployee);
            this.Name = "viewadmin";
            this.Text = "View Admin";
            this.Load += new System.EventHandler(this.lbldisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayEmployee;
    }
}