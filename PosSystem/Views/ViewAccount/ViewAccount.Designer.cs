namespace PosSystem.Views.ViewAccount
{
    partial class ViewAccount
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
            this.accountsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsDataGrid
            // 
            this.accountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGrid.Location = new System.Drawing.Point(44, 91);
            this.accountsDataGrid.Name = "accountsDataGrid";
            this.accountsDataGrid.RowHeadersWidth = 51;
            this.accountsDataGrid.RowTemplate.Height = 24;
            this.accountsDataGrid.Size = new System.Drawing.Size(729, 357);
            this.accountsDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts";
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAccount";
            this.Text = "ViewAccount";
            this.Load += new System.EventHandler(this.ViewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsDataGrid;
        private System.Windows.Forms.Label label1;
    }
}