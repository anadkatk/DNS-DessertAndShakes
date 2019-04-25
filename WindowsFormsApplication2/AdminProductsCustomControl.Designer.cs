namespace WindowsFormsApplication2
{
	partial class AdminProductsCustomControl
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
			this.dNSDataSet = new WindowsFormsApplication2.DNSDataSet();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new WindowsFormsApplication2.DNSDataSetTableAdapters.ProductTableAdapter();
			this.tableAdapterManager = new WindowsFormsApplication2.DNSDataSetTableAdapters.TableAdapterManager();
			this.productDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFetch = new System.Windows.Forms.Button();
			this.cmbProductID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbSubCateg = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
			this.SuspendLayout();
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
			// productDataGridView
			// 
			this.productDataGridView.AutoGenerateColumns = false;
			this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.productDataGridView.DataSource = this.productBindingSource;
			this.productDataGridView.Location = new System.Drawing.Point(3, 3);
			this.productDataGridView.Name = "productDataGridView";
			this.productDataGridView.ReadOnly = true;
			this.productDataGridView.Size = new System.Drawing.Size(543, 253);
			this.productDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "productID";
			this.dataGridViewTextBoxColumn1.HeaderText = "productID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "productName";
			this.dataGridViewTextBoxColumn2.HeaderText = "productName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "productPrice";
			this.dataGridViewTextBoxColumn3.HeaderText = "productPrice";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "productCategory";
			this.dataGridViewTextBoxColumn4.HeaderText = "productCategory";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "productSubCategory";
			this.dataGridViewTextBoxColumn5.HeaderText = "productSubCategory";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// btnFetch
			// 
			this.btnFetch.Location = new System.Drawing.Point(552, 3);
			this.btnFetch.Name = "btnFetch";
			this.btnFetch.Size = new System.Drawing.Size(75, 35);
			this.btnFetch.TabIndex = 2;
			this.btnFetch.Text = "Fetch";
			this.btnFetch.UseVisualStyleBackColor = true;
			this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
			// 
			// cmbProductID
			// 
			this.cmbProductID.FormattingEnabled = true;
			this.cmbProductID.Location = new System.Drawing.Point(613, 47);
			this.cmbProductID.Name = "cmbProductID";
			this.cmbProductID.Size = new System.Drawing.Size(74, 21);
			this.cmbProductID.TabIndex = 3;
			this.cmbProductID.SelectedIndexChanged += new System.EventHandler(this.cmbProductID_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(583, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(566, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(570, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Price :";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(613, 74);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(100, 20);
			this.txtProductName.TabIndex = 7;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(613, 104);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 20);
			this.txtPrice.TabIndex = 8;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(556, 194);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(556, 223);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(556, 252);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(552, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Category : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(549, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Sub Categ:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(613, 133);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 21);
			this.cmbCategory.TabIndex = 14;
			// 
			// cmbSubCateg
			// 
			this.cmbSubCateg.FormattingEnabled = true;
			this.cmbSubCateg.Location = new System.Drawing.Point(613, 165);
			this.cmbSubCateg.Name = "cmbSubCateg";
			this.cmbSubCateg.Size = new System.Drawing.Size(121, 21);
			this.cmbSubCateg.TabIndex = 15;
			// 
			// AdminProductsCustomControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmbSubCateg);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProductID);
			this.Controls.Add(this.btnFetch);
			this.Controls.Add(this.productDataGridView);
			this.Name = "AdminProductsCustomControl";
			this.Size = new System.Drawing.Size(738, 303);
			((System.ComponentModel.ISupportInitialize)(this.dNSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DNSDataSet dNSDataSet;
		private System.Windows.Forms.BindingSource productBindingSource;
		private DNSDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private DNSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView productDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button btnFetch;
		private System.Windows.Forms.ComboBox cmbProductID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbSubCateg;
	}
}
