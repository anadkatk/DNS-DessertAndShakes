namespace WindowsFormsApplication2
{
	partial class DeliveryCustomControl
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
			System.Windows.Forms.Label productNameLabel;
			System.Windows.Forms.Label lblsoasdf;
			System.Windows.Forms.Label label3;
			this.grpDeliveryorCarryOut = new System.Windows.Forms.GroupBox();
			this.radDineIn = new System.Windows.Forms.RadioButton();
			this.radCarryOut = new System.Windows.Forms.RadioButton();
			this.radDelivery = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radMisc = new System.Windows.Forms.RadioButton();
			this.radSandwich = new System.Windows.Forms.RadioButton();
			this.radIceCream = new System.Windows.Forms.RadioButton();
			this.btnAddToCart = new System.Windows.Forms.Button();
			this.cmbQuantity = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.dNSDataSet = new WindowsFormsApplication2.DNSDataSet();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new WindowsFormsApplication2.DNSDataSetTableAdapters.ProductTableAdapter();
			this.tableAdapterManager = new WindowsFormsApplication2.DNSDataSetTableAdapters.TableAdapterManager();
			this.cmbProductName = new System.Windows.Forms.ComboBox();
			this.lblSubCategory = new System.Windows.Forms.Label();
			this.chkShake = new System.Windows.Forms.CheckBox();
			this.lblFor2dollars = new System.Windows.Forms.Label();
			this.chkExtraCheese = new System.Windows.Forms.CheckBox();
			this.chkToasted = new System.Windows.Forms.CheckBox();
			this.chkMayo = new System.Windows.Forms.CheckBox();
			this.chkSalsa = new System.Windows.Forms.CheckBox();
			productNameLabel = new System.Windows.Forms.Label();
			lblsoasdf = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			this.grpDeliveryorCarryOut.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// productNameLabel
			// 
			productNameLabel.AutoSize = true;
			productNameLabel.Location = new System.Drawing.Point(22, 93);
			productNameLabel.Name = "productNameLabel";
			productNameLabel.Size = new System.Drawing.Size(74, 13);
			productNameLabel.TabIndex = 11;
			productNameLabel.Text = "Sub Category:";
			// 
			// lblsoasdf
			// 
			lblsoasdf.AutoSize = true;
			lblsoasdf.Location = new System.Drawing.Point(219, 95);
			lblsoasdf.Name = "lblsoasdf";
			lblsoasdf.Size = new System.Drawing.Size(83, 13);
			lblsoasdf.TabIndex = 13;
			lblsoasdf.Text = "Product Price: $";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(15, 126);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(78, 13);
			label3.TabIndex = 19;
			label3.Text = "Product Name:";
			// 
			// grpDeliveryorCarryOut
			// 
			this.grpDeliveryorCarryOut.Controls.Add(this.radDineIn);
			this.grpDeliveryorCarryOut.Controls.Add(this.radCarryOut);
			this.grpDeliveryorCarryOut.Controls.Add(this.radDelivery);
			this.grpDeliveryorCarryOut.Location = new System.Drawing.Point(14, 20);
			this.grpDeliveryorCarryOut.Name = "grpDeliveryorCarryOut";
			this.grpDeliveryorCarryOut.Size = new System.Drawing.Size(260, 57);
			this.grpDeliveryorCarryOut.TabIndex = 0;
			this.grpDeliveryorCarryOut.TabStop = false;
			this.grpDeliveryorCarryOut.Text = "Delivery OR Carry Out";
			// 
			// radDineIn
			// 
			this.radDineIn.AutoSize = true;
			this.radDineIn.Location = new System.Drawing.Point(150, 30);
			this.radDineIn.Name = "radDineIn";
			this.radDineIn.Size = new System.Drawing.Size(59, 17);
			this.radDineIn.TabIndex = 3;
			this.radDineIn.Text = "Dine In";
			this.radDineIn.UseVisualStyleBackColor = true;
			// 
			// radCarryOut
			// 
			this.radCarryOut.AutoSize = true;
			this.radCarryOut.Location = new System.Drawing.Point(75, 30);
			this.radCarryOut.Name = "radCarryOut";
			this.radCarryOut.Size = new System.Drawing.Size(69, 17);
			this.radCarryOut.TabIndex = 2;
			this.radCarryOut.Text = "Carry Out";
			this.radCarryOut.UseVisualStyleBackColor = true;
			// 
			// radDelivery
			// 
			this.radDelivery.AutoSize = true;
			this.radDelivery.Checked = true;
			this.radDelivery.Location = new System.Drawing.Point(6, 30);
			this.radDelivery.Name = "radDelivery";
			this.radDelivery.Size = new System.Drawing.Size(63, 17);
			this.radDelivery.TabIndex = 1;
			this.radDelivery.TabStop = true;
			this.radDelivery.Text = "Delivery";
			this.radDelivery.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radMisc);
			this.groupBox1.Controls.Add(this.radSandwich);
			this.groupBox1.Controls.Add(this.radIceCream);
			this.groupBox1.Location = new System.Drawing.Point(309, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 57);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Category";
			// 
			// radMisc
			// 
			this.radMisc.AutoSize = true;
			this.radMisc.Location = new System.Drawing.Point(209, 19);
			this.radMisc.Name = "radMisc";
			this.radMisc.Size = new System.Drawing.Size(47, 17);
			this.radMisc.TabIndex = 3;
			this.radMisc.TabStop = true;
			this.radMisc.Text = "Misc";
			this.radMisc.UseVisualStyleBackColor = true;
			this.radMisc.Click += new System.EventHandler(this.radMisc_Click);
			// 
			// radSandwich
			// 
			this.radSandwich.AutoSize = true;
			this.radSandwich.Location = new System.Drawing.Point(104, 19);
			this.radSandwich.Name = "radSandwich";
			this.radSandwich.Size = new System.Drawing.Size(72, 17);
			this.radSandwich.TabIndex = 2;
			this.radSandwich.TabStop = true;
			this.radSandwich.Text = "Sandwich";
			this.radSandwich.UseVisualStyleBackColor = true;
			this.radSandwich.Click += new System.EventHandler(this.radSandwich_Click);
			// 
			// radIceCream
			// 
			this.radIceCream.AutoSize = true;
			this.radIceCream.Location = new System.Drawing.Point(11, 19);
			this.radIceCream.Name = "radIceCream";
			this.radIceCream.Size = new System.Drawing.Size(73, 17);
			this.radIceCream.TabIndex = 0;
			this.radIceCream.TabStop = true;
			this.radIceCream.Text = "Ice Cream";
			this.radIceCream.UseVisualStyleBackColor = true;
			this.radIceCream.Click += new System.EventHandler(this.radIceCream_Click_1);
			// 
			// btnAddToCart
			// 
			this.btnAddToCart.Enabled = false;
			this.btnAddToCart.Location = new System.Drawing.Point(558, 211);
			this.btnAddToCart.Name = "btnAddToCart";
			this.btnAddToCart.Size = new System.Drawing.Size(75, 46);
			this.btnAddToCart.TabIndex = 3;
			this.btnAddToCart.Text = "Add to Cart";
			this.btnAddToCart.UseVisualStyleBackColor = true;
			this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
			// 
			// cmbQuantity
			// 
			this.cmbQuantity.FormattingEnabled = true;
			this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "I need more"});
			this.cmbQuantity.Location = new System.Drawing.Point(539, 167);
			this.cmbQuantity.Name = "cmbQuantity";
			this.cmbQuantity.Size = new System.Drawing.Size(121, 21);
			this.cmbQuantity.TabIndex = 8;
			this.cmbQuantity.SelectedIndexChanged += new System.EventHandler(this.cmbQuantity_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(484, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Quantity:";
			// 
			// lblPrice
			// 
			this.lblPrice.Location = new System.Drawing.Point(303, 91);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(46, 23);
			this.lblPrice.TabIndex = 14;
			// 
			// dNSDataSet
			// 
			this.dNSDataSet.DataSetName = "DNSDataSet";
			this.dNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.dNSDataSet;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CartTableAdapter = null;
			this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
			this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.DNSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// cmbProductName
			// 
			this.cmbProductName.FormattingEnabled = true;
			this.cmbProductName.Location = new System.Drawing.Point(98, 123);
			this.cmbProductName.Name = "cmbProductName";
			this.cmbProductName.Size = new System.Drawing.Size(191, 21);
			this.cmbProductName.TabIndex = 18;
			this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged_1);
			// 
			// lblSubCategory
			// 
			this.lblSubCategory.AutoSize = true;
			this.lblSubCategory.Location = new System.Drawing.Point(98, 93);
			this.lblSubCategory.Name = "lblSubCategory";
			this.lblSubCategory.Size = new System.Drawing.Size(0, 13);
			this.lblSubCategory.TabIndex = 20;
			// 
			// chkShake
			// 
			this.chkShake.AutoSize = true;
			this.chkShake.Location = new System.Drawing.Point(38, 170);
			this.chkShake.Name = "chkShake";
			this.chkShake.Size = new System.Drawing.Size(107, 17);
			this.chkShake.TabIndex = 21;
			this.chkShake.Text = "Make it a Shake!";
			this.chkShake.UseVisualStyleBackColor = true;
			this.chkShake.Visible = false;
			this.chkShake.CheckedChanged += new System.EventHandler(this.chkShake_CheckedChanged);
			// 
			// lblFor2dollars
			// 
			this.lblFor2dollars.AutoSize = true;
			this.lblFor2dollars.Location = new System.Drawing.Point(60, 190);
			this.lblFor2dollars.Name = "lblFor2dollars";
			this.lblFor2dollars.Size = new System.Drawing.Size(85, 13);
			this.lblFor2dollars.TabIndex = 22;
			this.lblFor2dollars.Text = "For just $2 more.";
			this.lblFor2dollars.Visible = false;
			// 
			// chkExtraCheese
			// 
			this.chkExtraCheese.AutoSize = true;
			this.chkExtraCheese.Location = new System.Drawing.Point(164, 170);
			this.chkExtraCheese.Name = "chkExtraCheese";
			this.chkExtraCheese.Size = new System.Drawing.Size(119, 17);
			this.chkExtraCheese.TabIndex = 23;
			this.chkExtraCheese.Text = "Extra Cheese +$1.5";
			this.chkExtraCheese.UseVisualStyleBackColor = true;
			this.chkExtraCheese.Visible = false;
			this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
			// 
			// chkToasted
			// 
			this.chkToasted.AutoSize = true;
			this.chkToasted.Location = new System.Drawing.Point(164, 193);
			this.chkToasted.Name = "chkToasted";
			this.chkToasted.Size = new System.Drawing.Size(65, 17);
			this.chkToasted.TabIndex = 24;
			this.chkToasted.Text = "Toasted";
			this.chkToasted.UseVisualStyleBackColor = true;
			this.chkToasted.Visible = false;
			// 
			// chkMayo
			// 
			this.chkMayo.AutoSize = true;
			this.chkMayo.Location = new System.Drawing.Point(164, 216);
			this.chkMayo.Name = "chkMayo";
			this.chkMayo.Size = new System.Drawing.Size(52, 17);
			this.chkMayo.TabIndex = 25;
			this.chkMayo.Text = "Mayo";
			this.chkMayo.UseVisualStyleBackColor = true;
			this.chkMayo.Visible = false;
			// 
			// chkSalsa
			// 
			this.chkSalsa.AutoSize = true;
			this.chkSalsa.Location = new System.Drawing.Point(164, 239);
			this.chkSalsa.Name = "chkSalsa";
			this.chkSalsa.Size = new System.Drawing.Size(100, 17);
			this.chkSalsa.TabIndex = 26;
			this.chkSalsa.Text = "Coriander Salsa";
			this.chkSalsa.UseVisualStyleBackColor = true;
			this.chkSalsa.Visible = false;
			// 
			// DeliveryCustomControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkSalsa);
			this.Controls.Add(this.chkMayo);
			this.Controls.Add(this.chkToasted);
			this.Controls.Add(this.chkExtraCheese);
			this.Controls.Add(this.lblFor2dollars);
			this.Controls.Add(this.chkShake);
			this.Controls.Add(this.lblSubCategory);
			this.Controls.Add(label3);
			this.Controls.Add(this.cmbProductName);
			this.Controls.Add(lblsoasdf);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(productNameLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbQuantity);
			this.Controls.Add(this.btnAddToCart);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpDeliveryorCarryOut);
			this.Name = "DeliveryCustomControl";
			this.Size = new System.Drawing.Size(689, 282);
			this.grpDeliveryorCarryOut.ResumeLayout(false);
			this.grpDeliveryorCarryOut.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpDeliveryorCarryOut;
		private System.Windows.Forms.RadioButton radCarryOut;
		private System.Windows.Forms.RadioButton radDelivery;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radMisc;
		private System.Windows.Forms.RadioButton radSandwich;
		private System.Windows.Forms.RadioButton radIceCream;
		private System.Windows.Forms.Button btnAddToCart;
		private System.Windows.Forms.ComboBox cmbQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPrice;
		private DNSDataSet dNSDataSet;
		private System.Windows.Forms.BindingSource productBindingSource;
		private DNSDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private DNSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ComboBox cmbProductName;
		private System.Windows.Forms.Label lblSubCategory;
		private System.Windows.Forms.CheckBox chkShake;
		private System.Windows.Forms.Label lblFor2dollars;
		private System.Windows.Forms.RadioButton radDineIn;
		private System.Windows.Forms.CheckBox chkExtraCheese;
		private System.Windows.Forms.CheckBox chkToasted;
		private System.Windows.Forms.CheckBox chkMayo;
		private System.Windows.Forms.CheckBox chkSalsa;
	}
}
