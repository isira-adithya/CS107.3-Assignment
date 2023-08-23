namespace PosSystem
{
    partial class AdminHome
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
            this.viewProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.editProductBtn = new System.Windows.Forms.Button();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.printBillBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home - Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewProductBtn
            // 
            this.viewProductBtn.Location = new System.Drawing.Point(202, 112);
            this.viewProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewProductBtn.Name = "viewProductBtn";
            this.viewProductBtn.Size = new System.Drawing.Size(120, 42);
            this.viewProductBtn.TabIndex = 1;
            this.viewProductBtn.Text = "View Products";
            this.viewProductBtn.UseVisualStyleBackColor = true;
            this.viewProductBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(21, 112);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(111, 42);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // editProductBtn
            // 
            this.editProductBtn.Location = new System.Drawing.Point(389, 112);
            this.editProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editProductBtn.Name = "editProductBtn";
            this.editProductBtn.Size = new System.Drawing.Size(147, 42);
            this.editProductBtn.TabIndex = 3;
            this.editProductBtn.Text = "Manage Products";
            this.editProductBtn.UseVisualStyleBackColor = true;
            this.editProductBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(389, 181);
            this.deleteProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(145, 42);
            this.deleteProductBtn.TabIndex = 4;
            this.deleteProductBtn.Text = "Manage Accounts";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // printBillBtn
            // 
            this.printBillBtn.Location = new System.Drawing.Point(21, 248);
            this.printBillBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.Size = new System.Drawing.Size(111, 42);
            this.printBillBtn.TabIndex = 5;
            this.printBillBtn.Text = "Add Order";
            this.printBillBtn.UseVisualStyleBackColor = true;
            this.printBillBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(21, 181);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(111, 42);
            this.addUserBtn.TabIndex = 7;
            this.addUserBtn.Text = "Add Account";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "View Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.printBillBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.editProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.viewProductBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.Text = "Home - Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button editProductBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button printBillBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}