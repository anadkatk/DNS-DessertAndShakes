
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	
    public partial class HomePage : Form
    {
		
        public HomePage()
        {
            InitializeComponent();
			lblCurrentUser.Text = Globals.currentUser;
			eatInCustomControl1.BringToFront();
        }

		private void btnNavHome_Click(object sender, EventArgs e)
		{
			eatInCustomControl1.BringToFront();
		}

		private void btnEatIn_Click(object sender, EventArgs e)
		{
			firstCustomControl1.BringToFront();
		}

		private void btnDelivery_Click(object sender, EventArgs e)
		{
			deliveryCustomControl1.BringToFront();
		}
		private void picExit_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.Close();
					System.Environment.Exit(1);
				}
			}
			catch
			{
				MessageBox.Show("An error occured during exiting the program", "Exit button");
			}
		}

		private void btnCart_Click(object sender, EventArgs e)
		{
			cartUserControl1.BringToFront();
		}

		private void btnCarryOut_Click(object sender, EventArgs e)
		{
			deliveryCustomControl1.BringToFront();
			
		}
	}
}
