namespace PosSystem
{
    partial class ViewProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(44, 104);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.RowHeadersWidth = 51;
            this.productsDataGrid.RowTemplate.Height = 24;
            this.productsDataGrid.Size = new System.Drawing.Size(553, 300);
            this.productsDataGrid.TabIndex = 1;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 436);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.goBackToPreviousForm);
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productsDataGrid;
    }
}