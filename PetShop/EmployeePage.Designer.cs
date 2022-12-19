
namespace PetShop
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.empNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alfaPetShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alfaPetShopDataSet = new PetShop.AlfaPetShopDataSet();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEmpBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.employeeTblTableAdapter = new PetShop.AlfaPetShopDataSetTableAdapters.EmployeeTblTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmployeeList);
            this.panel1.Controls.Add(this.btnEmpDelete);
            this.panel1.Controls.Add(this.btnEmpEdit);
            this.panel1.Controls.Add(this.btnEmpInsert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtEmpBirth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmpPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmpPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmpAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Location = new System.Drawing.Point(103, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 720);
            this.panel1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 126);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(26, 26);
            this.txtID.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(418, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Employee List";
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.AutoGenerateColumns = false;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNumDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empAddDataGridViewTextBoxColumn,
            this.empDOBDataGridViewTextBoxColumn,
            this.empPhoneDataGridViewTextBoxColumn,
            this.empPassDataGridViewTextBoxColumn});
            this.EmployeeList.DataSource = this.employeeTblBindingSource;
            this.EmployeeList.Location = new System.Drawing.Point(18, 311);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeList.Size = new System.Drawing.Size(922, 384);
            this.EmployeeList.TabIndex = 17;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            this.EmployeeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeeList_MouseDoubleClick);
            // 
            // empNumDataGridViewTextBoxColumn
            // 
            this.empNumDataGridViewTextBoxColumn.DataPropertyName = "EmpNum";
            this.empNumDataGridViewTextBoxColumn.HeaderText = "Employee Number";
            this.empNumDataGridViewTextBoxColumn.Name = "empNumDataGridViewTextBoxColumn";
            this.empNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // empAddDataGridViewTextBoxColumn
            // 
            this.empAddDataGridViewTextBoxColumn.DataPropertyName = "EmpAdd";
            this.empAddDataGridViewTextBoxColumn.HeaderText = "Employee Address";
            this.empAddDataGridViewTextBoxColumn.Name = "empAddDataGridViewTextBoxColumn";
            this.empAddDataGridViewTextBoxColumn.ReadOnly = true;
            this.empAddDataGridViewTextBoxColumn.Width = 200;
            // 
            // empDOBDataGridViewTextBoxColumn
            // 
            this.empDOBDataGridViewTextBoxColumn.DataPropertyName = "EmpDOB";
            this.empDOBDataGridViewTextBoxColumn.HeaderText = "Birth Day";
            this.empDOBDataGridViewTextBoxColumn.Name = "empDOBDataGridViewTextBoxColumn";
            this.empDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empPhoneDataGridViewTextBoxColumn
            // 
            this.empPhoneDataGridViewTextBoxColumn.DataPropertyName = "EmpPhone";
            this.empPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.empPhoneDataGridViewTextBoxColumn.Name = "empPhoneDataGridViewTextBoxColumn";
            this.empPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.empPhoneDataGridViewTextBoxColumn.Width = 140;
            // 
            // empPassDataGridViewTextBoxColumn
            // 
            this.empPassDataGridViewTextBoxColumn.DataPropertyName = "EmpPass";
            this.empPassDataGridViewTextBoxColumn.HeaderText = "Password";
            this.empPassDataGridViewTextBoxColumn.Name = "empPassDataGridViewTextBoxColumn";
            this.empPassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeTblBindingSource
            // 
            this.employeeTblBindingSource.DataMember = "EmployeeTbl";
            this.employeeTblBindingSource.DataSource = this.alfaPetShopDataSetBindingSource;
            // 
            // alfaPetShopDataSetBindingSource
            // 
            this.alfaPetShopDataSetBindingSource.DataSource = this.alfaPetShopDataSet;
            this.alfaPetShopDataSetBindingSource.Position = 0;
            // 
            // alfaPetShopDataSet
            // 
            this.alfaPetShopDataSet.DataSetName = "AlfaPetShopDataSet";
            this.alfaPetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDelete.Location = new System.Drawing.Point(526, 186);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(98, 35);
            this.btnEmpDelete.TabIndex = 16;
            this.btnEmpDelete.Text = "Delete Data";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpEdit.Location = new System.Drawing.Point(412, 186);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(98, 35);
            this.btnEmpEdit.TabIndex = 15;
            this.btnEmpEdit.Text = "Edit Data";
            this.btnEmpEdit.UseVisualStyleBackColor = true;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            // 
            // btnEmpInsert
            // 
            this.btnEmpInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmpInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpInsert.Location = new System.Drawing.Point(298, 186);
            this.btnEmpInsert.Name = "btnEmpInsert";
            this.btnEmpInsert.Size = new System.Drawing.Size(98, 35);
            this.btnEmpInsert.TabIndex = 14;
            this.btnEmpInsert.Text = "Save Data";
            this.btnEmpInsert.UseVisualStyleBackColor = true;
            this.btnEmpInsert.Click += new System.EventHandler(this.btnEmpInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(486, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birth :";
            // 
            // dtEmpBirth
            // 
            this.dtEmpBirth.CustomFormat = "yyyy-MM-dd";
            this.dtEmpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmpBirth.Location = new System.Drawing.Point(490, 155);
            this.dtEmpBirth.Name = "dtEmpBirth";
            this.dtEmpBirth.Size = new System.Drawing.Size(200, 20);
            this.dtEmpBirth.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(685, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password :";
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPassword.Location = new System.Drawing.Point(689, 80);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(160, 26);
            this.txtEmpPassword.TabIndex = 10;
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
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(490, 80);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(160, 26);
            this.txtEmpPhone.TabIndex = 8;
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
            // txtEmpAddress
            // 
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddress.Location = new System.Drawing.Point(298, 80);
            this.txtEmpAddress.Multiline = true;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(160, 95);
            this.txtEmpAddress.TabIndex = 6;
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
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(102, 80);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(160, 26);
            this.txtEmpName.TabIndex = 0;
            // 
            // employeeTblTableAdapter
            // 
            this.employeeTblTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(640, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Maroon;
            this.btnclose.Location = new System.Drawing.Point(1146, 12);
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
            this.btnback.Location = new System.Drawing.Point(1070, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 44);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 744);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPetShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnEmpInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEmpBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource alfaPetShopDataSetBindingSource;
        private AlfaPetShopDataSet alfaPetShopDataSet;
        private System.Windows.Forms.BindingSource employeeTblBindingSource;
        private AlfaPetShopDataSetTableAdapters.EmployeeTblTableAdapter employeeTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
    }
}