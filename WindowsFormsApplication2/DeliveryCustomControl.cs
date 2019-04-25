using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
	
	public partial class DeliveryCustomControl : UserControl
	{
		public double totalPrice = 0;
		public Int32 productID;
		private OleDbConnection connection = new OleDbConnection();
		public DeliveryCustomControl()
		{
			
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Study\GSU Senior Project and Seminar 4900\Project\WindowsFormsApplication2\DNS.accdb;
Persist Security Info=False;";
		}
		
		
		
		public void radIceCream_Click_1(object sender, EventArgs e)
		{
			try
			{
				cmbProductName.Text = "";
				cmbProductName.Items.Clear();
				chkShake.Visible = true;
				chkExtraCheese.Visible = false;
				chkMayo.Visible = false;
				chkToasted.Visible = false;
				chkSalsa.Visible = false;
				lblFor2dollars.Visible = true;
				lblPrice.Text = "";
				lblSubCategory.Text = "";

				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				command.CommandText = "select * from Product where productCategory='Ice Cream'";

				OleDbDataReader reader = command.ExecuteReader();
				
				while (reader.Read())
				{
					cmbProductName.Items.Add(reader.GetString(1));
				}
				connection.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error occured in opening the database"+ex, "Ice Cream Radio Button Error");
			}
			

		}

	
		private void cmbProductName_SelectedIndexChanged_1(object sender, EventArgs e)
		{

			try
			{
				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				command.CommandText = "select * from Product where productName='" + cmbProductName.Text + "'";

				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					totalPrice = reader.GetDouble(2);
					
					lblPrice.Text = Convert.ToString(totalPrice);
					lblSubCategory.Text = reader.GetString(4);
					
					productID = reader.GetInt32(0);
				}

				connection.Close();

			}
			catch
			{
				MessageBox.Show("Error");
			}
		}

		private void radSandwich_Click(object sender, EventArgs e)
		{
			cmbProductName.Text = "";
			cmbProductName.SelectedIndex = -1;
			cmbProductName.Items.Clear();
			chkShake.Visible = false;
			chkExtraCheese.Visible = true;
			chkMayo.Visible = true;
			chkToasted.Visible = true;
			chkSalsa.Visible = true;
			lblFor2dollars.Visible = false;
			lblPrice.Text = "";
			lblSubCategory.Text = "";

			connection.Open();
			OleDbCommand command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "select * from Product where productCategory='Sandwich'";

			OleDbDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				cmbProductName.Items.Add(reader.GetString(1));
			}
			connection.Close();
		}

		private void radMisc_Click(object sender, EventArgs e)
		{
			cmbProductName.Text = "";
			cmbProductName.SelectedIndex = -1;
			cmbProductName.Items.Clear();
			chkShake.Visible = false;
			chkExtraCheese.Visible = false;
			chkMayo.Visible = false;
			chkToasted.Visible = false;
			chkSalsa.Visible = false;
			lblFor2dollars.Visible = false;
			lblPrice.Text = "";
			lblSubCategory.Text = "";

			connection.Open();
			OleDbCommand command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "select * from Product where productCategory='Miscellaneous'";

			OleDbDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				cmbProductName.Items.Add(reader.GetString(1));
			}
			connection.Close();
		}

		private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddToCart.Enabled = true;
		}
		DateTime nowt = DateTime.Now;
		//DateTime today = DateTime.Today;
		//DateTime dateTime = DateTime.UtcNow.Date;
		
		private void btnAddToCart_Click(object sender, EventArgs e)
		{
			try
			{
				//getproductid
				double netTotal = Double.Parse(lblPrice.Text) * Double.Parse(cmbQuantity.Text);
				//MessageBox.Show("Price : " + lblPrice.Text + "\nQuantity: " +cmbQuantity.Text + "\nTotal: "  + netTotal + "");
				connection.Open();
				
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				
				command.CommandText = "insert into cart(customerID,productID,customerName,productName,productPrice,quantity,NetTotal,dateof) values('" + Globals.currentUserID + "','" + productID + "','" + Globals.currentUser + "','" +cmbProductName.Text + "','"+ lblPrice.Text + "','" + cmbQuantity.Text + "','" + netTotal + "','" + nowt + "')";
				command.ExecuteNonQuery();
				MessageBox.Show("Data Saved");

				connection.Close();
				//Add to cart
				//MessageBox.Show(lblpPrice.Text + cmbProductName.Text + Globals.currentUserID + Globals.currentUser + cmbQuantity.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in adding to cart" + ex, "Error in cart from delivery custom control");
			}
			
		}

		private void chkShake_CheckedChanged(object sender, EventArgs e)
		{
			
			if (chkShake.Checked )
			{
				totalPrice = totalPrice + 2;
				lblPrice.Text = Convert.ToString(totalPrice);
			}
			else
			{
				totalPrice = totalPrice - 2;
				lblPrice.Text = Convert.ToString(totalPrice);
			}
		}

		private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
		{
			if (chkExtraCheese.Checked)
			{
				totalPrice = totalPrice + 1.5;
				lblPrice.Text = Convert.ToString(totalPrice);
			}
			else
			{
				totalPrice = totalPrice - 1.5;
				lblPrice.Text = Convert.ToString(totalPrice);
			}
		}
	}
}
