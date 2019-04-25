using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication2
{
	public partial class UserLogin : Form
	{
		private OleDbConnection connection = new OleDbConnection();
		public UserLogin()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Study\GSU Senior Project and Seminar 4900\Project\WindowsFormsApplication2\DNS.accdb;
Persist Security Info=False;";
		}

		private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("You are doomed!", "Forgot Password");
		}

		private void UserLogin_Load(object sender, EventArgs e)
		{
			try
			{
				txtUserName.Text = "Enter Email ID";
				txtUserName.ForeColor = Color.DarkGray;
				txtPassword.Text = "Password";
				txtPassword.ForeColor = Color.DarkGray;

				connection.Open();
				checkConnection.Text = "Connection Successful";

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error"+ ex);
			}
			
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUserName.Text == "")
				{
					MessageBox.Show("Email cannot be empty");
					txtUserName.Focus();
				}
				else if(txtPassword.Text == "")
				{
					MessageBox.Show("Password cannot be empty");
					txtPassword.Focus();
				}
				else
				{
					String hashedPassword = GenerateSHA256Hash(txtPassword.Text);

					connection.Open();
					OleDbCommand command = new OleDbCommand();
					
					command.Connection = connection;
					command.CommandText = "select * from Users where email='" + txtUserName.Text + "' and  userPassword='" + hashedPassword + "'";

					OleDbDataReader reader = command.ExecuteReader();
					
					int count = 0;
					while (reader.Read())
					{
						count = count + 1;

					}
					if (count == 1)
					{
						connection.Close();
						connection.Open();
						
						command.CommandText = "select ID,userName from Users where email='"+txtUserName.Text+"'";
						reader = command.ExecuteReader();

						while (reader.Read())
						{
							// Delete this MessageBox.Show(reader.GetString(1) + " id : " + reader.GetInt32(0));
							MessageBox.Show("Login Successful!\n Welcome "+reader.GetString(1), "DNS login");
							Globals.currentUser = reader.GetString(1);
							Globals.currentUserID = reader.GetInt32(0);
							
						}
						
						
						connection.Close();
						connection.Dispose();
						this.Hide();
						if (Globals.currentUser == "ADMIN")
						{
							AdminPage f1 = new AdminPage();
							f1.ShowDialog();
						}
						else
						{
							HomePage f2 = new HomePage();
							f2.ShowDialog();
						}
					}
					else if (count > 1)
					{
						MessageBox.Show("Duplicate Email and Password found","Duplicate found");
					}
					else
					{
						MessageBox.Show("Email and password are incorrect");
					}

					connection.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
			
		}

		public String GenerateSHA256Hash(String input)
		{
			byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
			System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
			byte[] hash = sha256hashstring.ComputeHash(bytes);

			return ByteArrayToHexString(hash);
		}
		public static string ByteArrayToHexString(byte[] ba)
		{
			StringBuilder hex = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
				hex.AppendFormat("{0:x2}", b);
			return hex.ToString();
		}

		private void txtUserName_Enter(object sender, EventArgs e)
		{
			if (txtUserName.Text == "Enter Email ID")
			{
				txtUserName.Text = "";
				txtUserName.ForeColor = Color.Black;
			}
		}

		private void txtUserName_Leave(object sender, EventArgs e)
		{
			if (txtUserName.Text == "")
			{
				txtUserName.Text = "Enter Email ID";
				txtUserName.ForeColor = Color.DarkGray;
			}
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "Password")
			{
				txtPassword.Text = "";
				txtPassword.ForeColor = Color.Black;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				txtPassword.Text = "Password";
				txtPassword.ForeColor = Color.DarkGray;
			}
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			try
			{
				SignUp f2 = new SignUp();
				f2.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}
	}
}
