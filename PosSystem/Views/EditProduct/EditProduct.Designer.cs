namespace PosSystem
{
    partial class EditProduct
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
            this.EProductName = new System.Windows.Forms.Label();
            this.AddProCancel = new System.Windows.Forms.Button();
            this.product_add = new System.Windows.Forms.Button();
            this.Descip = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NProduct_Name = new System.Windows.Forms.TextBox();
            this.NQuanty = new System.Windows.Forms.NumericUpDown();
            this.NDescription = new System.Windows.Forms.TextBox();
            this.NPrc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Editprod_groupbox = new System.Windows.Forms.GroupBox();
            this.ExistingProductQuantityLabel = new System.Windows.Forms.Label();
            this.ExistingProductPriceLabel = new System.Windows.Forms.Label();
            this.ExistingProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ExistingProductNameLabel = new System.Windows.Forms.Label();
            this.SearchBoxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NQuanty)).BeginInit();
            this.Editprod_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topic_delete
            // 
            this.topic_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topic_delete.AutoSize = true;
            this.topic_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_delete.Location = new System.Drawing.Point(252, 9);
            this.topic_delete.Name = "topic_delete";
            this.topic_delete.Size = new System.Drawing.Size(192, 37);
            this.topic_delete.TabIndex = 0;
            this.topic_delete.Text = "Edit Product";
            this.topic_delete.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // EProductName
            // 
            this.EProductName.AutoSize = true;
            this.EProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EProductName.Location = new System.Drawing.Point(19, 125);
            this.EProductName.Name = "EProductName";
            this.EProductName.Size = new System.Drawing.Size(118, 20);
            this.EProductName.TabIndex = 12;
            this.EProductName.Text = "Product Name :";
            this.EProductName.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // AddProCancel
            // 
            this.AddProCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddProCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProCancel.Location = new System.Drawing.Point(624, 356);
            this.AddProCancel.Name = "AddProCancel";
            this.AddProCancel.Size = new System.Drawing.Size(75, 31);
            this.AddProCancel.TabIndex = 21;
            this.AddProCancel.Text = "Cancel";
            this.AddProCancel.UseVisualStyleBackColor = true;
            this.AddProCancel.SizeChanged += new System.EventHandler(this.product_add_Click);
            this.AddProCancel.Click += new System.EventHandler(this.AddProCancel_Click);
            // 
            // product_add
            // 
            this.product_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.product_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_add.Location = new System.Drawing.Point(521, 356);
            this.product_add.Name = "product_add";
            this.product_add.Size = new System.Drawing.Size(75, 31);
            this.product_add.TabIndex = 20;
            this.product_add.Text = "Save";
            this.product_add.UseVisualStyleBackColor = true;
            this.product_add.SizeChanged += new System.EventHandler(this.product_add_Click);
            this.product_add.Click += new System.EventHandler(this.product_add_Click);
            // 
            // Descip
            // 
            this.Descip.AutoSize = true;
            this.Descip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descip.Location = new System.Drawing.Point(19, 176);
            this.Descip.Name = "Descip";
            this.Descip.Size = new System.Drawing.Size(97, 20);
            this.Descip.TabIndex = 15;
            this.Descip.Text = "Description :";
            this.Descip.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(19, 258);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(52, 20);
            this.cost.TabIndex = 14;
            this.cost.Text = "Price :";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(19, 300);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(76, 20);
            this.Quantity.TabIndex = 13;
            this.Quantity.Text = "Quantity :";
            this.Quantity.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Existing Details";
            this.label1.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "New Details";
            this.label2.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Name :";
            this.label3.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // NProduct_Name
            // 
            this.NProduct_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NProduct_Name.Location = new System.Drawing.Point(474, 127);
            this.NProduct_Name.Name = "NProduct_Name";
            this.NProduct_Name.Size = new System.Drawing.Size(157, 20);
            this.NProduct_Name.TabIndex = 28;
            this.NProduct_Name.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // NQuanty
            // 
            this.NQuanty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NQuanty.Location = new System.Drawing.Point(474, 300);
            this.NQuanty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NQuanty.Name = "NQuanty";
            this.NQuanty.Size = new System.Drawing.Size(46, 20);
            this.NQuanty.TabIndex = 31;
            this.NQuanty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NQuanty.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // NDescription
            // 
            this.NDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NDescription.Location = new System.Drawing.Point(474, 178);
            this.NDescription.Multiline = true;
            this.NDescription.Name = "NDescription";
            this.NDescription.Size = new System.Drawing.Size(157, 40);
            this.NDescription.TabIndex = 30;
            this.NDescription.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // NPrc
            // 
            this.NPrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NPrc.Location = new System.Drawing.Point(474, 258);
            this.NPrc.Name = "NPrc";
            this.NPrc.Size = new System.Drawing.Size(100, 20);
            this.NPrc.TabIndex = 29;
            this.NPrc.SizeChanged += new System.EventHandler(this.product_add_Click);
            this.NPrc.TextChanged += new System.EventHandler(this.checkPrice);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description :";
            this.label4.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price :";
            this.label5.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity :";
            this.label6.SizeChanged += new System.EventHandler(this.product_add_Click);
            // 
            // Editprod_groupbox
            // 
            this.Editprod_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editprod_groupbox.Controls.Add(this.ExistingProductQuantityLabel);
            this.Editprod_groupbox.Controls.Add(this.ExistingProductPriceLabel);
            this.Editprod_groupbox.Controls.Add(this.ExistingProductDescriptionLabel);
            this.Editprod_groupbox.Controls.Add(this.ExistingProductNameLabel);
            this.Editprod_groupbox.Controls.Add(this.label1);
            this.Editprod_groupbox.Controls.Add(this.label3);
            this.Editprod_groupbox.Controls.Add(this.Quantity);
            this.Editprod_groupbox.Controls.Add(this.NProduct_Name);
            this.Editprod_groupbox.Controls.Add(this.cost);
            this.Editprod_groupbox.Controls.Add(this.NQuanty);
            this.Editprod_groupbox.Controls.Add(this.Descip);
            this.Editprod_groupbox.Controls.Add(this.NDescription);
            this.Editprod_groupbox.Controls.Add(this.NPrc);
            this.Editprod_groupbox.Controls.Add(this.label4);
            this.Editprod_groupbox.Controls.Add(this.label5);
            this.Editprod_groupbox.Controls.Add(this.label6);
            this.Editprod_groupbox.Controls.Add(this.EProductName);
            this.Editprod_groupbox.Controls.Add(this.label2);
            this.Editprod_groupbox.Controls.Add(this.product_add);
            this.Editprod_groupbox.Controls.Add(this.AddProCancel);
            this.Editprod_groupbox.Location = new System.Drawing.Point(0, 204);
            this.Editprod_groupbox.Name = "Editprod_groupbox";
            this.Editprod_groupbox.Size = new System.Drawing.Size(705, 393);
            this.Editprod_groupbox.TabIndex = 32;
            this.Editprod_groupbox.TabStop = false;
            // 
            // ExistingProductQuantityLabel
            // 
            this.ExistingProductQuantityLabel.AutoSize = true;
            this.ExistingProductQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingProductQuantityLabel.Location = new System.Drawing.Point(164, 303);
            this.ExistingProductQuantityLabel.Name = "ExistingProductQuantityLabel";
            this.ExistingProductQuantityLabel.Size = new System.Drawing.Size(0, 20);
            this.ExistingProductQuantityLabel.TabIndex = 35;
            // 
            // ExistingProductPriceLabel
            // 
            this.ExistingProductPriceLabel.AutoSize = true;
            this.ExistingProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingProductPriceLabel.Location = new System.Drawing.Point(164, 258);
            this.ExistingProductPriceLabel.Name = "ExistingProductPriceLabel";
            this.ExistingProductPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.ExistingProductPriceLabel.TabIndex = 34;
            // 
            // ExistingProductDescriptionLabel
            // 
            this.ExistingProductDescriptionLabel.AutoSize = true;
            this.ExistingProductDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingProductDescriptionLabel.Location = new System.Drawing.Point(164, 176);
            this.ExistingProductDescriptionLabel.Name = "ExistingProductDescriptionLabel";
            this.ExistingProductDescriptionLabel.Size = new System.Drawing.Size(0, 20);
            this.ExistingProductDescriptionLabel.TabIndex = 33;
            // 
            // ExistingProductNameLabel
            // 
            this.ExistingProductNameLabel.AutoSize = true;
            this.ExistingProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingProductNameLabel.Location = new System.Drawing.Point(164, 127);
            this.ExistingProductNameLabel.Name = "ExistingProductNameLabel";
            this.ExistingProductNameLabel.Size = new System.Drawing.Size(0, 20);
            this.ExistingProductNameLabel.TabIndex = 32;
            // 
            // SearchBoxTextBox
            // 
            this.SearchBoxTextBox.Location = new System.Drawing.Point(16, 99);
            this.SearchBoxTextBox.Name = "SearchBoxTextBox";
            this.SearchBoxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBoxTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Choose the product to edit";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(16, 135);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 599);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchBoxTextBox);
            this.Controls.Add(this.Editprod_groupbox);
            this.Controls.Add(this.topic_delete);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.NQuanty)).EndInit();
            this.Editprod_groupbox.ResumeLayout(false);
            this.Editprod_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_delete;
        private System.Windows.Forms.Label EProductName;
        private System.Windows.Forms.Button AddProCancel;
        private System.Windows.Forms.Button product_add;
        private System.Windows.Forms.Label Descip;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NProduct_Name;
        private System.Windows.Forms.NumericUpDown NQuanty;
        private System.Windows.Forms.TextBox NDescription;
        private System.Windows.Forms.TextBox NPrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Editprod_groupbox;
        private System.Windows.Forms.Label ExistingProductDescriptionLabel;
        private System.Windows.Forms.Label ExistingProductNameLabel;
        private System.Windows.Forms.Label ExistingProductQuantityLabel;
        private System.Windows.Forms.Label ExistingProductPriceLabel;
        private System.Windows.Forms.TextBox SearchBoxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchButton;
    }
}

