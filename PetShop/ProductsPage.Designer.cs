
namespace PetShop
{
    partial class ProductsPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.alfaPetShopDataSet = new PetShop.AlfaPetShopDataSet();
            this.productTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTblTableAdapter = new PetShop.AlfaPetShopDataSetTableAdapters.ProductTblTableAdapter();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cmbProdCat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProdPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.productList);
            this.panel1.Controls.Add(this.btnProdDelete);
            this.panel1.Controls.Add(this.btnProdEdit);
            this.panel1.Controls.Add(this.btnProdSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProdQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Location = new System.Drawing.Point(108, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 720);
            this.panel1.TabIndex = 3;
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Items.AddRange(new object[] {
            "Cat",
            "Bird",
            "Dog",
            "Food",
            "Fish"});
            this.cmbProdCat.Location = new System.Drawing.Point(289, 80);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(173, 28);
            this.cmbProdCat.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(681, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price :";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrice.Location = new System.Drawing.Point(685, 80);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(160, 26);
            this.txtProdPrice.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(418, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Product List";
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AutoGenerateColumns = false;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodCatDataGridViewTextBoxColumn,
            this.prodQtyDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn});
            this.productList.DataSource = this.productTblBindingSource;
            this.productList.Location = new System.Drawing.Point(22, 307);
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(922, 396);
            this.productList.TabIndex = 17;
            this.productList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productList_MouseDoubleClick);
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDelete.Location = new System.Drawing.Point(526, 129);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(98, 35);
            this.btnProdDelete.TabIndex = 16;
            this.btnProdDelete.Text = "Delete Data";
            this.btnProdDelete.UseVisualStyleBackColor = true;
            // 
            // btnProdEdit
            // 
            this.btnProdEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdEdit.Location = new System.Drawing.Point(412, 129);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(98, 35);
            this.btnProdEdit.TabIndex = 15;
            this.btnProdEdit.Text = "Edit Data";
            this.btnProdEdit.UseVisualStyleBackColor = true;
            this.btnProdEdit.Click += new System.EventHandler(this.btnProdEdit_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSave.Location = new System.Drawing.Point(298, 129);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(98, 35);
            this.btnProdSave.TabIndex = 14;
            this.btnProdSave.Text = "Save Data";
            this.btnProdSave.UseVisualStyleBackColor = true;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(486, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity :";
            // 
            // txtProdQty
            // 
            this.txtProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdQty.Location = new System.Drawing.Point(490, 80);
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(160, 26);
            this.txtProdQty.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(285, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name :";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(102, 80);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(160, 26);
            this.txtProdName.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(641, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 112);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(30, 26);
            this.txtID.TabIndex = 32;
            // 
            // alfaPetShopDataSet
            // 
            this.alfaPetShopDataSet.DataSetName = "AlfaPetShopDataSet";
            this.alfaPetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTblBindingSource
            // 
            this.productTblBindingSource.DataMember = "ProductTbl";
            this.productTblBindingSource.DataSource = this.alfaPetShopDataSet;
            // 
            // productTblTableAdapter
            // 
            this.productTblTableAdapter.ClearBeforeFill = true;
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "ProdId";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // prodCatDataGridViewTextBoxColumn
            // 
            this.prodCatDataGridViewTextBoxColumn.DataPropertyName = "ProdCat";
            this.prodCatDataGridViewTextBoxColumn.HeaderText = "Product Category";
            this.prodCatDataGridViewTextBoxColumn.Name = "prodCatDataGridViewTextBoxColumn";
            this.prodCatDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodCatDataGridViewTextBoxColumn.Width = 223;
            // 
            // prodQtyDataGridViewTextBoxColumn
            // 
            this.prodQtyDataGridViewTextBoxColumn.DataPropertyName = "ProdQty";
            this.prodQtyDataGridViewTextBoxColumn.HeaderText = "Product Qty";
            this.prodQtyDataGridViewTextBoxColumn.Name = "prodQtyDataGridViewTextBoxColumn";
            this.prodQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodQtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Product Price";
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Maroon;
            this.btnclose.Location = new System.Drawing.Point(1147, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(52, 44);
            this.btnclose.TabIndex = 22;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(1071, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 44);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 744);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.ComboBox cmbProdCat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtID;
        private AlfaPetShopDataSet alfaPetShopDataSet;
        private System.Windows.Forms.BindingSource productTblBindingSource;
        private AlfaPetShopDataSetTableAdapters.ProductTblTableAdapter productTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
    }
}