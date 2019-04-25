namespace WindowsFormsApplication2
{
	partial class UserLogin
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
			this.checkConnection = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(129, 113);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 52);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(121, 61);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 20);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(121, 87);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '#';
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// btnSignUp
			// 
			this.btnSignUp.Location = new System.Drawing.Point(295, 64);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(75, 23);
			this.btnSignUp.TabIndex = 4;
			this.btnSignUp.Text = "SignUp";
			this.btnSignUp.UseVisualStyleBackColor = true;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// lblForgotPassword
			// 
			this.lblForgotPassword.AutoSize = true;
			this.lblForgotPassword.Location = new System.Drawing.Point(118, 183);
			this.lblForgotPassword.Name = "lblForgotPassword";
			this.lblForgotPassword.Size = new System.Drawing.Size(86, 13);
			this.lblForgotPassword.TabIndex = 3;
			this.lblForgotPassword.TabStop = true;
			this.lblForgotPassword.Text = "Forgot Password";
			this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
			// 
			// checkConnection
			// 
			this.checkConnection.AutoSize = true;
			this.checkConnection.Location = new System.Drawing.Point(292, 205);
			this.checkConnection.Name = "checkConnection";
			this.checkConnection.Size = new System.Drawing.Size(0, 13);
			this.checkConnection.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Email:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Password:";
			// 
			// UserLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 248);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkConnection);
			this.Controls.Add(this.lblForgotPassword);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnLogin);
			this.Name = "UserLogin";
			this.Text = "UserLogin";
			this.Load += new System.EventHandler(this.UserLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.LinkLabel lblForgotPassword;
		private System.Windows.Forms.Label checkConnection;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}