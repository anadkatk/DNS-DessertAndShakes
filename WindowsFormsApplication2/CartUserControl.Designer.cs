namespace WindowsFormsApplication2
{
	partial class CartUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label dateofLabel;
			System.Windows.Forms.Label productPriceLabel;
			System.Windows.Forms.Label productNameLabel;
			System.Windows.Forms.Label customerNameLabel;
			System.Windows.Forms.Label quantityLabel;
			System.Windows.Forms.Label netTotalLabel;
			this.dNSDataSet = new WindowsFormsApplication2.DNSDataSet();
			this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cartTableAdapter = new WindowsFormsApplication2.DNSDataSetTableAdapters.CartTableAdapter();
			this.tableAdapterManager = new WindowsFormsApplication2.DNSDataSetTableAdapters.TableAdapterManager();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblNetTotal = new System.Windows.Forms.Label();
			this.cmbCartID = new System.Windows.Forms.ComboBox();
			this.lblDateAndTime = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCheckout = new System.Windows.Forms.Button();
			iDLabel = new System.Windows.Forms.Label();
			dateofLabel = new System.Windows.Forms.Label();
			productPriceLabel = new System.Windows.Forms.Label();
			productNameLabel = new System.Windows.Forms.Label();
			customerNameLabel = new System.Windows.Forms.Label();
			quantityLabel = new System.Windows.Forms.Label();
			netTotalLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Location = new System.Drawing.Point(153, 89);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(21, 13);
			iDLabel.TabIndex = 0;
			iDLabel.Text = "ID:";
			// 
			// dateofLabel
			// 
			dateofLabel.AutoSize = true;
			dateofLabel.Location = new System.Drawing.Point(100, 129);
			dateofLabel.Name = "dateofLabel";
			dateofLabel.Size = new System.Drawing.Size(74, 13);
			dateofLabel.TabIndex = 6;
			dateofLabel.Text = "Date of Order:";
			// 
			// productPriceLabel
			// 
			productPriceLabel.AutoSize = true;
			productPriceLabel.Location = new System.Drawing.Point(101, 165);
			productPriceLabel.Name = "productPriceLabel";
			productPriceLabel.Size = new System.Drawing.Size(74, 13);
			productPriceLabel.TabIndex = 8;
			productPriceLabel.Text = "Product Price:";
			// 
			// productNameLabel
			// 
			productNameLabel.AutoSize = true;
			productNameLabel.Location = new System.Drawing.Point(97, 198);
			productNameLabel.Name = "productNameLabel";
			productNameLabel.Size = new System.Drawing.Size(78, 13);
			productNameLabel.TabIndex = 10;
			productNameLabel.Text = "Product Name:";
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Location = new System.Drawing.Point(381, 38);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(85, 13);
			customerNameLabel.TabIndex = 12;
			customerNameLabel.Text = "Customer Name:";
			// 
			// quantityLabel
			// 
			quantityLabel.AutoSize = true;
			quantityLabel.Location = new System.Drawing.Point(418, 62);
			quantityLabel.Name = "quantityLabel";
			quantityLabel.Size = new System.Drawing.Size(49, 13);
			quantityLabel.TabIndex = 14;
			quantityLabel.Text = "Quantity:";
			// 
			// netTotalLabel
			// 
			netTotalLabel.AutoSize = true;
			netTotalLabel.Location = new System.Drawing.Point(411, 86);
			netTotalLabel.Name = "netTotalLabel";
			netTotalLabel.Size = new System.Drawing.Size(54, 13);
			netTotalLabel.TabIndex = 16;
			netTotalLabel.Text = "Net Total:";
			// 
			// dNSDataSet
			// 
			this.dNSDataSet.DataSetName = "DNSDataSet";
			this.dNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cartBindingSource
			// 
			this.cartBindingSource.DataMember = "Cart";
			this.cartBindingSource.DataSource = this.dNSDataSet;
			// 
			// cartTableAdapter
			// 
			this.cartTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CartTableAdapter = this.cartTableAdapter;
			this.tableAdapterManager.ProductTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.DNSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "productPrice", true));
			this.lblProductPrice.Location = new System.Drawing.Point(180, 163);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(100, 23);
			this.lblProductPrice.TabIndex = 9;
			// 
			// lblProductName
			// 
			this.lblProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "productName", true));
			this.lblProductName.Location = new System.Drawing.Point(180, 197);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(100, 23);
			this.lblProductName.TabIndex = 11;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "customerName", true));
			this.lblCustomerName.Location = new System.Drawing.Point(471, 33);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(100, 23);
			this.lblCustomerName.TabIndex = 13;
			// 
			// lblNetTotal
			// 
			this.lblNetTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "NetTotal", true));
			this.lblNetTotal.Location = new System.Drawing.Point(471, 82);
			this.lblNetTotal.Name = "lblNetTotal";
			this.lblNetTotal.Size = new System.Drawing.Size(100, 23);
			this.lblNetTotal.TabIndex = 17;
			// 
			// cmbCartID
			// 
			this.cmbCartID.FormattingEnabled = true;
			this.cmbCartID.Location = new System.Drawing.Point(178, 86);
			this.cmbCartID.Name = "cmbCartID";
			this.cmbCartID.Size = new System.Drawing.Size(102, 21);
			this.cmbCartID.TabIndex = 18;
			this.cmbCartID.SelectedIndexChanged += new System.EventHandler(this.cmbCartID_SelectedIndexChanged);
			// 
			// lblDateAndTime
			// 
			this.lblDateAndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "productID", true));
			this.lblDateAndTime.Location = new System.Drawing.Point(180, 129);
			this.lblDateAndTime.Name = "lblDateAndTime";
			this.lblDateAndTime.Size = new System.Drawing.Size(100, 23);
			this.lblDateAndTime.TabIndex = 19;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(471, 59);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(45, 20);
			this.txtQuantity.TabIndex = 20;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(144, 25);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 38);
			this.btnRefresh.TabIndex = 21;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(598, 52);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCheckout
			// 
			this.btnCheckout.Location = new System.Drawing.Point(598, 105);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(75, 47);
			this.btnCheckout.TabIndex = 23;
			this.btnCheckout.Text = "Check out";
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// CartUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.lblDateAndTime);
			this.Controls.Add(this.cmbCartID);
			this.Controls.Add(netTotalLabel);
			this.Controls.Add(this.lblNetTotal);
			this.Controls.Add(quantityLabel);
			this.Controls.Add(customerNameLabel);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(productNameLabel);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(productPriceLabel);
			this.Controls.Add(this.lblProductPrice);
			this.Controls.Add(dateofLabel);
			this.Controls.Add(iDLabel);
			this.Name = "CartUserControl";
			this.Size = new System.Drawing.Size(738, 282);
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DNSDataSet dNSDataSet;
		private System.Windows.Forms.BindingSource cartBindingSource;
		private DNSDataSetTableAdapters.CartTableAdapter cartTableAdapter;
		private DNSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Label lblProductPrice;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblNetTotal;
		private System.Windows.Forms.ComboBox cmbCartID;
		private System.Windows.Forms.Label lblDateAndTime;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCheckout;
	}
}
