namespace WindowsFormsApplication2
{
	partial class AdminPage
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProducts = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.adminProductsCustomControl1 = new WindowsFormsApplication2.AdminProductsCustomControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Controls.Add(this.btnProducts);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(105, 367);
			this.panel1.TabIndex = 0;
			// 
			// btnProducts
			// 
			this.btnProducts.Location = new System.Drawing.Point(5, 76);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(97, 55);
			this.btnProducts.TabIndex = 0;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkRed;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(105, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(742, 58);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(301, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "ADMIN";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// adminProductsCustomControl1
			// 
			this.adminProductsCustomControl1.Location = new System.Drawing.Point(111, 64);
			this.adminProductsCustomControl1.Name = "adminProductsCustomControl1";
			this.adminProductsCustomControl1.Size = new System.Drawing.Size(738, 303);
			this.adminProductsCustomControl1.TabIndex = 2;
			// 
			// AdminPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 367);
			this.Controls.Add(this.adminProductsCustomControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AdminPage";
			this.Text = "AdminPage";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private AdminProductsCustomControl adminProductsCustomControl1;
	}
}