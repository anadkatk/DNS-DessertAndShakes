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
    public partial class SignUp : Form
    {
		private OleDbConnection connection = new OleDbConnection();
		public SignUp()
        {
            InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Study\GSU Senior Project and Seminar 4900\Project\WindowsFormsApplication2\DNS.accdb;
Persist Security Info=False;";
		}

        private void chkBoxTerms_CheckedChanged(object sender, EventArgs e)
        {
                btnCreateAccount.Enabled = chkBoxTerms.Checked;
        }

        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.ShowDialog();
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
			
			try
			{
				
				if (txtFullName.Text == "")
				{
					MessageBox.Show("The name cannot be empty");
					txtFullName.Focus();
				}
				else if (txtEmail.Text == "")
				{
					MessageBox.Show("Email cannot be empty");
					txtEmail.Focus();
				}
				else if (txtPassword.Text == "")
				{
					MessageBox.Show("Password cannot be empty");
					txtPassword.Focus();
				}
				else if (txtPhone.Text == "")
				{
					MessageBox.Show("Phone number cannot be empty");
					txtPhone.Focus();
				}
				else if (txtConfirmPassword.Text == "")
				{
					MessageBox.Show("Password cannot be empty");
					txtConfirmPassword.Focus();
				}
				else if(txtPassword.Text != txtConfirmPassword.Text)
				{
					MessageBox.Show("Password is not same");
					txtConfirmPassword.Focus();
				}
				else
				{
					String hashedPassword = GenerateSHA256Hash(txtPassword.Text);
						
					connection.Open();
					
					OleDbCommand command = new OleDbCommand();
					OleDbCommand command2 = new OleDbCommand();
					command.Connection = connection;
					command2.Connection = connection;
					command.CommandText = "select email from Users where email='" + txtEmail.Text + "'";

					OleDbDataReader reader = command.ExecuteReader();
					int count = 0;
					while (reader.Read())
					{
						if (txtEmail.Text == reader.GetString(0))
						{
							MessageBox.Show("Email already exist", "Duplicate Found!");
							count++;
						}
					}
					if (count == 0)
					{
						command2.CommandText = "insert into Users (userName,Address1,Address2,City,State,Zipcode,PhoneNumber,CreditCardDetails,CreditCardExpiration,email,userPassword) values('" + txtFullName.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtCity.Text + "','" + cmbState.Text + "','" + txtZipcode.Text + "','" + txtPhone.Text + "','" + txtCreditCard.Text + "','" + txtCCExpiration.Text + "','" + txtEmail.Text + "','" + hashedPassword + "')";
						command2.ExecuteNonQuery();
						MessageBox.Show("Data Saved");

					}

					connection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An Error Occured"+ex,"Error in creating a new account");
			}

			
			this.Close();
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

		private void lnkTandC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Who even cares to read Terms and Conditions?", "Really?");
		}
	}
}
