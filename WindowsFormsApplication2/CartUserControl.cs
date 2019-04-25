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
	public partial class CartUserControl : UserControl
	{
		private OleDbConnection connection = new OleDbConnection();
		public CartUserControl()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Study\GSU Senior Project and Seminar 4900\Project\WindowsFormsApplication2\DNS.accdb;
Persist Security Info=False;";
		}

		private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.cartBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dNSDataSet);
		}
		
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			try
			{
				cmbCartID.Items.Clear();
				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				//command.CommandText = "select * from Cart where customerID='23'";
				command.CommandText = "select * from Cart WHERE CustomerName='"+Globals.currentUser+"'";
				OleDbDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					cmbCartID.Items.Add(reader.GetInt32(0));
				}
				connection.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in loading cart from database" + ex, "Error in Cart UserControl");
			}
		}

		private void cmbCartID_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				lblCustomerName.Text = "";
				lblDateAndTime.Text = "";
				lblNetTotal.Text = "";
				txtQuantity.Text = "";
				lblProductPrice.Text = "";
				lblProductName.Text = "";

				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				command.CommandText = "select * from Cart where cartID="+Int32.Parse(cmbCartID.Text)+"";

				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					lblCustomerName.Text = reader.GetString(6);
					lblDateAndTime.Text = reader.GetDateTime(3).ToString();
					lblNetTotal.Text = reader.GetString(8);
					txtQuantity.Text = reader.GetString(7);
					lblProductPrice.Text = reader.GetString(4);
					lblProductName.Text = reader.GetString(5);
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(""+ex);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure you want to delete cartID # " +cmbCartID.Text +"?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					connection.Open();
					OleDbCommand command = new OleDbCommand();
					command.Connection = connection;
					//command.CommandText = "select * from Cart where customerID='23'";
					command.CommandText = "delete * from Cart WHERE CartID=" + Int32.Parse(cmbCartID.Text) + "";
					OleDbDataReader reader = command.ExecuteReader();
					MessageBox.Show("Removed from cart successfully!");
					connection.Close();
					cmbCartID.SelectedIndex = -1;

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error in deleting the object"+ex);
			}
			
			
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			try
			{
				double grandTotal = 0;
				int counter=0;
				connection.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = connection;
				command.CommandText = "select NetTotal from Cart where customerID=" + Globals.currentUserID + "";

				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					grandTotal += double.Parse(reader.GetString(0));
					counter++;
					// delete this MessageBox.Show("current GT = " + grandTotal + " nt = " + reader.GetString(0));
				}
				
				if (MessageBox.Show("Your grand total is " + grandTotal + " for " + counter + " items. Do you want to proceed?", "Confirm Purchase", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					
					OleDbCommand command2 = new OleDbCommand();
					OleDbCommand command3 = new OleDbCommand();
					command2.Connection = connection;
					command3.Connection = connection;
					//command.CommandText = "select * from Cart where customerID='23'";
					command2.CommandText = "insert into OrderLogs SELECT * FROM Cart WHERE customerID=" + Globals.currentUserID + "";
					command3.CommandText = " delete * from Cart WHERE customerID=" + Globals.currentUserID + "";
					
					OleDbDataReader reader2 = command2.ExecuteReader();
					OleDbDataReader reader3 = command3.ExecuteReader();
					MessageBox.Show("Removed from cart successfully!");
					connection.Close();
					//cmbCartID.SelectedIndex = -1;

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in Checkout" + ex);
			}
			connection.Close();
		}
	}
}
