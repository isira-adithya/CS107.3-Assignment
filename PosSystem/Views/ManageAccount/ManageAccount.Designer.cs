namespace PosSystem
{
    partial class ManageAccount
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
            this.searchQueryInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.changeRoleBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newPasswordInput = new System.Windows.Forms.TextBox();
            this.repeatPasswordInput = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Account";
            // 
            // searchQueryInput
            // 
            this.searchQueryInput.Location = new System.Drawing.Point(17, 59);
            this.searchQueryInput.Name = "searchQueryInput";
            this.searchQueryInput.Size = new System.Drawing.Size(258, 20);
            this.searchQueryInput.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(17, 85);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Role:";
            // 
            // usernameInput
            // 
            this.usernameInput.Enabled = false;
            this.usernameInput.Location = new System.Drawing.Point(103, 126);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(172, 20);
            this.usernameInput.TabIndex = 8;
            // 
            // emailInput
            // 
            this.emailInput.Enabled = false;
            this.emailInput.Location = new System.Drawing.Point(103, 152);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(172, 20);
            this.emailInput.TabIndex = 9;
            // 
            // firstnameInput
            // 
            this.firstnameInput.Enabled = false;
            this.firstnameInput.Location = new System.Drawing.Point(103, 183);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(172, 20);
            this.firstnameInput.TabIndex = 10;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Enabled = false;
            this.lastnameInput.Location = new System.Drawing.Point(103, 213);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(172, 20);
            this.lastnameInput.TabIndex = 11;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(100, 254);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(36, 13);
            this.roleLabel.TabIndex = 12;
            this.roleLabel.Text = "ROLE";
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(12, 296);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // changeRoleBtn
            // 
            this.changeRoleBtn.Enabled = false;
            this.changeRoleBtn.Location = new System.Drawing.Point(101, 296);
            this.changeRoleBtn.Name = "changeRoleBtn";
            this.changeRoleBtn.Size = new System.Drawing.Size(96, 23);
            this.changeRoleBtn.TabIndex = 14;
            this.changeRoleBtn.Text = "Change Role";
            this.changeRoleBtn.UseVisualStyleBackColor = true;
            this.changeRoleBtn.Click += new System.EventHandler(this.changeRoleBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(210, 296);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Change Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "New Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Repeat Password:";
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.Location = new System.Drawing.Point(147, 387);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(138, 20);
            this.newPasswordInput.TabIndex = 19;
            // 
            // repeatPasswordInput
            // 
            this.repeatPasswordInput.Location = new System.Drawing.Point(147, 415);
            this.repeatPasswordInput.Name = "repeatPasswordInput";
            this.repeatPasswordInput.Size = new System.Drawing.Size(138, 20);
            this.repeatPasswordInput.TabIndex = 20;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Location = new System.Drawing.Point(169, 448);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(116, 23);
            this.changePasswordBtn.TabIndex = 21;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 483);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.repeatPasswordInput);
            this.Controls.Add(this.newPasswordInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeRoleBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.firstnameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchQueryInput);
            this.Controls.Add(this.label1);
            this.Name = "ManageAccount";
            this.Text = "Manage Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchQueryInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox firstnameInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button changeRoleBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.TextBox repeatPasswordInput;
        private System.Windows.Forms.Button changePasswordBtn;
    }
}