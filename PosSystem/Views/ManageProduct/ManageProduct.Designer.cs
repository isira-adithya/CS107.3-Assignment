namespace PosSystem
{
    partial class ManageProduct
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
            this.topic_delete = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Editprod_groupbox = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.Editprod_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topic_delete
            // 
            this.topic_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topic_delete.AutoSize = true;
            this.topic_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_delete.Location = new System.Drawing.Point(129, 11);
            this.topic_delete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topic_delete.Name = "topic_delete";
            this.topic_delete.Size = new System.Drawing.Size(239, 46);
            this.topic_delete.TabIndex = 0;
            this.topic_delete.Text = "Edit Product";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(407, 410);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 38);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.AddProCancel_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(21, 410);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 38);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateDetailsButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Name :";
            // 
            // productName
            // 
            this.productName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productName.Location = new System.Drawing.Point(176, 103);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(341, 22);
            this.productName.TabIndex = 28;
            // 
            // productQuantity
            // 
            this.productQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productQuantity.Location = new System.Drawing.Point(176, 342);
            this.productQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(61, 22);
            this.productQuantity.TabIndex = 31;
            this.productQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productDescription
            // 
            this.productDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productDescription.Location = new System.Drawing.Point(176, 166);
            this.productDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(341, 116);
            this.productDescription.TabIndex = 30;
            // 
            // productPrice
            // 
            this.productPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productPrice.Location = new System.Drawing.Point(176, 290);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(132, 22);
            this.productPrice.TabIndex = 29;
            this.productPrice.TextChanged += new System.EventHandler(this.checkPrice);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity :";
            // 
            // Editprod_groupbox
            // 
            this.Editprod_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editprod_groupbox.Controls.Add(this.deleteBtn);
            this.Editprod_groupbox.Controls.Add(this.label3);
            this.Editprod_groupbox.Controls.Add(this.productName);
            this.Editprod_groupbox.Controls.Add(this.productQuantity);
            this.Editprod_groupbox.Controls.Add(this.productDescription);
            this.Editprod_groupbox.Controls.Add(this.productPrice);
            this.Editprod_groupbox.Controls.Add(this.label4);
            this.Editprod_groupbox.Controls.Add(this.label5);
            this.Editprod_groupbox.Controls.Add(this.label6);
            this.Editprod_groupbox.Controls.Add(this.updateButton);
            this.Editprod_groupbox.Controls.Add(this.cancelButton);
            this.Editprod_groupbox.Location = new System.Drawing.Point(0, 251);
            this.Editprod_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Editprod_groupbox.Name = "Editprod_groupbox";
            this.Editprod_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Editprod_groupbox.Size = new System.Drawing.Size(527, 484);
            this.Editprod_groupbox.TabIndex = 32;
            this.Editprod_groupbox.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(139, 410);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 38);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Location = new System.Drawing.Point(21, 174);
            this.searchQueryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(496, 22);
            this.searchQueryTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Choose the product to edit";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(21, 218);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 737);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchQueryTextBox);
            this.Controls.Add(this.Editprod_groupbox);
            this.Controls.Add(this.topic_delete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageProduct";
            this.Text = "EditProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.goBackToPreviousForm);
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.Editprod_groupbox.ResumeLayout(false);
            this.Editprod_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_delete;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.NumericUpDown productQuantity;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Editprod_groupbox;
        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button deleteBtn;
    }
}

