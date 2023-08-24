namespace PosSystem.Views.ViewOrder
{
    partial class ViewOrder
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
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cnameLabel = new System.Windows.Forms.Label();
            this.cEmailLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.cPhoneLabel = new System.Windows.Forms.Label();
            this.cAddressLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.orderDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Orders";
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Location = new System.Drawing.Point(34, 79);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.RowHeadersWidth = 51;
            this.ordersDataGrid.RowTemplate.Height = 24;
            this.ordersDataGrid.Size = new System.Drawing.Size(826, 333);
            this.ordersDataGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "More Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID:";
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Location = new System.Drawing.Point(117, 485);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(99, 22);
            this.searchQueryTextBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(32, 523);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer\'s Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer\'s Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Customer\'s Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date/Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 696);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 728);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Payment Method:";
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnameLabel.Location = new System.Drawing.Point(178, 591);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(38, 16);
            this.cnameLabel.TabIndex = 13;
            this.cnameLabel.Text = "Test";
            // 
            // cEmailLabel
            // 
            this.cEmailLabel.AutoSize = true;
            this.cEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEmailLabel.Location = new System.Drawing.Point(178, 628);
            this.cEmailLabel.Name = "cEmailLabel";
            this.cEmailLabel.Size = new System.Drawing.Size(38, 16);
            this.cEmailLabel.TabIndex = 14;
            this.cEmailLabel.Text = "Test";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(178, 663);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(38, 16);
            this.dateTimeLabel.TabIndex = 15;
            this.dateTimeLabel.Text = "Test";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(178, 696);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(38, 16);
            this.totalPriceLabel.TabIndex = 16;
            this.totalPriceLabel.Text = "Test";
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodLabel.Location = new System.Drawing.Point(178, 728);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(38, 16);
            this.paymentMethodLabel.TabIndex = 17;
            this.paymentMethodLabel.Text = "Test";
            // 
            // cPhoneLabel
            // 
            this.cPhoneLabel.AutoSize = true;
            this.cPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhoneLabel.Location = new System.Drawing.Point(564, 591);
            this.cPhoneLabel.Name = "cPhoneLabel";
            this.cPhoneLabel.Size = new System.Drawing.Size(38, 16);
            this.cPhoneLabel.TabIndex = 18;
            this.cPhoneLabel.Text = "Test";
            // 
            // cAddressLabel
            // 
            this.cAddressLabel.AutoSize = true;
            this.cAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddressLabel.Location = new System.Drawing.Point(564, 628);
            this.cAddressLabel.Name = "cAddressLabel";
            this.cAddressLabel.Size = new System.Drawing.Size(38, 16);
            this.cAddressLabel.TabIndex = 19;
            this.cAddressLabel.Text = "Test";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 763);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 20;
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Location = new System.Drawing.Point(32, 763);
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.RowHeadersWidth = 51;
            this.orderDataGrid.RowTemplate.Height = 24;
            this.orderDataGrid.Size = new System.Drawing.Size(828, 199);
            this.orderDataGrid.TabIndex = 21;
            this.orderDataGrid.Visible = false;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 993);
            this.Controls.Add(this.orderDataGrid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cAddressLabel);
            this.Controls.Add(this.cPhoneLabel);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.cEmailLabel);
            this.Controls.Add(this.cnameLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchQueryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordersDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrder";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "ViewOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewOrder_FormClosed);
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cnameLabel;
        private System.Windows.Forms.Label cEmailLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label cPhoneLabel;
        private System.Windows.Forms.Label cAddressLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView orderDataGrid;
    }
}