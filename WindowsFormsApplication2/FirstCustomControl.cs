using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class FirstCustomControl : UserControl
	{
		public FirstCustomControl()
		{
			InitializeComponent();
		}
		

		//Login login = new Login("admin123", "P@$$w0rd");

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide();
				UserLogin f3 = new UserLogin();
				f3.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void btnSignUp_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.Hide();
				SignUp f2 = new SignUp();
				f2.ShowDialog();
			}
			catch
			{
				MessageBox.Show("An error occured at sign up a new user.", "Sign Up Error");
			}
		}
	}


	
}
