namespace DataAccessWithDataAdapter
{
    partial class Form2
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
            this.btnCustomersAndOrders = new System.Windows.Forms.Button();
            this.gvCustomersOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.btnProdCategories = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnLINQDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomersOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomersAndOrders
            // 
            this.btnCustomersAndOrders.Location = new System.Drawing.Point(361, 80);
            this.btnCustomersAndOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomersAndOrders.Name = "btnCustomersAndOrders";
            this.btnCustomersAndOrders.Size = new System.Drawing.Size(273, 42);
            this.btnCustomersAndOrders.TabIndex = 0;
            this.btnCustomersAndOrders.Text = "Customers And Orders";
            this.btnCustomersAndOrders.UseVisualStyleBackColor = true;
            this.btnCustomersAndOrders.Click += new System.EventHandler(this.btnCustomersAndOrders_Click);
            // 
            // gvCustomersOrders
            // 
            this.gvCustomersOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomersOrders.Location = new System.Drawing.Point(12, 130);
            this.gvCustomersOrders.Name = "gvCustomersOrders";
            this.gvCustomersOrders.RowTemplate.Height = 24;
            this.gvCustomersOrders.Size = new System.Drawing.Size(1450, 412);
            this.gvCustomersOrders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Country";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(173, 80);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(181, 33);
            this.cmbCountries.TabIndex = 3;
            this.cmbCountries.Text = "All Countries";
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // btnProdCategories
            // 
            this.btnProdCategories.Location = new System.Drawing.Point(884, 80);
            this.btnProdCategories.Name = "btnProdCategories";
            this.btnProdCategories.Size = new System.Drawing.Size(285, 42);
            this.btnProdCategories.TabIndex = 4;
            this.btnProdCategories.Text = "Products And Categories";
            this.btnProdCategories.UseVisualStyleBackColor = true;
            this.btnProdCategories.Click += new System.EventHandler(this.btnProdCategories_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(641, 78);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(237, 44);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Total Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnLINQDS
            // 
            this.btnLINQDS.Location = new System.Drawing.Point(1190, 80);
            this.btnLINQDS.Name = "btnLINQDS";
            this.btnLINQDS.Size = new System.Drawing.Size(208, 42);
            this.btnLINQDS.TabIndex = 6;
            this.btnLINQDS.Text = "LINQ To DataSets";
            this.btnLINQDS.UseVisualStyleBackColor = true;
            this.btnLINQDS.Click += new System.EventHandler(this.btnLINQDS_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 685);
            this.Controls.Add(this.btnLINQDS);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProdCategories);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvCustomersOrders);
            this.Controls.Add(this.btnCustomersAndOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomersOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomersAndOrders;
        private System.Windows.Forms.DataGridView gvCustomersOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Button btnProdCategories;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLINQDS;
    }
}