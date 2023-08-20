namespace PosSystem
{
    partial class AddAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminRoleRadioBtn = new System.Windows.Forms.RadioButton();
            this.userRoleRadioBtn = new System.Windows.Forms.RadioButton();
            this.usernameInputBox = new System.Windows.Forms.TextBox();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.rpasswordInputBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.firstnameInputBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastnameInputBox = new System.Windows.Forms.TextBox();
            this.emailInputBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repeat Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // adminRoleRadioBtn
            // 
            this.adminRoleRadioBtn.AutoSize = true;
            this.adminRoleRadioBtn.Location = new System.Drawing.Point(272, 282);
            this.adminRoleRadioBtn.Name = "adminRoleRadioBtn";
            this.adminRoleRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.adminRoleRadioBtn.TabIndex = 5;
            this.adminRoleRadioBtn.TabStop = true;
            this.adminRoleRadioBtn.Text = "Admin";
            this.adminRoleRadioBtn.UseVisualStyleBackColor = true;
            this.adminRoleRadioBtn.CheckedChanged += new System.EventHandler(this.adminRoleRadioBtn_CheckedChanged);
            // 
            // userRoleRadioBtn
            // 
            this.userRoleRadioBtn.AutoSize = true;
            this.userRoleRadioBtn.Location = new System.Drawing.Point(207, 282);
            this.userRoleRadioBtn.Name = "userRoleRadioBtn";
            this.userRoleRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.userRoleRadioBtn.TabIndex = 6;
            this.userRoleRadioBtn.TabStop = true;
            this.userRoleRadioBtn.Text = "User";
            this.userRoleRadioBtn.UseVisualStyleBackColor = true;
            this.userRoleRadioBtn.CheckedChanged += new System.EventHandler(this.userRoleRadioBtn_CheckedChanged);
            // 
            // usernameInputBox
            // 
            this.usernameInputBox.Location = new System.Drawing.Point(157, 69);
            this.usernameInputBox.Name = "usernameInputBox";
            this.usernameInputBox.Size = new System.Drawing.Size(169, 20);
            this.usernameInputBox.TabIndex = 7;
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Location = new System.Drawing.Point(157, 102);
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.Size = new System.Drawing.Size(169, 20);
            this.passwordInputBox.TabIndex = 8;
            this.passwordInputBox.UseSystemPasswordChar = true;
            // 
            // rpasswordInputBox
            // 
            this.rpasswordInputBox.Location = new System.Drawing.Point(157, 134);
            this.rpasswordInputBox.Name = "rpasswordInputBox";
            this.rpasswordInputBox.Size = new System.Drawing.Size(169, 20);
            this.rpasswordInputBox.TabIndex = 9;
            this.rpasswordInputBox.UseSystemPasswordChar = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(256, 323);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(70, 20);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(169, 323);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(71, 20);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "First Name";
            // 
            // firstnameInputBox
            // 
            this.firstnameInputBox.Location = new System.Drawing.Point(157, 173);
            this.firstnameInputBox.Name = "firstnameInputBox";
            this.firstnameInputBox.Size = new System.Drawing.Size(169, 20);
            this.firstnameInputBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Last Name";
            // 
            // lastnameInputBox
            // 
            this.lastnameInputBox.Location = new System.Drawing.Point(157, 207);
            this.lastnameInputBox.Name = "lastnameInputBox";
            this.lastnameInputBox.Size = new System.Drawing.Size(169, 20);
            this.lastnameInputBox.TabIndex = 15;
            // 
            // emailInputBox
            // 
            this.emailInputBox.Location = new System.Drawing.Point(157, 243);
            this.emailInputBox.Name = "emailInputBox";
            this.emailInputBox.Size = new System.Drawing.Size(169, 20);
            this.emailInputBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email Address";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 357);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailInputBox);
            this.Controls.Add(this.lastnameInputBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firstnameInputBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.rpasswordInputBox);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.usernameInputBox);
            this.Controls.Add(this.userRoleRadioBtn);
            this.Controls.Add(this.adminRoleRadioBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "Add New User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.goBackToPreviousForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton adminRoleRadioBtn;
        private System.Windows.Forms.RadioButton userRoleRadioBtn;
        private System.Windows.Forms.TextBox usernameInputBox;
        private System.Windows.Forms.TextBox passwordInputBox;
        private System.Windows.Forms.TextBox rpasswordInputBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstnameInputBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastnameInputBox;
        private System.Windows.Forms.TextBox emailInputBox;
        private System.Windows.Forms.Label label8;
    }
}