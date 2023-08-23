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
            this.AddProCancel = new System.Windows.Forms.Button();
            this.UpdateDetailsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NProduct_Name = new System.Windows.Forms.TextBox();
            this.NQuanty = new System.Windows.Forms.NumericUpDown();
            this.NDescription = new System.Windows.Forms.TextBox();
            this.NPrc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Editprod_groupbox = new System.Windows.Forms.GroupBox();
            this.SearchBoxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NQuanty)).BeginInit();
            this.Editprod_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topic_delete
            // 
            this.topic_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topic_delete.AutoSize = true;
            this.topic_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_delete.Location = new System.Drawing.Point(97, 9);
            this.topic_delete.Name = "topic_delete";
            this.topic_delete.Size = new System.Drawing.Size(192, 37);
            this.topic_delete.TabIndex = 0;
            this.topic_delete.Text = "Edit Product";
            // 
            // AddProCancel
            // 
            this.AddProCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddProCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProCancel.Location = new System.Drawing.Point(305, 333);
            this.AddProCancel.Name = "AddProCancel";
            this.AddProCancel.Size = new System.Drawing.Size(75, 31);
            this.AddProCancel.TabIndex = 21;
            this.AddProCancel.Text = "Cancel";
            this.AddProCancel.UseVisualStyleBackColor = true;
            this.AddProCancel.Click += new System.EventHandler(this.AddProCancel_Click);
            // 
            // UpdateDetailsButton
            // 
            this.UpdateDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDetailsButton.Location = new System.Drawing.Point(16, 333);
            this.UpdateDetailsButton.Name = "UpdateDetailsButton";
            this.UpdateDetailsButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateDetailsButton.TabIndex = 20;
            this.UpdateDetailsButton.Text = "Update";
            this.UpdateDetailsButton.UseVisualStyleBackColor = true;
            this.UpdateDetailsButton.Click += new System.EventHandler(this.UpdateDetailsButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Name :";
            // 
            // NProduct_Name
            // 
            this.NProduct_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NProduct_Name.Location = new System.Drawing.Point(132, 84);
            this.NProduct_Name.Name = "NProduct_Name";
            this.NProduct_Name.Size = new System.Drawing.Size(257, 20);
            this.NProduct_Name.TabIndex = 28;
            // 
            // NQuanty
            // 
            this.NQuanty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NQuanty.Location = new System.Drawing.Point(132, 278);
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
            // 
            // NDescription
            // 
            this.NDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NDescription.Location = new System.Drawing.Point(132, 135);
            this.NDescription.Multiline = true;
            this.NDescription.Name = "NDescription";
            this.NDescription.Size = new System.Drawing.Size(257, 95);
            this.NDescription.TabIndex = 30;
            // 
            // NPrc
            // 
            this.NPrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NPrc.Location = new System.Drawing.Point(132, 236);
            this.NPrc.Name = "NPrc";
            this.NPrc.Size = new System.Drawing.Size(100, 20);
            this.NPrc.TabIndex = 29;
            this.NPrc.TextChanged += new System.EventHandler(this.checkPrice);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity :";
            // 
            // Editprod_groupbox
            // 
            this.Editprod_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editprod_groupbox.Controls.Add(this.deleteBtn);
            this.Editprod_groupbox.Controls.Add(this.label3);
            this.Editprod_groupbox.Controls.Add(this.NProduct_Name);
            this.Editprod_groupbox.Controls.Add(this.NQuanty);
            this.Editprod_groupbox.Controls.Add(this.NDescription);
            this.Editprod_groupbox.Controls.Add(this.NPrc);
            this.Editprod_groupbox.Controls.Add(this.label4);
            this.Editprod_groupbox.Controls.Add(this.label5);
            this.Editprod_groupbox.Controls.Add(this.label6);
            this.Editprod_groupbox.Controls.Add(this.UpdateDetailsButton);
            this.Editprod_groupbox.Controls.Add(this.AddProCancel);
            this.Editprod_groupbox.Location = new System.Drawing.Point(0, 204);
            this.Editprod_groupbox.Name = "Editprod_groupbox";
            this.Editprod_groupbox.Size = new System.Drawing.Size(395, 393);
            this.Editprod_groupbox.TabIndex = 32;
            this.Editprod_groupbox.TabStop = false;
            // 
            // SearchBoxTextBox
            // 
            this.SearchBoxTextBox.Location = new System.Drawing.Point(16, 141);
            this.SearchBoxTextBox.Name = "SearchBoxTextBox";
            this.SearchBoxTextBox.Size = new System.Drawing.Size(373, 20);
            this.SearchBoxTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Choose the product to edit";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(16, 177);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(104, 333);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 31);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 599);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchBoxTextBox);
            this.Controls.Add(this.Editprod_groupbox);
            this.Controls.Add(this.topic_delete);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.goBackToPreviousForm);
            ((System.ComponentModel.ISupportInitialize)(this.NQuanty)).EndInit();
            this.Editprod_groupbox.ResumeLayout(false);
            this.Editprod_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_delete;
        private System.Windows.Forms.Button AddProCancel;
        private System.Windows.Forms.Button UpdateDetailsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NProduct_Name;
        private System.Windows.Forms.NumericUpDown NQuanty;
        private System.Windows.Forms.TextBox NDescription;
        private System.Windows.Forms.TextBox NPrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Editprod_groupbox;
        private System.Windows.Forms.TextBox SearchBoxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button deleteBtn;
    }
}

