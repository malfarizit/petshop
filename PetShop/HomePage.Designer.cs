
namespace PetShop
{
    partial class HomePage
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
            this.btncus = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btnprod = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncus
            // 
            this.btncus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncus.Location = new System.Drawing.Point(241, 288);
            this.btncus.Name = "btncus";
            this.btncus.Size = new System.Drawing.Size(167, 71);
            this.btncus.TabIndex = 2;
            this.btncus.Text = "Customer Page";
            this.btncus.UseVisualStyleBackColor = true;
            this.btncus.Click += new System.EventHandler(this.btncus_Click);
            // 
            // btnemp
            // 
            this.btnemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.Location = new System.Drawing.Point(515, 288);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(167, 71);
            this.btnemp.TabIndex = 3;
            this.btnemp.Text = "Employee Page";
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnprod
            // 
            this.btnprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprod.Location = new System.Drawing.Point(787, 288);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(167, 71);
            this.btnprod.TabIndex = 4;
            this.btnprod.Text = "Product Page";
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Maroon;
            this.btnclose.Location = new System.Drawing.Point(1140, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(52, 44);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 744);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnprod);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btncus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncus;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btnprod;
        private System.Windows.Forms.Button btnclose;
    }
}