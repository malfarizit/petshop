
namespace PetShop
{
    partial class CustomerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCusSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerlist = new System.Windows.Forms.DataGridView();
            this.cusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusDJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alfaPetShopDataSet = new PetShop.AlfaPetShopDataSet();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.btnCusEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCusDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.customerTblTableAdapter = new PetShop.AlfaPetShopDataSetTableAdapters.CustomerTblTableAdapter();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCusSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCusEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.customerlist);
            this.panel1.Controls.Add(this.btnCusDelete);
            this.panel1.Controls.Add(this.btnCusEdit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtCusDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCusPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCusAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCusName);
            this.panel1.Location = new System.Drawing.Point(108, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 720);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(639, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 30;
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
            this.txtID.Size = new System.Drawing.Size(29, 26);
            this.txtID.TabIndex = 29;
            // 
            // btnCusSave
            // 
            this.btnCusSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusSave.Location = new System.Drawing.Point(298, 181);
            this.btnCusSave.Name = "btnCusSave";
            this.btnCusSave.Size = new System.Drawing.Size(98, 35);
            this.btnCusSave.TabIndex = 28;
            this.btnCusSave.Text = "Save Data";
            this.btnCusSave.UseVisualStyleBackColor = true;
            this.btnCusSave.Click += new System.EventHandler(this.btnCusSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(690, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email :";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusEmail.Location = new System.Drawing.Point(694, 80);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(160, 26);
            this.txtCusEmail.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(418, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Customer List";
            // 
            // customerlist
            // 
            this.customerlist.AllowUserToAddRows = false;
            this.customerlist.AutoGenerateColumns = false;
            this.customerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIdDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusAddDataGridViewTextBoxColumn,
            this.cusPhoneDataGridViewTextBoxColumn,
            this.cusEmailDataGridViewTextBoxColumn,
            this.cusDJDataGridViewTextBoxColumn});
            this.customerlist.DataSource = this.customerTblBindingSource;
            this.customerlist.Location = new System.Drawing.Point(22, 307);
            this.customerlist.Name = "customerlist";
            this.customerlist.ReadOnly = true;
            this.customerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerlist.Size = new System.Drawing.Size(922, 396);
            this.customerlist.TabIndex = 17;
            this.customerlist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerlist_CellContentDoubleClick);
            this.customerlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerlist_MouseDoubleClick);
            // 
            // cusIdDataGridViewTextBoxColumn
            // 
            this.cusIdDataGridViewTextBoxColumn.DataPropertyName = "CusId";
            this.cusIdDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.cusIdDataGridViewTextBoxColumn.Name = "cusIdDataGridViewTextBoxColumn";
            this.cusIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "CusName";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            this.cusNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusAddDataGridViewTextBoxColumn
            // 
            this.cusAddDataGridViewTextBoxColumn.DataPropertyName = "CusAdd";
            this.cusAddDataGridViewTextBoxColumn.HeaderText = "Customer Address";
            this.cusAddDataGridViewTextBoxColumn.Name = "cusAddDataGridViewTextBoxColumn";
            this.cusAddDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusAddDataGridViewTextBoxColumn.Width = 250;
            // 
            // cusPhoneDataGridViewTextBoxColumn
            // 
            this.cusPhoneDataGridViewTextBoxColumn.DataPropertyName = "CusPhone";
            this.cusPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cusPhoneDataGridViewTextBoxColumn.Name = "cusPhoneDataGridViewTextBoxColumn";
            this.cusPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusEmailDataGridViewTextBoxColumn
            // 
            this.cusEmailDataGridViewTextBoxColumn.DataPropertyName = "CusEmail";
            this.cusEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cusEmailDataGridViewTextBoxColumn.Name = "cusEmailDataGridViewTextBoxColumn";
            this.cusEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusDJDataGridViewTextBoxColumn
            // 
            this.cusDJDataGridViewTextBoxColumn.DataPropertyName = "CusDJ";
            this.cusDJDataGridViewTextBoxColumn.HeaderText = "Date Joint";
            this.cusDJDataGridViewTextBoxColumn.Name = "cusDJDataGridViewTextBoxColumn";
            this.cusDJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTblBindingSource
            // 
            this.customerTblBindingSource.DataMember = "CustomerTbl";
            this.customerTblBindingSource.DataSource = this.alfaPetShopDataSet;
            // 
            // alfaPetShopDataSet
            // 
            this.alfaPetShopDataSet.DataSetName = "AlfaPetShopDataSet";
            this.alfaPetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusDelete.Location = new System.Drawing.Point(526, 181);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(98, 35);
            this.btnCusDelete.TabIndex = 16;
            this.btnCusDelete.Text = "Delete Data";
            this.btnCusDelete.UseVisualStyleBackColor = true;
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // btnCusEdit
            // 
            this.btnCusEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCusEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusEdit.Location = new System.Drawing.Point(412, 181);
            this.btnCusEdit.Name = "btnCusEdit";
            this.btnCusEdit.Size = new System.Drawing.Size(98, 35);
            this.btnCusEdit.TabIndex = 15;
            this.btnCusEdit.Text = "Edit Data";
            this.btnCusEdit.UseVisualStyleBackColor = true;
            this.btnCusEdit.Click += new System.EventHandler(this.btnCusEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(486, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Joint :";
            // 
            // dtCusDate
            // 
            this.dtCusDate.CustomFormat = "yyyy-MM-dd";
            this.dtCusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCusDate.Location = new System.Drawing.Point(490, 155);
            this.dtCusDate.Name = "dtCusDate";
            this.dtCusDate.Size = new System.Drawing.Size(200, 20);
            this.dtCusDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(486, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone :";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhone.Location = new System.Drawing.Point(490, 80);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(160, 26);
            this.txtCusPhone.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(294, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address :";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddress.Location = new System.Drawing.Point(298, 80);
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(160, 95);
            this.txtCusAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(102, 80);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(160, 26);
            this.txtCusName.TabIndex = 0;
            // 
            // customerTblTableAdapter
            // 
            this.customerTblTableAdapter.ClearBeforeFill = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(1075, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 44);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Maroon;
            this.btnclose.Location = new System.Drawing.Point(1151, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(52, 44);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1204, 744);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView customerlist;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Button btnCusEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCusDate;
        private System.Windows.Forms.Button btnCusSave;
        private System.Windows.Forms.TextBox txtID;
        private AlfaPetShopDataSet alfaPetShopDataSet;
        private System.Windows.Forms.BindingSource customerTblBindingSource;
        private AlfaPetShopDataSetTableAdapters.CustomerTblTableAdapter customerTblTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusDJDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclose;
    }
}